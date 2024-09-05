using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace MainUI.CurrencyHelper
{
    public class MessageHelper
    {
        /// <summary>
        ///  OK  提示窗体
        /// </summary>
        /// <param name="text"></param>
        public static void UIMessageOK(string text)
        {
            UIMessageBox.Show(text);
        }

        public static void UIMessageOK(string text, UIStyle uIStyle)
        {
            UIMessageBox.Show(text, UILocalize.InfoTitle, uIStyle);
        }

        /// <summary>
        /// 确认、取消
        /// </summary>
        /// <param name="form"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool UIMessageYes(Form form, string text)
        {
            return form.ShowAskDialog(text);
        }
    }
}
