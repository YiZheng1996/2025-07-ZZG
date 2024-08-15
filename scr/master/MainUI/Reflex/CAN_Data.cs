using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Reflex
{
    public class CAN_Data
    {
        public static Random random = new Random();

        public struct AI
        {
            public static double CANvalue1 => random.NextDouble() * 1000;
            public static double CANvalue2 => random.NextDouble() * 1000;
            public static double CANvalue3 => random.NextDouble() * 1000;
            public static double CANvalue4 => random.NextDouble() * 1000;
            public static double CANvalue5 => random.NextDouble() * 1000;
        }
    }


}
