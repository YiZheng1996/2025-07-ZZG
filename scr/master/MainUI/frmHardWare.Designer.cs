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
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label12 = new Label();
            timer1 = new FormControl.Timer(components);
            grpAI = new UIGroupBox();
            panel3 = new Panel();
            ucCalibration39 = new UCCalibration();
            ucCalibration40 = new UCCalibration();
            ucCalibration41 = new UCCalibration();
            ucCalibration42 = new UCCalibration();
            ucCalibration43 = new UCCalibration();
            ucCalibration44 = new UCCalibration();
            ucCalibration45 = new UCCalibration();
            ucCalibration46 = new UCCalibration();
            ucCalibration47 = new UCCalibration();
            ucCalibration48 = new UCCalibration();
            ucCalibration49 = new UCCalibration();
            ucCalibration50 = new UCCalibration();
            ucCalibration51 = new UCCalibration();
            ucCalibration52 = new UCCalibration();
            ucCalibration53 = new UCCalibration();
            ucCalibration54 = new UCCalibration();
            ucCalibration37 = new UCCalibration();
            ucCalibration2 = new UCCalibration();
            ucCalibration31 = new UCCalibration();
            ucCalibration3 = new UCCalibration();
            ucCalibration33 = new UCCalibration();
            ucCalibration4 = new UCCalibration();
            ucCalibration34 = new UCCalibration();
            ucCalibration5 = new UCCalibration();
            ucCalibration35 = new UCCalibration();
            ucCalibration8 = new UCCalibration();
            ucCalibration36 = new UCCalibration();
            ucCalibration7 = new UCCalibration();
            ucCalibration16 = new UCCalibration();
            ucCalibration6 = new UCCalibration();
            ucCalibration17 = new UCCalibration();
            ucCalibration14 = new UCCalibration();
            ucCalibration18 = new UCCalibration();
            ucCalibration13 = new UCCalibration();
            ucCalibration19 = new UCCalibration();
            ucCalibration12 = new UCCalibration();
            ucCalibration20 = new UCCalibration();
            ucCalibration11 = new UCCalibration();
            ucCalibration21 = new UCCalibration();
            ucCalibration10 = new UCCalibration();
            ucCalibration22 = new UCCalibration();
            ucCalibration9 = new UCCalibration();
            ucCalibration23 = new UCCalibration();
            ucCalibration1 = new UCCalibration();
            ucCalibration24 = new UCCalibration();
            ucCalibration15 = new UCCalibration();
            ucCalibration25 = new UCCalibration();
            ucCalibration30 = new UCCalibration();
            ucCalibration26 = new UCCalibration();
            ucCalibration29 = new UCCalibration();
            ucCalibration27 = new UCCalibration();
            ucCalibration28 = new UCCalibration();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grpAO = new UIGroupBox();
            ucCalibration38 = new UCCalibration();
            ucCalibration32 = new UCCalibration();
            panel1.SuspendLayout();
            grpAI.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            grpAO.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("微软雅黑", 15F);
            panel1.Location = new Point(181, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 38);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(192, 5);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 7;
            label2.Text = "增益值";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 7;
            label3.Text = "测定值";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(106, 5);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 7;
            label1.Text = "零点值";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("微软雅黑", 15F);
            label12.ForeColor = Color.DarkRed;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(127, 948);
            label12.Name = "label12";
            label12.Size = new Size(433, 27);
            label12.TabIndex = 54;
            label12.Text = "计算公式：测定值 = 工程值 * 增益值 - 零点值  ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // grpAI
            // 
            grpAI.Controls.Add(panel3);
            grpAI.Font = new Font("微软雅黑", 11F);
            grpAI.Location = new Point(7, 41);
            grpAI.Margin = new Padding(4, 5, 4, 5);
            grpAI.MinimumSize = new Size(1, 1);
            grpAI.Name = "grpAI";
            grpAI.Padding = new Padding(0, 32, 0, 0);
            grpAI.Size = new Size(1215, 896);
            grpAI.TabIndex = 382;
            grpAI.Text = "输入检测";
            grpAI.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(ucCalibration39);
            panel3.Controls.Add(ucCalibration40);
            panel3.Controls.Add(ucCalibration41);
            panel3.Controls.Add(ucCalibration42);
            panel3.Controls.Add(ucCalibration43);
            panel3.Controls.Add(ucCalibration44);
            panel3.Controls.Add(ucCalibration45);
            panel3.Controls.Add(ucCalibration46);
            panel3.Controls.Add(ucCalibration47);
            panel3.Controls.Add(ucCalibration48);
            panel3.Controls.Add(ucCalibration49);
            panel3.Controls.Add(ucCalibration50);
            panel3.Controls.Add(ucCalibration51);
            panel3.Controls.Add(ucCalibration52);
            panel3.Controls.Add(ucCalibration53);
            panel3.Controls.Add(ucCalibration54);
            panel3.Controls.Add(ucCalibration37);
            panel3.Controls.Add(ucCalibration2);
            panel3.Controls.Add(ucCalibration31);
            panel3.Controls.Add(ucCalibration3);
            panel3.Controls.Add(ucCalibration33);
            panel3.Controls.Add(ucCalibration4);
            panel3.Controls.Add(ucCalibration34);
            panel3.Controls.Add(ucCalibration5);
            panel3.Controls.Add(ucCalibration35);
            panel3.Controls.Add(ucCalibration8);
            panel3.Controls.Add(ucCalibration36);
            panel3.Controls.Add(ucCalibration7);
            panel3.Controls.Add(ucCalibration16);
            panel3.Controls.Add(ucCalibration6);
            panel3.Controls.Add(ucCalibration17);
            panel3.Controls.Add(ucCalibration14);
            panel3.Controls.Add(ucCalibration18);
            panel3.Controls.Add(ucCalibration13);
            panel3.Controls.Add(ucCalibration19);
            panel3.Controls.Add(ucCalibration12);
            panel3.Controls.Add(ucCalibration20);
            panel3.Controls.Add(ucCalibration11);
            panel3.Controls.Add(ucCalibration21);
            panel3.Controls.Add(ucCalibration10);
            panel3.Controls.Add(ucCalibration22);
            panel3.Controls.Add(ucCalibration9);
            panel3.Controls.Add(ucCalibration23);
            panel3.Controls.Add(ucCalibration1);
            panel3.Controls.Add(ucCalibration24);
            panel3.Controls.Add(ucCalibration15);
            panel3.Controls.Add(ucCalibration25);
            panel3.Controls.Add(ucCalibration30);
            panel3.Controls.Add(ucCalibration26);
            panel3.Controls.Add(ucCalibration29);
            panel3.Controls.Add(ucCalibration27);
            panel3.Controls.Add(ucCalibration28);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(1215, 864);
            panel3.TabIndex = 52;
            // 
            // ucCalibration39
            // 
            ucCalibration39.Font = new Font("微软雅黑", 11F);
            ucCalibration39.GainValue = 0D;
            ucCalibration39.Index = 52;
            ucCalibration39.Location = new Point(613, 1143);
            ucCalibration39.Margin = new Padding(4, 5, 4, 5);
            ucCalibration39.Name = "ucCalibration39";
            ucCalibration39.Size = new Size(561, 37);
            ucCalibration39.TabIndex = 58;
            ucCalibration39.Text = "PS15(kPa)";
            ucCalibration39.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration40
            // 
            ucCalibration40.Font = new Font("微软雅黑", 11F);
            ucCalibration40.GainValue = 0D;
            ucCalibration40.Index = 53;
            ucCalibration40.Location = new Point(613, 1190);
            ucCalibration40.Margin = new Padding(4, 5, 4, 5);
            ucCalibration40.Name = "ucCalibration40";
            ucCalibration40.Size = new Size(561, 37);
            ucCalibration40.TabIndex = 57;
            ucCalibration40.Text = "PS16(kPa)";
            ucCalibration40.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration41
            // 
            ucCalibration41.Font = new Font("微软雅黑", 11F);
            ucCalibration41.GainValue = 0D;
            ucCalibration41.Index = 51;
            ucCalibration41.Location = new Point(613, 1096);
            ucCalibration41.Margin = new Padding(4, 5, 4, 5);
            ucCalibration41.Name = "ucCalibration41";
            ucCalibration41.Size = new Size(561, 37);
            ucCalibration41.TabIndex = 56;
            ucCalibration41.Text = "PS14(kPa)";
            ucCalibration41.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration42
            // 
            ucCalibration42.Font = new Font("微软雅黑", 11F);
            ucCalibration42.GainValue = 0D;
            ucCalibration42.Index = 45;
            ucCalibration42.Location = new Point(24, 1190);
            ucCalibration42.Margin = new Padding(4, 5, 4, 5);
            ucCalibration42.Name = "ucCalibration42";
            ucCalibration42.Size = new Size(561, 37);
            ucCalibration42.TabIndex = 55;
            ucCalibration42.Text = "PS08(kPa)";
            ucCalibration42.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration43
            // 
            ucCalibration43.Font = new Font("微软雅黑", 11F);
            ucCalibration43.GainValue = 0D;
            ucCalibration43.Index = 44;
            ucCalibration43.Location = new Point(24, 1143);
            ucCalibration43.Margin = new Padding(4, 5, 4, 5);
            ucCalibration43.Name = "ucCalibration43";
            ucCalibration43.Size = new Size(561, 37);
            ucCalibration43.TabIndex = 54;
            ucCalibration43.Text = "PS07(kPa)";
            ucCalibration43.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration44
            // 
            ucCalibration44.Font = new Font("微软雅黑", 11F);
            ucCalibration44.GainValue = 0D;
            ucCalibration44.Index = 43;
            ucCalibration44.Location = new Point(24, 1096);
            ucCalibration44.Margin = new Padding(4, 5, 4, 5);
            ucCalibration44.Name = "ucCalibration44";
            ucCalibration44.Size = new Size(561, 37);
            ucCalibration44.TabIndex = 53;
            ucCalibration44.Text = "PS06(kPa)";
            ucCalibration44.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration45
            // 
            ucCalibration45.Font = new Font("微软雅黑", 11F);
            ucCalibration45.GainValue = 0D;
            ucCalibration45.Index = 50;
            ucCalibration45.Location = new Point(613, 1049);
            ucCalibration45.Margin = new Padding(4, 5, 4, 5);
            ucCalibration45.Name = "ucCalibration45";
            ucCalibration45.Size = new Size(561, 37);
            ucCalibration45.TabIndex = 52;
            ucCalibration45.Text = "PS13(kPa)";
            ucCalibration45.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration46
            // 
            ucCalibration46.Font = new Font("微软雅黑", 11F);
            ucCalibration46.GainValue = 0D;
            ucCalibration46.Index = 49;
            ucCalibration46.Location = new Point(613, 1002);
            ucCalibration46.Margin = new Padding(4, 5, 4, 5);
            ucCalibration46.Name = "ucCalibration46";
            ucCalibration46.Size = new Size(561, 37);
            ucCalibration46.TabIndex = 51;
            ucCalibration46.Text = "PS12(kPa)";
            ucCalibration46.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration47
            // 
            ucCalibration47.Font = new Font("微软雅黑", 11F);
            ucCalibration47.GainValue = 0D;
            ucCalibration47.Index = 48;
            ucCalibration47.Location = new Point(613, 955);
            ucCalibration47.Margin = new Padding(4, 5, 4, 5);
            ucCalibration47.Name = "ucCalibration47";
            ucCalibration47.Size = new Size(561, 37);
            ucCalibration47.TabIndex = 50;
            ucCalibration47.Text = "PS11(kPa)";
            ucCalibration47.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration48
            // 
            ucCalibration48.Font = new Font("微软雅黑", 11F);
            ucCalibration48.GainValue = 0D;
            ucCalibration48.Index = 47;
            ucCalibration48.Location = new Point(613, 908);
            ucCalibration48.Margin = new Padding(4, 5, 4, 5);
            ucCalibration48.Name = "ucCalibration48";
            ucCalibration48.Size = new Size(561, 37);
            ucCalibration48.TabIndex = 49;
            ucCalibration48.Tag = "";
            ucCalibration48.Text = "PS10(kPa)";
            ucCalibration48.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration49
            // 
            ucCalibration49.Font = new Font("微软雅黑", 11F);
            ucCalibration49.GainValue = 0D;
            ucCalibration49.Index = 46;
            ucCalibration49.Location = new Point(613, 861);
            ucCalibration49.Margin = new Padding(4, 5, 4, 5);
            ucCalibration49.Name = "ucCalibration49";
            ucCalibration49.Size = new Size(561, 37);
            ucCalibration49.TabIndex = 48;
            ucCalibration49.Text = "PS09(kPa)";
            ucCalibration49.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration50
            // 
            ucCalibration50.Font = new Font("微软雅黑", 11F);
            ucCalibration50.GainValue = 0D;
            ucCalibration50.Index = 38;
            ucCalibration50.Location = new Point(24, 861);
            ucCalibration50.Margin = new Padding(4, 5, 4, 5);
            ucCalibration50.Name = "ucCalibration50";
            ucCalibration50.Size = new Size(561, 37);
            ucCalibration50.TabIndex = 43;
            ucCalibration50.Text = "PS01(kPa)";
            ucCalibration50.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration51
            // 
            ucCalibration51.Font = new Font("微软雅黑", 11F);
            ucCalibration51.GainValue = 0D;
            ucCalibration51.Index = 39;
            ucCalibration51.Location = new Point(24, 908);
            ucCalibration51.Margin = new Padding(4, 5, 4, 5);
            ucCalibration51.Name = "ucCalibration51";
            ucCalibration51.Size = new Size(561, 37);
            ucCalibration51.TabIndex = 44;
            ucCalibration51.Tag = "";
            ucCalibration51.Text = "PS02(kPa)";
            ucCalibration51.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration52
            // 
            ucCalibration52.Font = new Font("微软雅黑", 11F);
            ucCalibration52.GainValue = 0D;
            ucCalibration52.Index = 40;
            ucCalibration52.Location = new Point(24, 955);
            ucCalibration52.Margin = new Padding(4, 5, 4, 5);
            ucCalibration52.Name = "ucCalibration52";
            ucCalibration52.Size = new Size(561, 37);
            ucCalibration52.TabIndex = 45;
            ucCalibration52.Text = "PS03(kPa)";
            ucCalibration52.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration53
            // 
            ucCalibration53.Font = new Font("微软雅黑", 11F);
            ucCalibration53.GainValue = 0D;
            ucCalibration53.Index = 41;
            ucCalibration53.Location = new Point(24, 1002);
            ucCalibration53.Margin = new Padding(4, 5, 4, 5);
            ucCalibration53.Name = "ucCalibration53";
            ucCalibration53.Size = new Size(561, 37);
            ucCalibration53.TabIndex = 46;
            ucCalibration53.Text = "PS04(kPa)";
            ucCalibration53.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration54
            // 
            ucCalibration54.Font = new Font("微软雅黑", 11F);
            ucCalibration54.GainValue = 0D;
            ucCalibration54.Index = 42;
            ucCalibration54.Location = new Point(24, 1049);
            ucCalibration54.Margin = new Padding(4, 5, 4, 5);
            ucCalibration54.Name = "ucCalibration54";
            ucCalibration54.Size = new Size(561, 37);
            ucCalibration54.TabIndex = 47;
            ucCalibration54.Text = "PS05(kPa)";
            ucCalibration54.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration37
            // 
            ucCalibration37.Font = new Font("微软雅黑", 11F);
            ucCalibration37.GainValue = 0D;
            ucCalibration37.Index = 36;
            ucCalibration37.Location = new Point(613, 771);
            ucCalibration37.Margin = new Padding(4, 5, 4, 5);
            ucCalibration37.Name = "ucCalibration37";
            ucCalibration37.Size = new Size(561, 37);
            ucCalibration37.TabIndex = 42;
            ucCalibration37.Text = "显示器电压(V)";
            ucCalibration37.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration2
            // 
            ucCalibration2.Font = new Font("微软雅黑", 11F);
            ucCalibration2.GainValue = 0D;
            ucCalibration2.Index = 18;
            ucCalibration2.Location = new Point(24, 19);
            ucCalibration2.Margin = new Padding(4, 5, 4, 5);
            ucCalibration2.Name = "ucCalibration2";
            ucCalibration2.Size = new Size(561, 37);
            ucCalibration2.TabIndex = 6;
            ucCalibration2.Tag = "";
            ucCalibration2.Text = "PE01(kPa)";
            ucCalibration2.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration31
            // 
            ucCalibration31.Font = new Font("微软雅黑", 11F);
            ucCalibration31.GainValue = 0D;
            ucCalibration31.Index = 37;
            ucCalibration31.Location = new Point(613, 818);
            ucCalibration31.Margin = new Padding(4, 5, 4, 5);
            ucCalibration31.Name = "ucCalibration31";
            ucCalibration31.Size = new Size(561, 37);
            ucCalibration31.TabIndex = 41;
            ucCalibration31.Text = "EIU电压(V)";
            ucCalibration31.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration3
            // 
            ucCalibration3.Font = new Font("微软雅黑", 11F);
            ucCalibration3.GainValue = 0D;
            ucCalibration3.Index = 19;
            ucCalibration3.Location = new Point(24, 66);
            ucCalibration3.Margin = new Padding(4, 5, 4, 5);
            ucCalibration3.Name = "ucCalibration3";
            ucCalibration3.Size = new Size(561, 37);
            ucCalibration3.TabIndex = 7;
            ucCalibration3.Text = "PE02(kPa)";
            ucCalibration3.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration33
            // 
            ucCalibration33.Font = new Font("微软雅黑", 11F);
            ucCalibration33.GainValue = 0D;
            ucCalibration33.Index = 17;
            ucCalibration33.Location = new Point(613, 724);
            ucCalibration33.Margin = new Padding(4, 5, 4, 5);
            ucCalibration33.Name = "ucCalibration33";
            ucCalibration33.Size = new Size(561, 37);
            ucCalibration33.TabIndex = 39;
            ucCalibration33.Text = "20B16(kPa)";
            ucCalibration33.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration4
            // 
            ucCalibration4.Font = new Font("微软雅黑", 11F);
            ucCalibration4.GainValue = 0D;
            ucCalibration4.Index = 20;
            ucCalibration4.Location = new Point(24, 113);
            ucCalibration4.Margin = new Padding(4, 5, 4, 5);
            ucCalibration4.Name = "ucCalibration4";
            ucCalibration4.Size = new Size(561, 37);
            ucCalibration4.TabIndex = 8;
            ucCalibration4.Text = "PE03(kPa)";
            ucCalibration4.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration34
            // 
            ucCalibration34.Font = new Font("微软雅黑", 11F);
            ucCalibration34.GainValue = 0D;
            ucCalibration34.Index = 35;
            ucCalibration34.Location = new Point(24, 818);
            ucCalibration34.Margin = new Padding(4, 5, 4, 5);
            ucCalibration34.Name = "ucCalibration34";
            ucCalibration34.Size = new Size(561, 37);
            ucCalibration34.TabIndex = 38;
            ucCalibration34.Text = "大小闸电压2(V)";
            ucCalibration34.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration5
            // 
            ucCalibration5.Font = new Font("微软雅黑", 11F);
            ucCalibration5.GainValue = 0D;
            ucCalibration5.Index = 21;
            ucCalibration5.Location = new Point(24, 160);
            ucCalibration5.Margin = new Padding(4, 5, 4, 5);
            ucCalibration5.Name = "ucCalibration5";
            ucCalibration5.Size = new Size(561, 37);
            ucCalibration5.TabIndex = 9;
            ucCalibration5.Text = "PE04(kPa)";
            ucCalibration5.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration35
            // 
            ucCalibration35.Font = new Font("微软雅黑", 11F);
            ucCalibration35.GainValue = 0D;
            ucCalibration35.Index = 34;
            ucCalibration35.Location = new Point(24, 771);
            ucCalibration35.Margin = new Padding(4, 5, 4, 5);
            ucCalibration35.Name = "ucCalibration35";
            ucCalibration35.Size = new Size(561, 37);
            ucCalibration35.TabIndex = 37;
            ucCalibration35.Text = "大小闸电压1(V)";
            ucCalibration35.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration8
            // 
            ucCalibration8.Font = new Font("微软雅黑", 11F);
            ucCalibration8.GainValue = 0D;
            ucCalibration8.Index = 22;
            ucCalibration8.Location = new Point(24, 207);
            ucCalibration8.Margin = new Padding(4, 5, 4, 5);
            ucCalibration8.Name = "ucCalibration8";
            ucCalibration8.Size = new Size(561, 37);
            ucCalibration8.TabIndex = 10;
            ucCalibration8.Tag = "";
            ucCalibration8.Text = "PE05(kPa)";
            ucCalibration8.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration36
            // 
            ucCalibration36.Font = new Font("微软雅黑", 11F);
            ucCalibration36.GainValue = 0D;
            ucCalibration36.Index = 33;
            ucCalibration36.Location = new Point(24, 724);
            ucCalibration36.Margin = new Padding(4, 5, 4, 5);
            ucCalibration36.Name = "ucCalibration36";
            ucCalibration36.Size = new Size(561, 37);
            ucCalibration36.TabIndex = 36;
            ucCalibration36.Text = "制动柜电源(V)";
            ucCalibration36.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration7
            // 
            ucCalibration7.Font = new Font("微软雅黑", 11F);
            ucCalibration7.GainValue = 0D;
            ucCalibration7.Index = 23;
            ucCalibration7.Location = new Point(24, 254);
            ucCalibration7.Margin = new Padding(4, 5, 4, 5);
            ucCalibration7.Name = "ucCalibration7";
            ucCalibration7.Size = new Size(561, 37);
            ucCalibration7.TabIndex = 11;
            ucCalibration7.Text = "PE06(kPa)";
            ucCalibration7.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration16
            // 
            ucCalibration16.Font = new Font("微软雅黑", 11F);
            ucCalibration16.GainValue = 0D;
            ucCalibration16.Index = 16;
            ucCalibration16.Location = new Point(613, 677);
            ucCalibration16.Margin = new Padding(4, 5, 4, 5);
            ucCalibration16.Name = "ucCalibration16";
            ucCalibration16.Size = new Size(561, 37);
            ucCalibration16.TabIndex = 35;
            ucCalibration16.Text = "20B15(kPa)";
            ucCalibration16.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration6
            // 
            ucCalibration6.Font = new Font("微软雅黑", 11F);
            ucCalibration6.GainValue = 0D;
            ucCalibration6.Index = 24;
            ucCalibration6.Location = new Point(24, 301);
            ucCalibration6.Margin = new Padding(4, 5, 4, 5);
            ucCalibration6.Name = "ucCalibration6";
            ucCalibration6.Size = new Size(561, 37);
            ucCalibration6.TabIndex = 12;
            ucCalibration6.Text = "PE07(kPa)";
            ucCalibration6.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration17
            // 
            ucCalibration17.Font = new Font("微软雅黑", 11F);
            ucCalibration17.GainValue = 0D;
            ucCalibration17.Index = 15;
            ucCalibration17.Location = new Point(613, 630);
            ucCalibration17.Margin = new Padding(4, 5, 4, 5);
            ucCalibration17.Name = "ucCalibration17";
            ucCalibration17.Size = new Size(561, 37);
            ucCalibration17.TabIndex = 34;
            ucCalibration17.Text = "20B14(kPa)";
            ucCalibration17.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration14
            // 
            ucCalibration14.Font = new Font("微软雅黑", 11F);
            ucCalibration14.GainValue = 0D;
            ucCalibration14.Index = 25;
            ucCalibration14.Location = new Point(24, 348);
            ucCalibration14.Margin = new Padding(4, 5, 4, 5);
            ucCalibration14.Name = "ucCalibration14";
            ucCalibration14.Size = new Size(561, 37);
            ucCalibration14.TabIndex = 13;
            ucCalibration14.Tag = "";
            ucCalibration14.Text = "PE08(kPa)";
            ucCalibration14.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration18
            // 
            ucCalibration18.Font = new Font("微软雅黑", 11F);
            ucCalibration18.GainValue = 0D;
            ucCalibration18.Index = 14;
            ucCalibration18.Location = new Point(613, 583);
            ucCalibration18.Margin = new Padding(4, 5, 4, 5);
            ucCalibration18.Name = "ucCalibration18";
            ucCalibration18.Size = new Size(561, 37);
            ucCalibration18.TabIndex = 33;
            ucCalibration18.Text = "20B13(kPa)";
            ucCalibration18.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration13
            // 
            ucCalibration13.Font = new Font("微软雅黑", 11F);
            ucCalibration13.GainValue = 0D;
            ucCalibration13.Index = 26;
            ucCalibration13.Location = new Point(24, 395);
            ucCalibration13.Margin = new Padding(4, 5, 4, 5);
            ucCalibration13.Name = "ucCalibration13";
            ucCalibration13.Size = new Size(561, 37);
            ucCalibration13.TabIndex = 14;
            ucCalibration13.Text = "PE09(kPa)";
            ucCalibration13.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration19
            // 
            ucCalibration19.Font = new Font("微软雅黑", 11F);
            ucCalibration19.GainValue = 0D;
            ucCalibration19.Index = 13;
            ucCalibration19.Location = new Point(613, 536);
            ucCalibration19.Margin = new Padding(4, 5, 4, 5);
            ucCalibration19.Name = "ucCalibration19";
            ucCalibration19.Size = new Size(561, 37);
            ucCalibration19.TabIndex = 32;
            ucCalibration19.Tag = "";
            ucCalibration19.Text = "20B12(kPa)";
            ucCalibration19.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration12
            // 
            ucCalibration12.Font = new Font("微软雅黑", 11F);
            ucCalibration12.GainValue = 0D;
            ucCalibration12.Index = 27;
            ucCalibration12.Location = new Point(24, 442);
            ucCalibration12.Margin = new Padding(4, 5, 4, 5);
            ucCalibration12.Name = "ucCalibration12";
            ucCalibration12.Size = new Size(561, 37);
            ucCalibration12.TabIndex = 15;
            ucCalibration12.Text = "PE10(kPa)";
            ucCalibration12.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration20
            // 
            ucCalibration20.Font = new Font("微软雅黑", 11F);
            ucCalibration20.GainValue = 0D;
            ucCalibration20.Index = 12;
            ucCalibration20.Location = new Point(613, 489);
            ucCalibration20.Margin = new Padding(4, 5, 4, 5);
            ucCalibration20.Name = "ucCalibration20";
            ucCalibration20.Size = new Size(561, 37);
            ucCalibration20.TabIndex = 31;
            ucCalibration20.Text = "20B11(kPa)";
            ucCalibration20.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration11
            // 
            ucCalibration11.Font = new Font("微软雅黑", 11F);
            ucCalibration11.GainValue = 0D;
            ucCalibration11.Index = 28;
            ucCalibration11.Location = new Point(24, 489);
            ucCalibration11.Margin = new Padding(4, 5, 4, 5);
            ucCalibration11.Name = "ucCalibration11";
            ucCalibration11.Size = new Size(561, 37);
            ucCalibration11.TabIndex = 16;
            ucCalibration11.Text = "PE11(kPa)";
            ucCalibration11.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration21
            // 
            ucCalibration21.Font = new Font("微软雅黑", 11F);
            ucCalibration21.GainValue = 0D;
            ucCalibration21.Index = 11;
            ucCalibration21.Location = new Point(613, 442);
            ucCalibration21.Margin = new Padding(4, 5, 4, 5);
            ucCalibration21.Name = "ucCalibration21";
            ucCalibration21.Size = new Size(561, 37);
            ucCalibration21.TabIndex = 30;
            ucCalibration21.Text = "20B10(kPa)";
            ucCalibration21.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration10
            // 
            ucCalibration10.Font = new Font("微软雅黑", 11F);
            ucCalibration10.GainValue = 0D;
            ucCalibration10.Index = 29;
            ucCalibration10.Location = new Point(24, 536);
            ucCalibration10.Margin = new Padding(4, 5, 4, 5);
            ucCalibration10.Name = "ucCalibration10";
            ucCalibration10.Size = new Size(561, 37);
            ucCalibration10.TabIndex = 17;
            ucCalibration10.Tag = "";
            ucCalibration10.Text = "PE12(kPa)";
            ucCalibration10.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration22
            // 
            ucCalibration22.Font = new Font("微软雅黑", 11F);
            ucCalibration22.GainValue = 0D;
            ucCalibration22.Index = 10;
            ucCalibration22.Location = new Point(613, 395);
            ucCalibration22.Margin = new Padding(4, 5, 4, 5);
            ucCalibration22.Name = "ucCalibration22";
            ucCalibration22.Size = new Size(561, 37);
            ucCalibration22.TabIndex = 29;
            ucCalibration22.Text = "20B09(kPa)";
            ucCalibration22.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration9
            // 
            ucCalibration9.Font = new Font("微软雅黑", 11F);
            ucCalibration9.GainValue = 0D;
            ucCalibration9.Index = 30;
            ucCalibration9.Location = new Point(24, 583);
            ucCalibration9.Margin = new Padding(4, 5, 4, 5);
            ucCalibration9.Name = "ucCalibration9";
            ucCalibration9.Size = new Size(561, 37);
            ucCalibration9.TabIndex = 18;
            ucCalibration9.Text = "PE13(kPa)";
            ucCalibration9.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration23
            // 
            ucCalibration23.Font = new Font("微软雅黑", 11F);
            ucCalibration23.GainValue = 0D;
            ucCalibration23.Index = 9;
            ucCalibration23.Location = new Point(613, 348);
            ucCalibration23.Margin = new Padding(4, 5, 4, 5);
            ucCalibration23.Name = "ucCalibration23";
            ucCalibration23.Size = new Size(561, 37);
            ucCalibration23.TabIndex = 28;
            ucCalibration23.Tag = "";
            ucCalibration23.Text = "20B08(kPa)";
            ucCalibration23.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration1
            // 
            ucCalibration1.Font = new Font("微软雅黑", 11F);
            ucCalibration1.GainValue = 0D;
            ucCalibration1.Index = 31;
            ucCalibration1.Location = new Point(24, 630);
            ucCalibration1.Margin = new Padding(4, 5, 4, 5);
            ucCalibration1.Name = "ucCalibration1";
            ucCalibration1.Size = new Size(561, 37);
            ucCalibration1.TabIndex = 19;
            ucCalibration1.Text = "PE14(kPa)";
            ucCalibration1.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration24
            // 
            ucCalibration24.Font = new Font("微软雅黑", 11F);
            ucCalibration24.GainValue = 0D;
            ucCalibration24.Index = 8;
            ucCalibration24.Location = new Point(613, 301);
            ucCalibration24.Margin = new Padding(4, 5, 4, 5);
            ucCalibration24.Name = "ucCalibration24";
            ucCalibration24.Size = new Size(561, 37);
            ucCalibration24.TabIndex = 27;
            ucCalibration24.Text = "20B07(kPa)";
            ucCalibration24.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration15
            // 
            ucCalibration15.Font = new Font("微软雅黑", 11F);
            ucCalibration15.GainValue = 0D;
            ucCalibration15.Index = 32;
            ucCalibration15.Location = new Point(24, 677);
            ucCalibration15.Margin = new Padding(4, 5, 4, 5);
            ucCalibration15.Name = "ucCalibration15";
            ucCalibration15.Size = new Size(561, 37);
            ucCalibration15.TabIndex = 20;
            ucCalibration15.Text = "PE15(kPa)";
            ucCalibration15.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration25
            // 
            ucCalibration25.Font = new Font("微软雅黑", 11F);
            ucCalibration25.GainValue = 0D;
            ucCalibration25.Index = 7;
            ucCalibration25.Location = new Point(613, 254);
            ucCalibration25.Margin = new Padding(4, 5, 4, 5);
            ucCalibration25.Name = "ucCalibration25";
            ucCalibration25.Size = new Size(561, 37);
            ucCalibration25.TabIndex = 26;
            ucCalibration25.Text = "20B06(kPa)";
            ucCalibration25.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration30
            // 
            ucCalibration30.Font = new Font("微软雅黑", 11F);
            ucCalibration30.GainValue = 0D;
            ucCalibration30.Index = 2;
            ucCalibration30.Location = new Point(613, 19);
            ucCalibration30.Margin = new Padding(4, 5, 4, 5);
            ucCalibration30.Name = "ucCalibration30";
            ucCalibration30.Size = new Size(561, 37);
            ucCalibration30.TabIndex = 21;
            ucCalibration30.Tag = "";
            ucCalibration30.Text = "20B01(kPa)";
            ucCalibration30.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration26
            // 
            ucCalibration26.Font = new Font("微软雅黑", 11F);
            ucCalibration26.GainValue = 0D;
            ucCalibration26.Index = 6;
            ucCalibration26.Location = new Point(613, 207);
            ucCalibration26.Margin = new Padding(4, 5, 4, 5);
            ucCalibration26.Name = "ucCalibration26";
            ucCalibration26.Size = new Size(561, 37);
            ucCalibration26.TabIndex = 25;
            ucCalibration26.Tag = "";
            ucCalibration26.Text = "20B05(kPa)";
            ucCalibration26.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration29
            // 
            ucCalibration29.Font = new Font("微软雅黑", 11F);
            ucCalibration29.GainValue = 0D;
            ucCalibration29.Index = 3;
            ucCalibration29.Location = new Point(613, 66);
            ucCalibration29.Margin = new Padding(4, 5, 4, 5);
            ucCalibration29.Name = "ucCalibration29";
            ucCalibration29.Size = new Size(561, 37);
            ucCalibration29.TabIndex = 22;
            ucCalibration29.Text = "20B02(kPa)";
            ucCalibration29.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration27
            // 
            ucCalibration27.Font = new Font("微软雅黑", 11F);
            ucCalibration27.GainValue = 0D;
            ucCalibration27.Index = 5;
            ucCalibration27.Location = new Point(613, 160);
            ucCalibration27.Margin = new Padding(4, 5, 4, 5);
            ucCalibration27.Name = "ucCalibration27";
            ucCalibration27.Size = new Size(561, 37);
            ucCalibration27.TabIndex = 24;
            ucCalibration27.Text = "20B04(kPa)";
            ucCalibration27.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration28
            // 
            ucCalibration28.Font = new Font("微软雅黑", 11F);
            ucCalibration28.GainValue = 0D;
            ucCalibration28.Index = 4;
            ucCalibration28.Location = new Point(613, 113);
            ucCalibration28.Margin = new Padding(4, 5, 4, 5);
            ucCalibration28.Name = "ucCalibration28";
            ucCalibration28.Size = new Size(561, 37);
            ucCalibration28.TabIndex = 23;
            ucCalibration28.Text = "20B03(kPa)";
            ucCalibration28.Submited += ucCalibration_AI_Submited;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Font = new Font("微软雅黑", 15F);
            panel2.Location = new Point(771, 2);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 38);
            panel2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(192, 5);
            label4.Name = "label4";
            label4.Size = new Size(72, 27);
            label4.TabIndex = 7;
            label4.Text = "增益值";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(12, 5);
            label5.Name = "label5";
            label5.Size = new Size(72, 27);
            label5.TabIndex = 7;
            label5.Text = "测定值";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(106, 5);
            label6.Name = "label6";
            label6.Size = new Size(72, 27);
            label6.TabIndex = 7;
            label6.Text = "零点值";
            // 
            // grpAO
            // 
            grpAO.Controls.Add(ucCalibration38);
            grpAO.Controls.Add(ucCalibration32);
            grpAO.Font = new Font("宋体", 12F);
            grpAO.Location = new Point(1230, 41);
            grpAO.Margin = new Padding(4, 5, 4, 5);
            grpAO.MinimumSize = new Size(1, 1);
            grpAO.Name = "grpAO";
            grpAO.Padding = new Padding(0, 32, 0, 0);
            grpAO.Size = new Size(605, 896);
            grpAO.TabIndex = 383;
            grpAO.Text = "输出控制";
            grpAO.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ucCalibration38
            // 
            ucCalibration38.Font = new Font("微软雅黑", 11F);
            ucCalibration38.GainValue = 0D;
            ucCalibration38.Index = 1;
            ucCalibration38.Location = new Point(23, 84);
            ucCalibration38.Margin = new Padding(4, 5, 4, 5);
            ucCalibration38.Name = "ucCalibration38";
            ucCalibration38.Size = new Size(561, 37);
            ucCalibration38.TabIndex = 44;
            ucCalibration38.Tag = "";
            ucCalibration38.Text = "可调电源电流mA)";
            ucCalibration38.Submited += ucCalibration_AO_Submited;
            // 
            // ucCalibration32
            // 
            ucCalibration32.Font = new Font("微软雅黑", 11F);
            ucCalibration32.GainValue = 0D;
            ucCalibration32.Location = new Point(23, 37);
            ucCalibration32.Margin = new Padding(4, 5, 4, 5);
            ucCalibration32.Name = "ucCalibration32";
            ucCalibration32.Size = new Size(561, 37);
            ucCalibration32.TabIndex = 43;
            ucCalibration32.Tag = "";
            ucCalibration32.Text = "可调电源电压";
            ucCalibration32.Submited += ucCalibration_AO_Submited;
            // 
            // frmHardWare
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(1849, 985);
            Controls.Add(grpAO);
            Controls.Add(panel2);
            Controls.Add(grpAI);
            Controls.Add(label12);
            Controls.Add(panel1);
            Font = new Font("微软雅黑", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHardWare";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "硬件校准";
            Load += frmHardWare_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAI.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private UCCalibration ucCalibration39;
        private UCCalibration ucCalibration40;
        private UCCalibration ucCalibration41;
        private UCCalibration ucCalibration42;
        private UCCalibration ucCalibration43;
        private UCCalibration ucCalibration44;
        private UCCalibration ucCalibration45;
        private UCCalibration ucCalibration46;
        private UCCalibration ucCalibration47;
        private UCCalibration ucCalibration48;
        private UCCalibration ucCalibration49;
        private UCCalibration ucCalibration50;
        private UCCalibration ucCalibration51;
        private UCCalibration ucCalibration52;
        private UCCalibration ucCalibration53;
        private UCCalibration ucCalibration54;
    }
}