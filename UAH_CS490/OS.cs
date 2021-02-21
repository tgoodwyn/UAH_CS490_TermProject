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
        static int currentTime = 0;
        static int stopTime = 100;
        static Process currentProccess;
        static Queue<Process> processQueue = new Queue<Process>();
        public static DataTable dataFromQueue = new DataTable();

        public static bool noDispatch = true;


        public static async void regainControl()
        {
            await kernelExecute();

        }

        private static async Task kernelExecute()
        {
            while (currentTime < stopTime)
            {
                checkForNewArrivals();
                if (noDispatch)
                {
                    dispatch();
                    noDispatch = false;
                }
                await CPU.execute(currentProccess);
                currentTime++;
            }
        }

        public static void checkForNewArrivals()
        {
            foreach (DataRow row in ProcessData.dataFromFile.Rows)
            {
                int arrivalTime = row.Field<int>(0);
                if (arrivalTime == currentTime)
                {
                    string name = row.Field<string>(1);
                    int serviceTime = row.Field<int>(2);
                    int priority = row.Field<int>(3);

                    processQueue.Enqueue(new Process
                    {
                        name = name,
                        serviceTime = serviceTime,
                        priority = priority,
                        timeElapsed = 0
                    }) ;

                    updateDT();
                }
            }

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

        public static void dispatch()
        {
            if (processQueue.Peek() != null)
            {
                currentProccess = processQueue.Dequeue();
            }
            else
            {
                Console.WriteLine("all available processes run");
            }
        }
    }
}
