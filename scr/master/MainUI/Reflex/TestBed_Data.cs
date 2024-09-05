using MainUI.CurrencyHelper;
using MainUI.Procedure.Curve.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Reflex
{
    public class TestBed_Data
    {

        public struct AI
        {
            public static double PE01 => Common.AIgrp[18];
            public static double PE02 => Common.AIgrp[19];
            public static double PE03 => Common.AIgrp[20];
            public static double PE04 => Common.AIgrp[21];
            public static double PE05 => Common.AIgrp[22];
            public static double PE06 => Common.AIgrp[23];
            public static double PE07 => Common.AIgrp[24];
            public static double PE08 => Common.AIgrp[25];
            public static double PE09 => Common.AIgrp[26];
            public static double PE10 => Common.AIgrp[27];
            public static double PE11 => Common.AIgrp[28];
            public static double PE12 => Common.AIgrp[29];
            public static double PE13 => Common.AIgrp[30];
            public static double PE14 => Common.AIgrp[31];
            public static double PE15 => Common.AIgrp[32];
            public static double PE20B01 => Common.AIgrp[2];
            public static double PE20B02 => Common.AIgrp[3];
            public static double PE20B03 => Common.AIgrp[4];
            public static double PE20B04 => Common.AIgrp[5];
            public static double PE20B05 => Common.AIgrp[6];
            public static double PE20B06 => Common.AIgrp[7];
            public static double PE20B07 => Common.AIgrp[8];
            public static double PE20B08 => Common.AIgrp[9];
            public static double PE20B09 => Common.AIgrp[10];
            public static double PE20B10 => Common.AIgrp[11];
            public static double PE20B11 => Common.AIgrp[12];
            public static double PE20B12 => Common.AIgrp[13];
            public static double PE20B13 => Common.AIgrp[14];
            public static double PE20B14 => Common.AIgrp[15];
            public static double PE20B15 => Common.AIgrp[16];
            public static double PE20B16 => Common.AIgrp[17];
            public static double CabinetVoltage => Common.AIgrp[33]; //制动柜/辅压机电压
            public static double GateOneVoltage => Common.AIgrp[34];//闸1电压
            public static double GateTwoVoltage => Common.AIgrp[35];//闸2电压
            public static double ScreenVoltage => Common.AIgrp[36]; //显示屏电压
            public static double EIUVoltage => Common.AIgrp[37]; //EIU电压
        }
    }
}
