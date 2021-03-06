using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{

    class Process
    {
        private string name;
        private int arrivalTime;
        private int serviceTime;
        private int timeRemaining;
        private int finishTime;
        private int turnaroundTime;
        private float normalizedTAT;
        private int priority;

        public int ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public int ServiceTime { get => serviceTime; set => serviceTime = value; }
        public int TimeRemaining { get => timeRemaining; set => timeRemaining = value; }
        public string Name { get => name; set => name = value; }
        public int TurnaroundTime { get => turnaroundTime; set => turnaroundTime = value; }
        public float NormalizedTAT { get => normalizedTAT; set => normalizedTAT = value; }
        public int FinishTime { get => finishTime; set => finishTime = value; }
        public int Priority { get => priority; set => priority = value; }
        public int timeElapsed { get; internal set; }
    }
}
