using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAH_CS490.Utils;

namespace UAH_CS490
{
    class OS
    {
        public static int clockUnit = 3000;
        private int totalElapsedTime = 0;
        

        internal BindingList<Process> FinishedProcs { get => finishedProcs; set => finishedProcs = value; }
        internal List<Process> DisplayQueue { get => displayQueue; set => displayQueue = value; }
        public int TotalElapsedTime { get => totalElapsedTime; set => totalElapsedTime = value; }
        internal CPU CPU1 { get => cpu1; set => cpu1 = value; }
        internal CPU CPU2 { get => cpu2; set => cpu2 = value; }
        internal List<CPU> Cores { get => cores; set => cores = value; }

        private GUI gui;
        private bool pause = false;
        private CPU cpu1;
        private CPU cpu2;
        private List<Process> unarrivedProcs;
        private Queue<Process> processQueue = new Queue<Process>();
        private List<CPU> cores;
        private BindingList<Process> finishedProcs = new BindingList<Process>();
        private List<Process> displayQueue;
        private bool idle = false;
        public OS(GUI gui)
        {
            this.gui = gui;
            CPU1 = new CPU { OS = this, Name = "CPU 1" };
            CPU2 = new CPU { OS = this, Name = "CPU 2" };
            Cores = new List<CPU> { CPU1, CPU2 };
            unarrivedProcs = new List<Process>();
        }
        public void startOS()
        {
            pause = false;
            kernelLoop();

        }

        public async void kernelLoop()
        {
            while (!pause)
            {
                checkArrivals();
                await checkSystemIdle();
                if (!idle)
                {
                    foreach (CPU cpu in Cores)
                    {
                        if (cpu.CurrentProcess == null)
                        {
                            dispatch(cpu);
                        }
                        await cpu.run();
                    }
                    TotalElapsedTime++;
                }
                updateDisplay();
            }
        }


        // pauses the whole system, not individual CPU's
        public void stopOS()
        {
            pause = true;
        }

        public void resetOS()
        {
            pause = true;
            unarrivedProcs.Clear();
            FinishedProcs.Clear();
            TotalElapsedTime = 0;
            updateDisplay();
        }

        public async Task checkSystemIdle()
        {
            // if the process queue is empty, and neither cpu is currently working on a process: the OS goes idle
            if ((processQueue.Count == 0) && (Cores.Where(c => c.CurrentProcess == null).Count() == Cores.Count))
            {
                Console.WriteLine("time " + TotalElapsedTime + ": " + "system now idle");
                await Task.Delay(clockUnit);
                this.TotalElapsedTime++;
                idle = true;
            }
            // otherwise, it returns control to the cpu's
            else
            {
                idle = false;
            }
        }
        private void dispatch(CPU cpu)
        {
            if (processQueue.Count > 0)
            {
                cpu.CurrentProcess = processQueue.Dequeue();
                Console.WriteLine("time " + TotalElapsedTime + ": " + cpu.CurrentProcess.Name + " dispatched to " + cpu.Name);
                updateDisplay();


            }
            else
            {
                Console.WriteLine("time " + TotalElapsedTime + ": " + "no processes in queue for " + cpu.Name);
            }
        }

        private void checkArrivals()
        {

            List<Process> arrived = unarrivedProcs.Where(p => TotalElapsedTime >= p.ArrivalTime).ToList();
            foreach (Process p in arrived)
            {
                p.ArrivalTime = TotalElapsedTime;
                processQueue.Enqueue(p);
                unarrivedProcs.Remove(p);
                Console.WriteLine("time " + TotalElapsedTime + ": " + p.Name + " added to process queue");
            }
            updateDisplay();
        }

        private void updateDisplay()
        {
            displayQueue = processQueue.ToList();
            gui.setQueueTable();
            gui.setProcessLabels();
            gui.setTotalTimeLbl();

        }

        public void loadFileData()
        {
            foreach (DataRow row in FileHandler.dataFromFile.Rows)
            {
                int arrivalTime = int.Parse((string)row[0]);

                string name = (string)row[1];
                int serviceTime = int.Parse((string)row[2]);
                int priority = int.Parse((string)row[3]);

                unarrivedProcs.
                    Add(new Process
                    {
                        ArrivalTime = arrivalTime,
                        Name = name,
                        ServiceTime = serviceTime,
                        TimeRemaining = serviceTime,
                        Priority = priority
                    });

            }
        }
    }
}
