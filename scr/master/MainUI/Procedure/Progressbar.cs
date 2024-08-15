using MainUI.Procedure.Curve;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainUI.Procedure
{
    public partial class Progressbar : UIForm
    {
        public Progressbar(frmDataPlayback frmDataPlayback)
        {
            InitializeComponent();
            frmDataPlayback.BarHandler += FrmDataPlayback_BarHandler;
        }

        private void FrmDataPlayback_BarHandler(int i)
        {
            uiProcessBar1.Value = i;
            Debug.Write(" 进度条：" + i);
        }


        public bool Increase(int nValue)
        {
            if (nValue > 0)
            {
                if (uiProcessBar1.Value + nValue < uiProcessBar1.Maximum)
                {
                    uiProcessBar1.Value += nValue;
                    return true;
                }
                else
                {
                    uiProcessBar1.Value = uiProcessBar1.Maximum;
                    Close();
                    return false;
                }
            }
            return false;
        }

        


    }
}
