using RW;
using System.Data;

namespace MainUI.Procedure.Autogeneration
{
    public partial class ucIOBox : UserControl
    {
        public ucIOBox()
        {
            InitializeComponent();
        }

        //DI容器
        List<ucUIDI> lstDI = [];
        Dictionary<string, ucUIDI> DicDI = [];

        //DO容器
        List<ucUIDO> lstDO = [];
        Dictionary<string, ucUIDO> DicDO = [];

        //加载所有控件
        T GetContainer<T>(string text) where T : Control, new()
        {
            T btn = new();
            if (btn is ITagSwitch)
                btn.Size = new Size(60, 40);  //按钮
            else
                btn.Size = new Size(90, 50);
            btn.Text = text;
            return btn;
        }

        DODIConfigBLL figebll = new();
        private void ucIOBox_Load(object sender, EventArgs e)
        {
            DataTable dt = figebll.GetDIDO(VarHelper.ModelID);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string LineNO = dt.Rows[i]["LineNO"].ToString();  //线号
                    int LineType = dt.Rows[i]["LineType"].ToInt(); //0：代表输出，1：代表输入
                    int Portindex = dt.Rows[i]["CardNo"].ToInt(); //板卡号
                    int index = dt.Rows[i]["CardFoot"].ToInt(); //点位下标
                    string plug = dt.Rows[i]["plug"].ToString(); //航插
                    string plugfoot = dt.Rows[i]["plugfoot"].ToString(); //航插引脚
                    string LineDesc = dt.Rows[i]["LineDesc"].ToString(); //线号说明
                    string InitValue = dt.Rows[i]["InitValue"].ToString(); //初始值0:0V，1:110V，2：负信号

                    if (LineNO.ToString().Length == 0)
                        continue;

                    if (LineType != 0)
                    {
                        var pic = GetContainer<ucUIDI>(LineNO);
                        pic.PortIndex = Portindex;
                        pic.Index = index;
                        pic.Plug = plug;
                        pic.Plugfoot = plugfoot;
                        pic.Switch = false;
                        lstDI.Add(pic);
                        if (DicDI.ContainsKey(LineNO))
                            MessageBox.Show(this, string.Format("当前线号【{0}】存在重复，请检查配置表线号是否重复！", LineNO));
                        DicDI.Add(LineNO, pic);
                        pic.AddToolTop(uiToolTip1, "线号：" + LineNO, $"航插号：{pic.Plug}，引脚号：{pic.Plugfoot}，输出板卡号：{pic.PortIndex}，板卡下标：{pic.Index}，线号说明：{LineDesc}");
                    }
                    else
                    {
                        var btn = GetContainer<ucUIDO>(LineNO);
                        btn.PortIndex = Portindex;
                        btn.Index = index;
                        btn.Plug = plug;
                        btn.Plugfoot = plugfoot;
                        btn.Tag = InitValue;
                        btn.Sort = i;
                        lstDO.Add(btn);
                        if (DicDO.ContainsKey(LineNO))
                            MessageBox.Show(this, string.Format("当前线号【{0}】存在重复，请检查配置表线号是否重复！", LineNO));
                        DicDO.Add(LineNO, btn);
                        btn.AddToolTop(uiToolTip1, "线号：" + LineNO, $"航插号：{btn.Plug}，引脚号：{btn.Plugfoot}，输出板卡号：{btn.PortIndex}，板卡下标：{btn.Index}，线号说明：{LineDesc}");

                        if (InitValue == "3" || InitValue == "2")
                        {
                            btn.FalseColor = Color.Red;
                            btn.trueCOlor = Color.LimeGreen;
                        }

                        if (InitValue == "2")
                        {
                            bool?[] TwoValue = [false, false];
                            Common.InitSatusWrite()[Portindex - 1].SetCardStatus(btn.Index, TwoValue);
                            Debug.WriteLine($"负信号输出，线号：" + LineNO, $"航插号：{btn.Plug}，引脚号：{btn.Plugfoot}，输出板卡号：{btn.PortIndex}，板卡下标：{btn.Index}，线号说明：{LineDesc}");
                            //OPC新输出模式
                            continue;
                        }

                        btn.ButtonClicked += MyControl_ButtonClicked;
                    }
                }
                InitControls(uiPanelDO, lstDO);
                InitControls(uiPanelDI, lstDI);
            }
        }

        private void InitControls<T>(FlowLayoutPanel panel, List<T> lstCon) where T : UserControl, new()
        {
            panel.SuspendLayout();
            for (int i = 0; i < lstCon.Count; i++)
            {
                panel.Controls.Add(lstCon[i]);
                panel.Controls.SetChildIndex(lstCon[i], i);
            }
            panel.ResumeLayout();
        }

        private void MyControl_ButtonClicked(object sender, EventArgs e)
        {
            if (!Common.DOgrp[63])
            {
                UIMessageBox.Show("制动柜电源未开启！");
                return;
            }
            var btn = sender as ucUIDO;
            int PTcardIndex = btn.PortIndex - 1; //新协议点位输出
            int PTIndex = btn.Index;
            string InitValue = btn.Tag.ToString();
            bool? Invalue = Common.InitStatusArray()[PTcardIndex][PTIndex]; //反馈点状态 S01-S24

            //第一次初始值，否则下标1为空
            bool?[] TwoValue =
            [
                true,
                true,
            ];

            if (!Invalue.HasValue)  //GetValueOrDefault
                TwoValue[1] = true;
            else if ((bool)Invalue)
                TwoValue[1] = false;

            //操作负信号用
            if (InitValue == "3")
            {
                bool? Outvalue = Common.InitSatusWrite()[PTcardIndex][PTIndex - 1]; //输出点状态 S25-S49
                if (Outvalue == null)
                {
                    TwoValue[0] = false;
                    TwoValue[1] = false;
                }
                else if (!(bool)Outvalue)
                {
                    TwoValue[0] = false;
                    TwoValue[1] = true;
                }
                Common.InitSatusWrite()[PTcardIndex].SetCardStatus(PTIndex, TwoValue); //OPC新输出模式
                return;
            }

            Common.InitSatusWrite()[PTcardIndex].SetCardStatus(PTIndex, TwoValue); //OPC新输出模式
            Debug.WriteLine($"航插号：{btn.Plug}，引脚号：{btn.Plugfoot}，输出板卡号：{btn.PortIndex}，板卡下标：{btn.Index}，OPC名称：S{PTIndex + 24}--实际：S{btn.Index}，输出值：{!Invalue}，Value[0]:{TwoValue[0]}，Value[1]:{TwoValue[1]}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDI.Count; i++)
            {
                int card = lstDI[i].PortIndex;
                int foot = lstDI[i].Index;
                int byteIndex = lstDI[i].Index / 8;
                int bitIndex = lstDI[i].Index % 8;
                lstDI[i].Switch = Common.InitStatusArray()[card - 1][foot];
            }

            for (int i = 0; i < lstDO.Count; i++)
            {
                int card = lstDO[i].PortIndex;
                int foot = lstDO[i].Index;
                int byteIndex = lstDO[i].Index / 8;
                int bitIndex = lstDO[i].Index % 8;
                int BtnTag = lstDO[i].Tag.ToInt();
                if (BtnTag != 2 && BtnTag != 3)
                {
                    lstDO[i].On = Common.InitStatusArray()[card - 1][foot];
                }
                if (BtnTag == 3 || BtnTag == 2)
                {
                    bool? Outvalue = Common.InitSatusWrite()[card - 1][foot - 1]; //输出点状态
                    if (Outvalue == null)
                    {
                        Invoke(() => { lstDO[i].On = true; });
                    }
                    else if (!(bool)Outvalue)
                    {
                        Invoke(() => { lstDO[i].On = false; });
                    }
                }
            }

        }
    }
}
