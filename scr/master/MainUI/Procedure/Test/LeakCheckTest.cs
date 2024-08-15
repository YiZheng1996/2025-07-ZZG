using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure.Test
{
    /// <summary>
    /// 满负荷试验
    /// </summary>
    public class LeakCheckTest : BaseTest
    {
        public override bool Execute()
        {
            try
            {
                TestStatus(true);
                TxtTips("满负荷试验开始");
                TestStatus(false);
                TxtTips("满负荷试验结束");
                return true;
            }
            catch (Exception ex)
            {
                TxtTips("满负荷试验失败，原因：" + ex.Message);
                return false;
            }
        }
    
    }
}
