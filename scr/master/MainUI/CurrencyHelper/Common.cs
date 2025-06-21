using MainUI.Modules.IOCard;
using System.IO;

namespace MainUI.CurrencyHelper
{
    public class Common
    {

        public static OpcStatusGrp opcStatus = new();
        public static AIGrp AIgrp;
        public static AOGrp AOgrp;
        public static DIGrp DIgrp;
        public static DOGrp DOgrp;
        public static TestCon testcon;
        public static TestPara testpara;
        public static PLCCalibration plcc;
        public static TestViewModel mTestViewModel = new();
        public static ResultAll mResultAll = new();

        public static void Init()
        {
            AIgrp = new AIGrp();
            AOgrp = new AOGrp();
            DIgrp = new DIGrp();
            DOgrp = new DOGrp();
            testcon = new TestCon();
            testpara = new TestPara();
            plcc = new PLCCalibration();
            opcStatus.Init();
            AIgrp.Init();
            AOgrp.Init();
            DIgrp.Init();
            DOgrp.Init();
            testcon.Init();

            mode01.Init();
            mode02.Init();
            mode03.Init();
            mode04.Init();
            mode05.Init();
            mode06.Init();
            mode07.Init();
            status01.Init();
            status02.Init();
            status03.Init();
            status04.Init();
            status05.Init();
            status06.Init();
            status07.Init();
            satuswrite01.Init();
            satuswrite02.Init();
            satuswrite03.Init();
            satuswrite04.Init();
            satuswrite05.Init();
            satuswrite06.Init();
            satuswrite07.Init();
        }

        public static string ConvertPdfToBase64(string pdfFilePath)
        {
            // 确保文件存在
            if (!File.Exists(pdfFilePath))
                throw new FileNotFoundException("PDF文件未找到。");

            // 读取文件内容为字节数组
            byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);

            // 将字节数组转换为Base64字符串
            string base64Pdf = Convert.ToBase64String(pdfBytes);

            return base64Pdf;
        }


        #region IO板点位
        public static IOModels mode01 = new(1);
        public static IOModels mode02 = new(2);
        public static IOModels mode03 = new(3);
        public static IOModels mode04 = new(4);
        public static IOModels mode05 = new(5);
        public static IOModels mode06 = new(6);
        public static IOModels mode07 = new(7);

        public static IOStatus status01 = new(1);
        public static IOStatus status02 = new(2);
        public static IOStatus status03 = new(3);
        public static IOStatus status04 = new(4);
        public static IOStatus status05 = new(5);
        public static IOStatus status06 = new(6);
        public static IOStatus status07 = new(7);

        public static SatusWrite satuswrite01 = new(1);
        public static SatusWrite satuswrite02 = new(2);
        public static SatusWrite satuswrite03 = new(3);
        public static SatusWrite satuswrite04 = new(4);
        public static SatusWrite satuswrite05 = new(5);
        public static SatusWrite satuswrite06 = new(6);
        public static SatusWrite satuswrite07 = new(7);

        public static IOModels[] InitModeArray()
        {
            IOModels[] modeAry = [mode01, mode02, mode03, mode04, mode05, mode06, mode07];
            return modeAry;
        }

        public static IOStatus[] InitStatusArray()
        {
            IOStatus[] statusAry = [status01, status02, status03, status04, status05, status06, status07];
            return statusAry;
        }

        /// <summary>
        /// IO箱写值
        /// 00 断开
        /// 01 DC0V闭合
        /// 10 DC110V闭合
        /// 11 不控制，悬空
        /// </summary>
        /// <returns></returns>
        public static SatusWrite[] InitSatusWrite()
        {
            SatusWrite[] SatusWriteAry = [satuswrite01, satuswrite02, satuswrite03, satuswrite04, satuswrite05, satuswrite06, satuswrite07];
            return SatusWriteAry;
        }
        #endregion


    }
}
