﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class CPU
    {

        // +++++++++VERSION 3 NOTES+++++++++++++
        // changes noted where they occur 
        // ++++++++++++++++++++++++++++++++++++++++

        //====================
        // CPU data structures
        //====================
        // +++++++++UPDATE FOR VERSION 3+++++++++++++
        // Results list and process queue now belong to the CPU objects .
        // ++++++++++++++++++++++++++++++++++++++++++
        //we use a queue to store waiting processes
        //whenever a CPU becomes ready to execute a new process it grabs a new process from the queue
        //this queue is represented as a table in the GUI
        //so everytime the queue changes the GUI table needs to be updated
        //however, only lists are allowed to be the data sources for GUI tables
        //so we use an intermediary list called display queue to store the process data, which then gets bound to the GUI
        private Queue<Process> processQueue = new Queue<Process>();
        internal Queue<Process> ProcessQueue { get => processQueue; set => processQueue = value; }
        internal List<Process> DisplayQueue { get => displayQueue; set => displayQueue = value; }
        private List<Process> displayQueue;

        // data source for the result table        
        private BindingList<Process> finishedProcs = new BindingList<Process>();
        internal BindingList<Process> FinishedProcs { get => finishedProcs; set => finishedProcs = value; }

        //====================
        // CPU references
        //====================
        //this class has 3 member variables and they are all private
        //however they all have properties, which have getter and setter methods that allow the variables to be changed and referenced outside the class
        private OS os;
        private string name;
        private Process currentProcess;
        internal Process CurrentProcess { get => currentProcess; set => currentProcess = value; }
        public string Name { get => name; set => name = value; }
        internal OS OS { get => os; set => os = value; }



        // +++++++++UPDATE FOR VERSION 3+++++++++++++
        //====================
        // scheduling variables
        //====================
        // round robin
        private int quantumCount;
        public int QuantumCount { get => quantumCount; set => quantumCount = value; }
        // performance metric
        private float avgNTAT =0f;
        public float AvgNTAT { get => avgNTAT; set => avgNTAT = value; }
        // ++++++++++++++++++++++++++++++++++++++++++

        //checks to see if it has a current process to execute
        //if yes then execute the process, calling executePs()
        //if no then call idle()
        public async Task run()
        {
            if (currentProcess != null)
            {
                quantumCount++;
                await executePs();
            }
            else
            {
                await idle();
            }
        }

        //executes the current process as well as printing the total time, CPU name, and process name
        //decrements time remaining on current process coninually until it reaches zero
        //once zero is reached it calls completePs() to complete the process
        public async Task executePs()
        {
            Console.WriteLine("time " + os.TotalElapsedTime + ": " + name + " executes " + currentProcess.Name);
            await Task.Delay(OS.clockUnit);
            currentProcess.TimeRemaining--;
            if (currentProcess.TimeRemaining == 0)
            {
                completePs();
            }
        }
        //Idle Fuction.
        //When Called: Print the OS Total Elapsed Time along with the name
        //And then wait 3000ms, before being able to be called again
        //Clock Unit is set to 3000 ms
        private async Task idle()
        {
            Console.WriteLine("time " + os.TotalElapsedTime + ": " + name + " idles for 1 cycle");
            await Task.Delay(OS.clockUnit);

        }
        //Complete Process Function
        //Prints the Total Elapsed Time for the current process when called
        //Add current process information to Finished Processes(Name, Service Time, Arrival Time, Finish Time, Turn Around Time)
        //Set Current Process to null to reset for next call1
        private void completePs()
        {
            Console.WriteLine("time " + os.TotalElapsedTime + ": " + name + " finishes " + currentProcess.Name);
            Process cp = currentProcess;
            int adjustedFinish = os.TotalElapsedTime + 1;
            finishedProcs.Add(new Process
            {
                Name = cp.Name,
                ServiceTime = cp.ServiceTime,
                ArrivalTime = cp.ArrivalTime,
                FinishTime = adjustedFinish,
                TurnaroundTime = adjustedFinish - cp.ArrivalTime,
                NormalizedTAT = (float)(adjustedFinish - cp.ArrivalTime) / (float)cp.ServiceTime
            });

            currentProcess = null;

            calculateAvgNTAT();
        }
        // ++++++++++++++++++++++++++++++++++++++++++
        // new in v3 - a way to compare performance of different scheduling
        // algos
        private void calculateAvgNTAT()
        {
            float sum = 0f;
            foreach(var p in finishedProcs)
            {
                sum += p.NormalizedTAT;
            }
            avgNTAT = sum / finishedProcs.Count;
        }

    }
}
