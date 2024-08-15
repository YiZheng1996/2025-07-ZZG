using RW.Configuration;
using System.Windows.Forms;

namespace MainUI.Config
{
    public class LayoutConfig : IniConfig
    {
        public LayoutConfig()
          : base(Application.StartupPath + "config\\layout.ini")
        {
            Load();
        }

        protected override void PreInit()
        {
            this.RightToLeft = true;
            this.BitHold = true;
            this.NumHold = true;
            this.Cut = true;
            this.BitCount = 16;
            this.LineSpace = 5;
            this.ItemColor = "LightBlue";

            base.PreInit();
        }

        [IniKeyName("从右至左")]
        public bool RightToLeft { get; set; }

        [IniKeyName("位占位符")]
        public bool BitHold { get; set; }

        [IniKeyName("偏移量占位符")]
        public bool NumHold { get; set; }

        [IniKeyName("是否截断")]
        public bool Cut { get; set; }

        [IniKeyName("行字节数")]
        public int BitCount { get; set; }//此处只能是8，16

        [IniKeyName("行间距")]
        public int LineSpace { get; set; }

        [IniKeyName("单元格颜色")]
        public string ItemColor { get; set; }
    }
}
