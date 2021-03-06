using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class CPU
    {
        private OS os;
        private string name;
        private Process currentProcess;
        internal Process CurrentProcess { get => currentProcess; set => currentProcess = value; }
        public string Name { get => name; set => name = value; }
        internal OS OS { get => os; set => os = value; }


        public async Task run()
        {
            if (currentProcess != null)
            {
                await executePs();
            }
            else
            {
                await idle();
            }
        }
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

        private async Task idle()
        {
            Console.WriteLine("time " + os.TotalElapsedTime + ": " + name + " idles for 1 cycle");
            await Task.Delay(OS.clockUnit);

        }
        private void completePs()
        {
            Console.WriteLine("time " + os.TotalElapsedTime + ": " + name + " finishes " + currentProcess.Name);
            Process cp = currentProcess;
            int adjustedFinish = os.TotalElapsedTime + 1;
            os.FinishedProcs.Add(new Process
            {
                Name = cp.Name,
                ServiceTime = cp.ServiceTime,
                ArrivalTime = cp.ArrivalTime,
                FinishTime = adjustedFinish,
                TurnaroundTime = adjustedFinish - cp.ArrivalTime,
                NormalizedTAT = (float)(adjustedFinish - cp.ArrivalTime) / (float)cp.ServiceTime
            });
            currentProcess = null;
        }

    }
}
