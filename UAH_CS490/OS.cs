using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class OS
    {
        static Process currentProccess;
        static Queue<Process> processQueue = new Queue<Process>();
        public static DataTable dataFromQueue = new DataTable();

        public static bool noDispatch = true;
        public static bool idle = true;
        public static int currentTime = 0;

        public static async void regainControl()
        {
            await kernelExecute();

        }

        private static async Task kernelExecute()
        {
            checkForNewArrivals(); // always check for new arrivals to add to the queue
            OS.currentTime++; // then uptick the clock
            Program.GUI.setTotalTime(OS.currentTime); // and set its label

            // check if a process has been dispatched
            if (noDispatch) // if none are currently dispatched, then we'll check to see if any are in the queue
            {
                if (processQueue.Count > 0) // if queue is not empty, then we'll dispatch
                {
                    dispatch();
                    noDispatch = false;
                    updateDT();
                    await CPU.execute(currentProccess); 
                }
                else // otherwise, we'll go idle
                {
                    idle = true;
                }

            } else // if a process is dispatched, then we will just return control to the CPU after checking for new arrivals
            {
                    await CPU.execute(currentProccess); 
            }

            
        }

        public static void checkForNewArrivals()
        {
            foreach (DataRow row in ProcessData.dataFromFile.Rows)
            {
                int arrivalTime = int.Parse((string)row[0]);
                if (arrivalTime == currentTime)
                {
                    string name = (string)row[1];
                    int serviceTime = int.Parse((string)row[2]);
                    int priority = int.Parse((string)row[3]);

                    processQueue.Enqueue(new Process
                    {
                        name = name,
                        serviceTime = serviceTime,
                        priority = priority,
                        timeElapsed = 0
                    });

                    updateDT();
                }
            }



        }


        public static void dispatch()
        {
            currentProccess = processQueue.Dequeue();
            Program.GUI.setProcessLabel(currentProccess.name);

        }
        public static void updateDT()
        {
            dataFromQueue = new DataTable();
            dataFromQueue.Columns.Add("Name");
            dataFromQueue.Columns.Add("Service Time");
            foreach (var process in processQueue)
            {
                DataRow dr = dataFromQueue.NewRow();
                dr["Name"] = process.name;
                dr["Service Time"] = process.serviceTime;
                dataFromQueue.Rows.Add(dr);
            }

            Program.GUI.setSourceForQueueDGV(dataFromQueue);
        }
    }
}
