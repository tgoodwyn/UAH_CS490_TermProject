using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{

    class Process
    {
        //Initialize Variables
        //These are the variables used by the actual functions in the simulation
        //there is one for each of the columns in the data file and in the results table
        private string name;
        private int arrivalTime;
        private int serviceTime;
        private int timeRemaining;
        private int finishTime;
        private int turnaroundTime;
        private float normalizedTAT;
        private int priority;

        private float responseRatio;

        //These are the properties for each of those variables so that they can be accessed outside of this class
        public int ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public int ServiceTime { get => serviceTime; set => serviceTime = value; }
        public int TimeRemaining { get => timeRemaining; set => timeRemaining = value; }
        public string Name { get => name; set => name = value; }
        public int TurnaroundTime { get => turnaroundTime; set => turnaroundTime = value; }
        public float NormalizedTAT { get => normalizedTAT; set => normalizedTAT = value; }
        public int FinishTime { get => finishTime; set => finishTime = value; }
        public int Priority { get => priority; set => priority = value; }
        public float ResponseRatio { get => responseRatio; set => responseRatio = value; }
    }
}
