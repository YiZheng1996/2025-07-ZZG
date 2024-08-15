using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Reflex
{
    public class MVB_Data
    {
        public static Random random = new Random();
        public struct AI
        {

            public static double MVBvalue1 => random.NextDouble() * 1000;
            public static double MVBvalue2 => random.NextDouble() * 1000;
            public static double MVBvalue3 => random.NextDouble() * 1000;
            public static double MVBvalue4 => random.NextDouble() * 1000;
            public static double MVBvalue5 => random.NextDouble() * 1000;
        }
    }
}
