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


        //====================
        // data structures
        //====================


        /// UPDATE FOR VERSION 3
        // Only data structures still belonging to the OS is the list of unarrived processes . all the other data structures now belong to the CPU objects .
        /// UPDATE FOR VERSION 3


        // data structure to hold processes that have been read from file but not put in queue yet
        private List<Process> unarrivedProcs;

        //===================================
        // REFERENCES TO other class objects
        //===================================

        // references to the CPU's individually, and as a list
        private CPU cpu1;
        private CPU cpu2;
        private List<CPU> cores;
        // their properties for getting and setting
        internal CPU CPU1 { get => cpu1; set => cpu1 = value; }
        internal CPU CPU2 { get => cpu2; set => cpu2 = value; }
        internal List<CPU> Cores { get => cores; set => cores = value; }
        
        // OS has a reference to the gui so that it can update elements as its data changes
        private GUI gui;


        //===================================
        // Variables for managing state
        //===================================

        private bool pause = false; // how to start and stop the system
        private bool idle = false; // to mark when neither cpu is executing, so that the os itself advances the clock

        // 
        // time variables
        //

        public static int clockUnit = 3000; // set by the GUI
        private int totalElapsedTime = 0;
        public int TotalElapsedTime { get => totalElapsedTime; set => totalElapsedTime = value; } // not required but a way to show how much time has elapsed since simulation began


        // 
        // Round Robin variables
        //

        public static int quantumMax = 2; //


        public OS(GUI gui)
        {
            this.gui = gui;
            CPU1 = new CPU { OS = this, Name = "CPU 1 (RR)" };
            CPU2 = new CPU { OS = this, Name = "CPU 2" };
            Cores = new List<CPU> { CPU1, CPU2 };
            unarrivedProcs = new List<Process>();
        }
        public void startOS()
        {
            //unpause sim everytime start is clicked
            pause = false;
            //resume main loop of func
            kernelLoop();

        }

        //This is the main loop of simulation
        //It's only called if simulation is not paused
        //The first thing is does is check the data file to see if any processes are set to arrive at the current time stamp
        //If so it adds it to the process queue
        //Then it checks to see if entire system is idle
        //This only occurs if neither cpu is currently executing a process and the process queue is empty
        //If system is not idle then the OS will check if either CPU is currently not executing a process
        //And if so it will dispatch a process to that CPU 
        //Then it returns control to each CPU so they can execute their processes.
        public async void kernelLoop()
        {
            while (!pause)
            {
                checkArrivals();
                preempt();
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
                    //The system time is incremented after both CPUs have executed one unit of clock time
                    TotalElapsedTime++;
                }
                //The GUI is updated at the end of each system cycle
                updateDisplay();
            }
        }


        // Pauses the whole system
        public void stopOS()
        {
            pause = true;
        }

        // Reset Operating System
        // Pause is set to False by default, therefore set to True
        // Then Clear all unarrived and finished processes
        // Reset Elapsed Timer and update Display
        public void resetOS()
        {
            pause = true;
            unarrivedProcs.Clear();
            cpu1.FinishedProcs.Clear();
            cpu2.FinishedProcs.Clear(); 
            cpu1.CurrentProcess = null;
            cpu2.CurrentProcess = null;
            TotalElapsedTime = 0;
            updateDisplay();
        }

        public async Task checkSystemIdle()
        {
            // if the process queue is empty, and neither cpu is currently working on a process: the OS goes idle
            if ((cpu1.ProcessQueue.Count == 0) && (cpu2.ProcessQueue.Count == 0) && (Cores.Where(c => c.CurrentProcess == null).Count() == Cores.Count))
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
        //dispatches a process to an open non idle CPU
        //first checks to see if process queue is empty
        //if it's not then dequeue the next process for the CPU to execute, then update the GUI
        //if it is empty then leave an empty message
        private void dispatch(CPU cpu)
        {
            if (cpu.ProcessQueue.Count > 0)
            {
                cpu.QuantumCount = 0;
                cpu.CurrentProcess = cpu.ProcessQueue.Dequeue();
                Console.WriteLine("time " + TotalElapsedTime + ": " + cpu.CurrentProcess.Name + " dispatched to " + cpu.Name);
                updateDisplay();
            }
            // if there are no processes in queue, return from the function and log a message to console
            else
            {
                Console.WriteLine("time " + TotalElapsedTime + ": " + "no processes in queue for " + cpu.Name);
            }
        }

        private void preempt()
        {
            foreach (CPU cpu in Cores)
            {
                if (cpu.Name == "CPU 1 (RR)")
                {
                    if (cpu.QuantumCount == quantumMax)
                    {
                        if (cpu.CurrentProcess != null)
                        {
                            Console.WriteLine("time " + TotalElapsedTime + ": " + cpu.CurrentProcess.Name + " preempted on " + cpu.Name);
                            cpu.ProcessQueue.Enqueue(cpu.CurrentProcess);
                            cpu.CurrentProcess = null;
                        }
                    }
                }
            } }
        //Check Arrivals Function
        //If any unarrived processes have a Total Elapased Time greater than or equal to the Arrival Time, then store in vector
        //Loop through each Process, and for reach arrived process: 
        //Set Arrival Time to Total Elapsed Time, Add process to Queue, then remove that process
        //After looping through each arrived process, update the GUI display
        private void checkArrivals()
        {
            List<Process> arrived = unarrivedProcs.Where(p => TotalElapsedTime >= p.ArrivalTime).ToList();
            foreach (Process p in arrived)
            {
                Process copy1 = new Process
                {
                    Name = p.Name,
                    ArrivalTime = p.ArrivalTime,
                    ServiceTime = p.ServiceTime,
                    TimeRemaining = p.ServiceTime
                };
                Process copy2 = new Process
                {
                    Name = p.Name,
                    ArrivalTime = p.ArrivalTime,
                    ServiceTime = p.ServiceTime,
                    TimeRemaining = p.ServiceTime
                };
                //p.ArrivalTime = TotalElapsedTime;
                cpu1.ProcessQueue.Enqueue(copy1);
                cpu2.ProcessQueue.Enqueue(copy2);
                unarrivedProcs.Remove(p);
                Console.WriteLine("time " + TotalElapsedTime + ": " + p.Name + " added to both process queues");
            }
            updateDisplay();
        }

        //Update GUI Display for: Queue, Process, Total Time
        private void updateDisplay()
        {
            cpu1.DisplayQueue = cpu1.ProcessQueue.ToList();
            cpu2.DisplayQueue = cpu2.ProcessQueue.ToList();
            gui.setQueueTables();
            gui.setProcessLabels();
            gui.setTotalTimeLbl();
            gui.setNTATAvgs();

        }

        // This functions reads in the static datatable in the FileHandler class "dataFromFile"
        // iterating over each row and adding it to a list of processes called "unarrivedProcs"
        // These are not represented anywhere on the GUI - the OS in its kernel loop will check this
        // list each cycle and see if any processes therein have an arrival time matching the current
        // system time
        public void loadFileData()
        {
            cpu1.ProcessQueue.Clear();
            cpu2.ProcessQueue.Clear();
            foreach (DataRow row in FileHandler.dataFromFile.Rows)
            {

                // properties need to be parsed as either a string or an int, as they exist in the datatable
                // as just an object
                int arrivalTime = int.Parse((string)row[0]);
                string name = (string)row[1];
                int serviceTime = int.Parse((string)row[2]);
                int priority = int.Parse((string)row[3]);

                // a new process is initialized and added to the unnarivedProcs list
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
