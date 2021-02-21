using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAH_CS490
{
    class CPU
    {

        public static int clockUnit = 0; // set by the GUI


        public static void start()
        {
            OS.idle = false;
            returnControlToOS();
        }
        public async static Task execute(Process currentProccess)
        {
            if (currentProccess.timeElapsed < currentProccess.serviceTime)
            {
                // this is good
                int timeLeft = currentProccess.serviceTime - currentProccess.timeElapsed;
                Program.GUI.setTimeRemaining(timeLeft);
                await Task.Delay(clockUnit);
                currentProccess.timeElapsed++;

                


            }
            else if (currentProccess.timeElapsed == currentProccess.serviceTime)
            {
                OS.noDispatch = true;
                Program.GUI.setCompleted(currentProccess.name);
            }
            returnControlToOS();

        }

        public static void returnControlToOS()
        {
            OS.regainControl();
        }

    }
}
