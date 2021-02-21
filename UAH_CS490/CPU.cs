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
            returnControlToOS();
        }
        public async static Task execute(Process currentProccess)
        {
            if (currentProccess.timeElapsed < currentProccess.serviceTime)
            {
                await Task.Delay(clockUnit);
                currentProccess.timeElapsed++;
            } else if (currentProccess.timeElapsed == currentProccess.serviceTime)
            {
                OS.noDispatch = true;
                returnControlToOS();
            }

        }

        public static void returnControlToOS()
        {
            OS.regainControl();
        }

    }
}
