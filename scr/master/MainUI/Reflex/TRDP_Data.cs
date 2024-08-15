using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Reflex
{
    public class TRDP_Data
    {
        public static Random random = new Random();
        public struct AI
        {
            public static double TRDPvalue1 => random.NextDouble() * 1000;
            public static double TRDPvalue2 => random.NextDouble() * 1000;
            public static double TRDPvalue3 => random.NextDouble() * 1000;
            public static double TRDPvalue4 => random.NextDouble() * 1000;
            public static double TRDPvalue5 => random.NextDouble() * 1000;
        }
    }
}
