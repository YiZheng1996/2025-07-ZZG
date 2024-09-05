using MainUI.CurrencyHelper;
using MainUI.Procedure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.BLL
{
    //IO机箱，共7块卡。每块卡24个点。LED灯点位如下：
    /*
       O O O   电源灯  正常    故障
       O O O   点1     点2    点3
       O O O   点4     点5    点6
       ……
       ……
       O O O   点22    点23   点24
    */
    public class ModbusOnekeyChange
    {
        /// <summary>
        ///一键切换，存储线号输入输出信息。 
        /// </summary>
        static Dictionary<int, bool[]> dicChangeDIDO = new Dictionary<int, bool[]>();

        /// <summary>
        ///一键切换，存储初始值信息。 
        /// </summary>
        static Dictionary<int, bool?[]> dicInitValue = new Dictionary<int, bool?[]>();

        /// <summary>
        /// 箱子板卡数量
        /// </summary>
        const int CardSum = 6;

        private static void InitChangeBuffer()
        {
            dicChangeDIDO.Clear();
            for (int i = 0; i < CardSum; i++)
            {
                //int idx = i;

                int idx = i + 1;
                dicChangeDIDO.Add(idx, new bool[24]);
            }
        }

        private static void InitOutBuffer()
        {
            dicInitValue.Clear();
            for (int i = 0; i < CardSum; i++)
            {
                //int idx = i ;

                int idx = i + 1;
                dicInitValue.Add(idx, new bool?[24]);
            }
        }

        /// <summary>
        /// 切换点位的输入输出类型
        /// </summary>
        /// <param name="modelID"></param>
        public static void ChangeDODI(int modelID)
        {
            try
            {
                InitChangeBuffer();//清空缓冲区数据

                DODIConfigBLL bll = new DODIConfigBLL();
                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                List<DODIConfigView> lst = bll.GetConfigBymodelID(modelID);

                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                // if(lst.Count <=144)
                if (lst.Count < 1)
                    throw new Exception("该型号没有航插配置信息。请先在【Excel导入】功能，从Excel导入配置信息。");

                SetChangeDIDOSendByte(lst, false);
                ModbusSendDIDOChange();

                SetChangeDIDOSendByte(lst);
                ModbusSendDIDOChange();
            }
            catch (Exception ex)
            {
                string err = "ChangeDODI error;" + ex.Message;
                MessageBox.Show(err);
            }
        }


        /// <summary>
        /// 切换后，输出初始值
        /// </summary>
        /// <param name="modelID"></param>
        public static void OutputInitvalue(int modelID)
        {

            try
            {
                InitOutBuffer();//清空缓冲区数据

                DODIConfigBLL bll = new DODIConfigBLL();
                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                List<DODIConfigView> lst = bll.GetConfigBymodelID(modelID);

                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                // if(lst.Count <=144)
                if (lst.Count < 1)
                {
                    throw new Exception("该型号没有航插配置信息。请先在【Excel导入】功能，从Excel导入配置信息。");
                }

                SetInitvalueSendByte(lst);
                ModbusSendInitvalue();
            }
            catch (Exception ex)
            {
                string err = "OutputInitvalue error;" + ex.Message;
                throw new Exception(err);
            }
        }


        /// <summary>
        /// 切换后，输出初始值（新增方法，继承用）
        /// </summary>
        /// <param name="modelID"></param>
        public virtual void OutputInitvalueVir()
        {
            try
            {
                InitOutBuffer();//清空缓冲区数据

                DODIConfigBLL bll = new DODIConfigBLL();
                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                List<DODIConfigView> lst = bll.GetConfigBymodelID(VarHelper.ModelID.ToInt());

                //获取该型号的3个航插配置信息。48芯 * 3 = 144
                // if(lst.Count <=144)
                if (lst.Count < 1)
                {
                    throw new Exception("该型号没有航插配置信息。请先在【Excel导入】功能，从Excel导入配置信息。");
                }

                SetInitvalueSendByte(lst);
                NewModbusSendInitvalue();
            }
            catch (Exception ex)
            {
                string err = "OutputInitvalue error;" + ex.Message;
                MessageBox.Show(err);
            }
        }

        /// <summary>
        /// 设置单个DO点位值；
        /// <para>cardNO:板卡编号1-8</para>
        /// <para>cardFoot：板卡脚位：0-31</para>
        /// </summary>
        /// <param name="cardNO">板卡编号1-8</param>
        /// <param name="cardFoot">板卡脚位：0-31</param>
        /// <returns></returns>
        public static void SetDOsingle(int cardNo, int cardFoot, bool outValue)
        {
            try
            {
                if (cardNo < 1 || cardNo > 8)
                {
                    MessageBox.Show("板卡编号应该在1到8之间。", "SetDOsingle 提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cardFoot < 0 || cardFoot > 31)
                {
                    MessageBox.Show("板卡引脚应该在0到31之间。", "SetDOsingle 提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cardIndex = cardNo;// 表示板卡编号1-8. 
                int bitIndex = cardFoot; //当前引脚所在位索引

            }
            catch (Exception ex)
            {
                string err = "SetDOsingle error;" + ex.Message;
                throw new Exception(err);
            }
        }


        /// <summary>
        /// 发送切换输入输入命令
        /// </summary>
        private static void ModbusSendDIDOChange()
        {
            foreach (var item in dicChangeDIDO)
            {
                int cardNO = item.Key - 1;
                bool[] bit24Ary = item.Value;
                for (int i = 0; i < bit24Ary.Length; i++)
                {
                    int idx = i + 1;
                    Common.InitModeArray()[cardNO][idx] = bit24Ary[i];
                }
            }
        }

        /// <summary>
        /// 一键切换后，全部输出成悬空状态
        /// </summary>
        public static void AllSuspendInMidair()
        {
            bool[] value = new bool[] { true, false };
            foreach (var item in dicChangeDIDO)
            {
                int cardNO = item.Key - 1;
                bool[] bit24Ary = item.Value;
                for (int i = 0; i < bit24Ary.Length; i++)
                {
                    int idx = i + 1;
                    Common.InitSatusWrite()[cardNO].SetCardStatus(idx, value); //OPC新输出模式
                }
            }
        }



        private static void ModbusSendDIDOChange(bool[] TwoValue)
        {
            foreach (var item in dicChangeDIDO)
            {
                int cardNO = item.Key - 1;
                bool[] bit24Ary = item.Value;
                for (int i = 0; i < bit24Ary.Length; i++)
                {
                    int idx = i + 1;
                    Common.InitSatusWrite()[cardNO].SetCardStatus(idx, TwoValue);
                }
            }
        }

        /// <summary>
        /// 发送初始值
        /// </summary>
        private static void ModbusSendInitvalue()
        {
            foreach (var item in dicInitValue)
            {
                int cardNO = item.Key - 1;
                bool?[] bit24Ary = item.Value;

                for (int i = 0; i < bit24Ary.Length; i++)
                {
                    int idx = i + 1;
                    Common.InitStatusArray()[cardNO][idx] = (bool)bit24Ary[i];
                    Thread.Sleep(1);
                }
            }
        }


        /// <summary>
        /// 新协议发送初始值
        /// </summary>
        private static void NewModbusSendInitvalue()
        {
            foreach (var item in dicInitValue)
            {
                int cardNO = item.Key - 1;
                bool?[] bit24Ary = item.Value;

                for (int i = 0; i < bit24Ary.Length; i++)
                {
                    int idx = i + 1;
                    bool? value = bit24Ary[i];
                    bool?[] TwoValue = new bool?[2];

                    if (value == null)
                    {
                        TwoValue[0] = false;
                        TwoValue[1] = false;
                    }
                    else if ((bool)value)
                    {
                        TwoValue[0] = true;
                        TwoValue[1] = true;
                    }
                    else if (!(bool)value)
                    {
                        TwoValue[0] = true;
                        TwoValue[1] = false;
                    }

                    //OPCServer.InitStatusArray()[cardNO][idx] = bit24Ary[i];
                    Common.InitSatusWrite()[cardNO].SetCardStatus(idx, TwoValue); //OPC新输出模式
                }
            }
        }

        /// <summary>
        ///输入输出类型。 将每个板卡脚位的输入输出类型，填充到对应的字节数组中。组装好要发送给can的数据。
        /// </summary>
        /// <param name="list"></param>
        private static void SetChangeDIDOSendByte(List<DODIConfigView> list)
        {
            foreach (DODIConfigView item in list)
            {
                int cardIndex = item.CardNo;// 表示板卡编号1-7. 
                int bitIndex = item.CardFoot; //当前板卡脚位1-24。

                bitIndex = bitIndex - 1;
                if (item.LineType == 2)
                    dicChangeDIDO[cardIndex][bitIndex] = false;
                else
                    dicChangeDIDO[cardIndex][bitIndex] = item.LineType == 1 ? false : true;
            }

        }

        /// <summary>
        /// 全部点位切换成DI模式
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        private static void SetChangeDIDOSendByte(List<DODIConfigView> list, bool value)
        {
            foreach (DODIConfigView item in list)
            {
                int cardIndex = item.CardNo;// 表示板卡编号1-7. 
                int bitIndex = item.CardFoot; //当前板卡脚位1-24。

                bitIndex = bitIndex - 1;

                dicChangeDIDO[cardIndex][bitIndex] = value;
            }

        }

        /// <summary>
        ///初始值。 将每个板卡脚位的初始值，填充到对应的字节数组中。组装好要发送给can的数据。
        /// </summary>
        /// <param name="list"></param>
        private static void SetInitvalueSendByte(List<DODIConfigView> list)
        {
            foreach (DODIConfigView item in list)
            {
                int cardIndex = item.CardNo;// 表示板卡编号1-7. 
                int bitIndex = item.CardFoot; //当前板卡脚位1-24。

                bitIndex = bitIndex - 1;
                if (item.InitValue == 1)
                    dicInitValue[cardIndex][bitIndex] = true;
                else if (item.InitValue == 0)
                    dicInitValue[cardIndex][bitIndex] = false;
                else if (item.InitValue == 2)
                    dicInitValue[cardIndex][bitIndex] = null;
                else if (item.InitValue == 3)
                    dicInitValue[cardIndex][bitIndex] = null;

                //dicInitValue[cardIndex][bitIndex] = item.InitValue == 1 ? true : false;
            }

        }



    }
}
