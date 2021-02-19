using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class OS
    {
        static int time = 0;
        static int stop_time = 100;
        static Process currentProccess;
        static Queue<Process> processQueue;

        public static bool noDispatch = true;


        public static void regainControl()
        {
            while (time < stop_time)
            {
                checkForNewArrivals();
                if (noDispatch)
                {
                    dispatch();
                    noDispatch = false;
                }
                CPU.execute(currentProccess);
                time++;
            }

        }
        public static void checkForNewArrivals()
        {

            throw new NotImplementedException();
        }

        public static void dispatch()
        {
            if (processQueue.Peek() != null)
            {
                currentProccess = processQueue.Dequeue();
            } else
            {
                Console.WriteLine("all available processes run");
            }
        }
    }
}
