namespace MainUI
{
    partial class frmHardWare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            grpAI = new Sunny.UI.UIGroupBox();
            ucCalibration37 = new Procedure.UCCalibration();
            ucCalibration31 = new Procedure.UCCalibration();
            ucCalibration33 = new Procedure.UCCalibration();
            ucCalibration34 = new Procedure.UCCalibration();
            ucCalibration35 = new Procedure.UCCalibration();
            ucCalibration36 = new Procedure.UCCalibration();
            ucCalibration16 = new Procedure.UCCalibration();
            ucCalibration17 = new Procedure.UCCalibration();
            ucCalibration18 = new Procedure.UCCalibration();
            ucCalibration19 = new Procedure.UCCalibration();
            ucCalibration20 = new Procedure.UCCalibration();
            ucCalibration21 = new Procedure.UCCalibration();
            ucCalibration22 = new Procedure.UCCalibration();
            ucCalibration23 = new Procedure.UCCalibration();
            ucCalibration24 = new Procedure.UCCalibration();
            ucCalibration25 = new Procedure.UCCalibration();
            ucCalibration26 = new Procedure.UCCalibration();
            ucCalibration27 = new Procedure.UCCalibration();
            ucCalibration28 = new Procedure.UCCalibration();
            ucCalibration29 = new Procedure.UCCalibration();
            ucCalibration30 = new Procedure.UCCalibration();
            ucCalibration15 = new Procedure.UCCalibration();
            ucCalibration1 = new Procedure.UCCalibration();
            ucCalibration9 = new Procedure.UCCalibration();
            ucCalibration10 = new Procedure.UCCalibration();
            ucCalibration11 = new Procedure.UCCalibration();
            ucCalibration12 = new Procedure.UCCalibration();
            ucCalibration13 = new Procedure.UCCalibration();
            ucCalibration14 = new Procedure.UCCalibration();
            ucCalibration6 = new Procedure.UCCalibration();
            ucCalibration7 = new Procedure.UCCalibration();
            ucCalibration8 = new Procedure.UCCalibration();
            ucCalibration5 = new Procedure.UCCalibration();
            ucCalibration4 = new Procedure.UCCalibration();
            ucCalibration3 = new Procedure.UCCalibration();
            ucCalibration2 = new Procedure.UCCalibration();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            grpAO = new Sunny.UI.UIGroupBox();
            ucCalibration38 = new Procedure.UCCalibration();
            ucCalibration32 = new Procedure.UCCalibration();
            panel1.SuspendLayout();
            grpAI.SuspendLayout();
            panel2.SuspendLayout();
            grpAO.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel1.Location = new System.Drawing.Point(181, 2);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(276, 38);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(192, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 27);
            label2.TabIndex = 7;
            label2.Text = "增益值";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(12, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 27);
            label3.TabIndex = 7;
            label3.Text = "测定值";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(106, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 27);
            label1.TabIndex = 7;
            label1.Text = "零点值";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.DarkRed;
            label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label12.Location = new System.Drawing.Point(127, 948);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(433, 27);
            label12.TabIndex = 54;
            label12.Text = "计算公式：测定值 = 工程值 * 增益值 - 零点值  ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // grpAI
            // 
            grpAI.Controls.Add(ucCalibration37);
            grpAI.Controls.Add(ucCalibration31);
            grpAI.Controls.Add(ucCalibration33);
            grpAI.Controls.Add(ucCalibration34);
            grpAI.Controls.Add(ucCalibration35);
            grpAI.Controls.Add(ucCalibration36);
            grpAI.Controls.Add(ucCalibration16);
            grpAI.Controls.Add(ucCalibration17);
            grpAI.Controls.Add(ucCalibration18);
            grpAI.Controls.Add(ucCalibration19);
            grpAI.Controls.Add(ucCalibration20);
            grpAI.Controls.Add(ucCalibration21);
            grpAI.Controls.Add(ucCalibration22);
            grpAI.Controls.Add(ucCalibration23);
            grpAI.Controls.Add(ucCalibration24);
            grpAI.Controls.Add(ucCalibration25);
            grpAI.Controls.Add(ucCalibration26);
            grpAI.Controls.Add(ucCalibration27);
            grpAI.Controls.Add(ucCalibration28);
            grpAI.Controls.Add(ucCalibration29);
            grpAI.Controls.Add(ucCalibration30);
            grpAI.Controls.Add(ucCalibration15);
            grpAI.Controls.Add(ucCalibration1);
            grpAI.Controls.Add(ucCalibration9);
            grpAI.Controls.Add(ucCalibration10);
            grpAI.Controls.Add(ucCalibration11);
            grpAI.Controls.Add(ucCalibration12);
            grpAI.Controls.Add(ucCalibration13);
            grpAI.Controls.Add(ucCalibration14);
            grpAI.Controls.Add(ucCalibration6);
            grpAI.Controls.Add(ucCalibration7);
            grpAI.Controls.Add(ucCalibration8);
            grpAI.Controls.Add(ucCalibration5);
            grpAI.Controls.Add(ucCalibration4);
            grpAI.Controls.Add(ucCalibration3);
            grpAI.Controls.Add(ucCalibration2);
            grpAI.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grpAI.Location = new System.Drawing.Point(7, 41);
            grpAI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAI.MinimumSize = new System.Drawing.Size(1, 1);
            grpAI.Name = "grpAI";
            grpAI.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            grpAI.Size = new System.Drawing.Size(1215, 896);
            grpAI.TabIndex = 382;
            grpAI.Text = "输入检测";
            grpAI.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucCalibration37
            // 
            ucCalibration37.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration37.GainValue = 0D;
            ucCalibration37.Index = 36;
            ucCalibration37.Location = new System.Drawing.Point(634, 789);
            ucCalibration37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration37.Name = "ucCalibration37";
            ucCalibration37.Size = new System.Drawing.Size(561, 37);
            ucCalibration37.TabIndex = 42;
            ucCalibration37.Text = "显示器电压(V)";
            ucCalibration37.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration31
            // 
            ucCalibration31.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration31.GainValue = 0D;
            ucCalibration31.Index = 37;
            ucCalibration31.Location = new System.Drawing.Point(634, 836);
            ucCalibration31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration31.Name = "ucCalibration31";
            ucCalibration31.Size = new System.Drawing.Size(561, 37);
            ucCalibration31.TabIndex = 41;
            ucCalibration31.Text = "EIU电压(V)";
            ucCalibration31.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration33
            // 
            ucCalibration33.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration33.GainValue = 0D;
            ucCalibration33.Index = 17;
            ucCalibration33.Location = new System.Drawing.Point(634, 742);
            ucCalibration33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration33.Name = "ucCalibration33";
            ucCalibration33.Size = new System.Drawing.Size(561, 37);
            ucCalibration33.TabIndex = 39;
            ucCalibration33.Text = "20B16(kPa)";
            ucCalibration33.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration34
            // 
            ucCalibration34.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration34.GainValue = 0D;
            ucCalibration34.Index = 35;
            ucCalibration34.Location = new System.Drawing.Point(41, 836);
            ucCalibration34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration34.Name = "ucCalibration34";
            ucCalibration34.Size = new System.Drawing.Size(561, 37);
            ucCalibration34.TabIndex = 38;
            ucCalibration34.Text = "大小闸电压2(V)";
            ucCalibration34.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration35
            // 
            ucCalibration35.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration35.GainValue = 0D;
            ucCalibration35.Index = 34;
            ucCalibration35.Location = new System.Drawing.Point(41, 789);
            ucCalibration35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration35.Name = "ucCalibration35";
            ucCalibration35.Size = new System.Drawing.Size(561, 37);
            ucCalibration35.TabIndex = 37;
            ucCalibration35.Text = "大小闸电压1(V)";
            ucCalibration35.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration36
            // 
            ucCalibration36.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration36.GainValue = 0D;
            ucCalibration36.Index = 33;
            ucCalibration36.Location = new System.Drawing.Point(41, 742);
            ucCalibration36.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration36.Name = "ucCalibration36";
            ucCalibration36.Size = new System.Drawing.Size(561, 37);
            ucCalibration36.TabIndex = 36;
            ucCalibration36.Text = "制动柜电源(V)";
            ucCalibration36.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration16
            // 
            ucCalibration16.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration16.GainValue = 0D;
            ucCalibration16.Index = 16;
            ucCalibration16.Location = new System.Drawing.Point(634, 695);
            ucCalibration16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration16.Name = "ucCalibration16";
            ucCalibration16.Size = new System.Drawing.Size(561, 37);
            ucCalibration16.TabIndex = 35;
            ucCalibration16.Text = "20B15(kPa)";
            ucCalibration16.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration17
            // 
            ucCalibration17.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration17.GainValue = 0D;
            ucCalibration17.Index = 15;
            ucCalibration17.Location = new System.Drawing.Point(634, 648);
            ucCalibration17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration17.Name = "ucCalibration17";
            ucCalibration17.Size = new System.Drawing.Size(561, 37);
            ucCalibration17.TabIndex = 34;
            ucCalibration17.Text = "20B14(kPa)";
            ucCalibration17.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration18
            // 
            ucCalibration18.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration18.GainValue = 0D;
            ucCalibration18.Index = 14;
            ucCalibration18.Location = new System.Drawing.Point(634, 601);
            ucCalibration18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration18.Name = "ucCalibration18";
            ucCalibration18.Size = new System.Drawing.Size(561, 37);
            ucCalibration18.TabIndex = 33;
            ucCalibration18.Text = "20B13(kPa)";
            ucCalibration18.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration19
            // 
            ucCalibration19.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration19.GainValue = 0D;
            ucCalibration19.Index = 13;
            ucCalibration19.Location = new System.Drawing.Point(634, 554);
            ucCalibration19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration19.Name = "ucCalibration19";
            ucCalibration19.Size = new System.Drawing.Size(561, 37);
            ucCalibration19.TabIndex = 32;
            ucCalibration19.Tag = "";
            ucCalibration19.Text = "20B12(kPa)";
            ucCalibration19.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration20
            // 
            ucCalibration20.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration20.GainValue = 0D;
            ucCalibration20.Index = 12;
            ucCalibration20.Location = new System.Drawing.Point(634, 507);
            ucCalibration20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration20.Name = "ucCalibration20";
            ucCalibration20.Size = new System.Drawing.Size(561, 37);
            ucCalibration20.TabIndex = 31;
            ucCalibration20.Text = "20B11(kPa)";
            ucCalibration20.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration21
            // 
            ucCalibration21.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration21.GainValue = 0D;
            ucCalibration21.Index = 11;
            ucCalibration21.Location = new System.Drawing.Point(634, 460);
            ucCalibration21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration21.Name = "ucCalibration21";
            ucCalibration21.Size = new System.Drawing.Size(561, 37);
            ucCalibration21.TabIndex = 30;
            ucCalibration21.Text = "20B10(kPa)";
            ucCalibration21.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration22
            // 
            ucCalibration22.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration22.GainValue = 0D;
            ucCalibration22.Index = 10;
            ucCalibration22.Location = new System.Drawing.Point(634, 413);
            ucCalibration22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration22.Name = "ucCalibration22";
            ucCalibration22.Size = new System.Drawing.Size(561, 37);
            ucCalibration22.TabIndex = 29;
            ucCalibration22.Text = "20B09(kPa)";
            ucCalibration22.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration23
            // 
            ucCalibration23.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration23.GainValue = 0D;
            ucCalibration23.Index = 9;
            ucCalibration23.Location = new System.Drawing.Point(634, 366);
            ucCalibration23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration23.Name = "ucCalibration23";
            ucCalibration23.Size = new System.Drawing.Size(561, 37);
            ucCalibration23.TabIndex = 28;
            ucCalibration23.Tag = "";
            ucCalibration23.Text = "20B08(kPa)";
            ucCalibration23.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration24
            // 
            ucCalibration24.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration24.GainValue = 0D;
            ucCalibration24.Index = 8;
            ucCalibration24.Location = new System.Drawing.Point(634, 319);
            ucCalibration24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration24.Name = "ucCalibration24";
            ucCalibration24.Size = new System.Drawing.Size(561, 37);
            ucCalibration24.TabIndex = 27;
            ucCalibration24.Text = "20B07(kPa)";
            ucCalibration24.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration25
            // 
            ucCalibration25.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration25.GainValue = 0D;
            ucCalibration25.Index = 7;
            ucCalibration25.Location = new System.Drawing.Point(634, 272);
            ucCalibration25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration25.Name = "ucCalibration25";
            ucCalibration25.Size = new System.Drawing.Size(561, 37);
            ucCalibration25.TabIndex = 26;
            ucCalibration25.Text = "20B06(kPa)";
            ucCalibration25.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration26
            // 
            ucCalibration26.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration26.GainValue = 0D;
            ucCalibration26.Index = 6;
            ucCalibration26.Location = new System.Drawing.Point(634, 225);
            ucCalibration26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration26.Name = "ucCalibration26";
            ucCalibration26.Size = new System.Drawing.Size(561, 37);
            ucCalibration26.TabIndex = 25;
            ucCalibration26.Tag = "";
            ucCalibration26.Text = "20B05(kPa)";
            ucCalibration26.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration27
            // 
            ucCalibration27.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration27.GainValue = 0D;
            ucCalibration27.Index = 5;
            ucCalibration27.Location = new System.Drawing.Point(634, 178);
            ucCalibration27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration27.Name = "ucCalibration27";
            ucCalibration27.Size = new System.Drawing.Size(561, 37);
            ucCalibration27.TabIndex = 24;
            ucCalibration27.Text = "20B04(kPa)";
            ucCalibration27.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration28
            // 
            ucCalibration28.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration28.GainValue = 0D;
            ucCalibration28.Index = 4;
            ucCalibration28.Location = new System.Drawing.Point(634, 131);
            ucCalibration28.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration28.Name = "ucCalibration28";
            ucCalibration28.Size = new System.Drawing.Size(561, 37);
            ucCalibration28.TabIndex = 23;
            ucCalibration28.Text = "20B03(kPa)";
            ucCalibration28.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration29
            // 
            ucCalibration29.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration29.GainValue = 0D;
            ucCalibration29.Index = 3;
            ucCalibration29.Location = new System.Drawing.Point(634, 84);
            ucCalibration29.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration29.Name = "ucCalibration29";
            ucCalibration29.Size = new System.Drawing.Size(561, 37);
            ucCalibration29.TabIndex = 22;
            ucCalibration29.Text = "20B02(kPa)";
            ucCalibration29.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration30
            // 
            ucCalibration30.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration30.GainValue = 0D;
            ucCalibration30.Index = 2;
            ucCalibration30.Location = new System.Drawing.Point(634, 37);
            ucCalibration30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration30.Name = "ucCalibration30";
            ucCalibration30.Size = new System.Drawing.Size(561, 37);
            ucCalibration30.TabIndex = 21;
            ucCalibration30.Tag = "";
            ucCalibration30.Text = "20B01(kPa)";
            ucCalibration30.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration15
            // 
            ucCalibration15.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration15.GainValue = 0D;
            ucCalibration15.Index = 32;
            ucCalibration15.Location = new System.Drawing.Point(41, 695);
            ucCalibration15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration15.Name = "ucCalibration15";
            ucCalibration15.Size = new System.Drawing.Size(561, 37);
            ucCalibration15.TabIndex = 20;
            ucCalibration15.Text = "PE15(kPa)";
            ucCalibration15.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration1
            // 
            ucCalibration1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration1.GainValue = 0D;
            ucCalibration1.Index = 31;
            ucCalibration1.Location = new System.Drawing.Point(41, 648);
            ucCalibration1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration1.Name = "ucCalibration1";
            ucCalibration1.Size = new System.Drawing.Size(561, 37);
            ucCalibration1.TabIndex = 19;
            ucCalibration1.Text = "PE14(kPa)";
            ucCalibration1.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration9
            // 
            ucCalibration9.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration9.GainValue = 0D;
            ucCalibration9.Index = 30;
            ucCalibration9.Location = new System.Drawing.Point(41, 601);
            ucCalibration9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration9.Name = "ucCalibration9";
            ucCalibration9.Size = new System.Drawing.Size(561, 37);
            ucCalibration9.TabIndex = 18;
            ucCalibration9.Text = "PE13(kPa)";
            ucCalibration9.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration10
            // 
            ucCalibration10.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration10.GainValue = 0D;
            ucCalibration10.Index = 29;
            ucCalibration10.Location = new System.Drawing.Point(41, 554);
            ucCalibration10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration10.Name = "ucCalibration10";
            ucCalibration10.Size = new System.Drawing.Size(561, 37);
            ucCalibration10.TabIndex = 17;
            ucCalibration10.Tag = "";
            ucCalibration10.Text = "PE12(kPa)";
            ucCalibration10.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration11
            // 
            ucCalibration11.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration11.GainValue = 0D;
            ucCalibration11.Index = 28;
            ucCalibration11.Location = new System.Drawing.Point(41, 507);
            ucCalibration11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration11.Name = "ucCalibration11";
            ucCalibration11.Size = new System.Drawing.Size(561, 37);
            ucCalibration11.TabIndex = 16;
            ucCalibration11.Text = "PE11(kPa)";
            ucCalibration11.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration12
            // 
            ucCalibration12.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration12.GainValue = 0D;
            ucCalibration12.Index = 27;
            ucCalibration12.Location = new System.Drawing.Point(41, 460);
            ucCalibration12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration12.Name = "ucCalibration12";
            ucCalibration12.Size = new System.Drawing.Size(561, 37);
            ucCalibration12.TabIndex = 15;
            ucCalibration12.Text = "PE10(kPa)";
            ucCalibration12.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration13
            // 
            ucCalibration13.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration13.GainValue = 0D;
            ucCalibration13.Index = 26;
            ucCalibration13.Location = new System.Drawing.Point(41, 413);
            ucCalibration13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration13.Name = "ucCalibration13";
            ucCalibration13.Size = new System.Drawing.Size(561, 37);
            ucCalibration13.TabIndex = 14;
            ucCalibration13.Text = "PE09(kPa)";
            ucCalibration13.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration14
            // 
            ucCalibration14.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration14.GainValue = 0D;
            ucCalibration14.Index = 25;
            ucCalibration14.Location = new System.Drawing.Point(41, 366);
            ucCalibration14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration14.Name = "ucCalibration14";
            ucCalibration14.Size = new System.Drawing.Size(561, 37);
            ucCalibration14.TabIndex = 13;
            ucCalibration14.Tag = "";
            ucCalibration14.Text = "PE08(kPa)";
            ucCalibration14.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration6
            // 
            ucCalibration6.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration6.GainValue = 0D;
            ucCalibration6.Index = 24;
            ucCalibration6.Location = new System.Drawing.Point(41, 319);
            ucCalibration6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration6.Name = "ucCalibration6";
            ucCalibration6.Size = new System.Drawing.Size(561, 37);
            ucCalibration6.TabIndex = 12;
            ucCalibration6.Text = "PE07(kPa)";
            ucCalibration6.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration7
            // 
            ucCalibration7.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration7.GainValue = 0D;
            ucCalibration7.Index = 23;
            ucCalibration7.Location = new System.Drawing.Point(41, 272);
            ucCalibration7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration7.Name = "ucCalibration7";
            ucCalibration7.Size = new System.Drawing.Size(561, 37);
            ucCalibration7.TabIndex = 11;
            ucCalibration7.Text = "PE06(kPa)";
            ucCalibration7.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration8
            // 
            ucCalibration8.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration8.GainValue = 0D;
            ucCalibration8.Index = 22;
            ucCalibration8.Location = new System.Drawing.Point(41, 225);
            ucCalibration8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration8.Name = "ucCalibration8";
            ucCalibration8.Size = new System.Drawing.Size(561, 37);
            ucCalibration8.TabIndex = 10;
            ucCalibration8.Tag = "";
            ucCalibration8.Text = "PE05(kPa)";
            ucCalibration8.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration5
            // 
            ucCalibration5.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration5.GainValue = 0D;
            ucCalibration5.Index = 21;
            ucCalibration5.Location = new System.Drawing.Point(41, 178);
            ucCalibration5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration5.Name = "ucCalibration5";
            ucCalibration5.Size = new System.Drawing.Size(561, 37);
            ucCalibration5.TabIndex = 9;
            ucCalibration5.Text = "PE04(kPa)";
            ucCalibration5.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration4
            // 
            ucCalibration4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration4.GainValue = 0D;
            ucCalibration4.Index = 20;
            ucCalibration4.Location = new System.Drawing.Point(41, 131);
            ucCalibration4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration4.Name = "ucCalibration4";
            ucCalibration4.Size = new System.Drawing.Size(561, 37);
            ucCalibration4.TabIndex = 8;
            ucCalibration4.Text = "PE03(kPa)";
            ucCalibration4.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration3
            // 
            ucCalibration3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration3.GainValue = 0D;
            ucCalibration3.Index = 19;
            ucCalibration3.Location = new System.Drawing.Point(41, 84);
            ucCalibration3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration3.Name = "ucCalibration3";
            ucCalibration3.Size = new System.Drawing.Size(561, 37);
            ucCalibration3.TabIndex = 7;
            ucCalibration3.Text = "PE02(kPa)";
            ucCalibration3.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration2
            // 
            ucCalibration2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration2.GainValue = 0D;
            ucCalibration2.Index = 18;
            ucCalibration2.Location = new System.Drawing.Point(41, 37);
            ucCalibration2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration2.Name = "ucCalibration2";
            ucCalibration2.Size = new System.Drawing.Size(561, 37);
            ucCalibration2.TabIndex = 6;
            ucCalibration2.Tag = "";
            ucCalibration2.Text = "PE01(kPa)";
            ucCalibration2.Submited += ucCalibration_AI_Submited;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel2.Location = new System.Drawing.Point(672, 2);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(276, 38);
            panel2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(192, 5);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 27);
            label4.TabIndex = 7;
            label4.Text = "增益值";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(12, 5);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 27);
            label5.TabIndex = 7;
            label5.Text = "测定值";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(106, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 27);
            label6.TabIndex = 7;
            label6.Text = "零点值";
            // 
            // grpAO
            // 
            grpAO.Controls.Add(ucCalibration38);
            grpAO.Controls.Add(ucCalibration32);
            grpAO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grpAO.Location = new System.Drawing.Point(1230, 41);
            grpAO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpAO.MinimumSize = new System.Drawing.Size(1, 1);
            grpAO.Name = "grpAO";
            grpAO.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            grpAO.Size = new System.Drawing.Size(605, 896);
            grpAO.TabIndex = 383;
            grpAO.Text = "输出控制";
            grpAO.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucCalibration38
            // 
            ucCalibration38.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration38.GainValue = 0D;
            ucCalibration38.Index = 1;
            ucCalibration38.Location = new System.Drawing.Point(23, 84);
            ucCalibration38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration38.Name = "ucCalibration38";
            ucCalibration38.Size = new System.Drawing.Size(561, 37);
            ucCalibration38.TabIndex = 44;
            ucCalibration38.Tag = "";
            ucCalibration38.Text = "可调电源电流mA)";
            ucCalibration38.Submited += ucCalibration_AO_Submited;
            // 
            // ucCalibration32
            // 
            ucCalibration32.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ucCalibration32.GainValue = 0D;
            ucCalibration32.Location = new System.Drawing.Point(23, 37);
            ucCalibration32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucCalibration32.Name = "ucCalibration32";
            ucCalibration32.Size = new System.Drawing.Size(561, 37);
            ucCalibration32.TabIndex = 43;
            ucCalibration32.Tag = "";
            ucCalibration32.Text = "可调电源电压";
            ucCalibration32.Submited += ucCalibration_AO_Submited;
            // 
            // frmHardWare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            ClientSize = new System.Drawing.Size(1849, 985);
            Controls.Add(grpAO);
            Controls.Add(panel2);
            Controls.Add(grpAI);
            Controls.Add(label12);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHardWare";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "硬件校准";
            Load += frmHardWare_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAI.ResumeLayout(false);
            grpAI.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            grpAO.ResumeLayout(false);
            grpAO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIGroupBox grpAI;
        private Procedure.UCCalibration ucCalibration2;
        private Procedure.UCCalibration ucCalibration4;
        private Procedure.UCCalibration ucCalibration3;
        private Procedure.UCCalibration ucCalibration5;
        private Procedure.UCCalibration ucCalibration6;
        private Procedure.UCCalibration ucCalibration7;
        private Procedure.UCCalibration ucCalibration8;
        private Procedure.UCCalibration ucCalibration15;
        private Procedure.UCCalibration ucCalibration1;
        private Procedure.UCCalibration ucCalibration9;
        private Procedure.UCCalibration ucCalibration10;
        private Procedure.UCCalibration ucCalibration11;
        private Procedure.UCCalibration ucCalibration12;
        private Procedure.UCCalibration ucCalibration13;
        private Procedure.UCCalibration ucCalibration14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Procedure.UCCalibration ucCalibration16;
        private Procedure.UCCalibration ucCalibration17;
        private Procedure.UCCalibration ucCalibration18;
        private Procedure.UCCalibration ucCalibration19;
        private Procedure.UCCalibration ucCalibration20;
        private Procedure.UCCalibration ucCalibration21;
        private Procedure.UCCalibration ucCalibration22;
        private Procedure.UCCalibration ucCalibration23;
        private Procedure.UCCalibration ucCalibration24;
        private Procedure.UCCalibration ucCalibration25;
        private Procedure.UCCalibration ucCalibration26;
        private Procedure.UCCalibration ucCalibration27;
        private Procedure.UCCalibration ucCalibration28;
        private Procedure.UCCalibration ucCalibration29;
        private Procedure.UCCalibration ucCalibration30;
        private Procedure.UCCalibration ucCalibration31;
        private Procedure.UCCalibration ucCalibration33;
        private Procedure.UCCalibration ucCalibration34;
        private Procedure.UCCalibration ucCalibration35;
        private Procedure.UCCalibration ucCalibration36;
        private Procedure.UCCalibration ucCalibration37;
        private Sunny.UI.UIGroupBox grpAO;
        private Procedure.UCCalibration ucCalibration32;
        private Procedure.UCCalibration ucCalibration38;
    }
}