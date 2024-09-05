using MainUI.CurrencyHelper;
using RW.Modules;
using System.ComponentModel;

namespace MainUI.Modules
{
    public partial class ServoGrp : BaseModule
    {
        public ServoGrp()
        {
            InitializeComponent();
        }

        public ServoGrp(IContainer container)
        {
            Driver = VarHelper.opcServoGroup;
            InitializeComponent();
        }
    }
}
