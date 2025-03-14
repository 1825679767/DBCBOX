using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;

namespace BoxDBC
{
    public class StaticMessageBox
    {
        public static double Zoon = 0.8;

        /// <summary>
        /// 显示弹出对话框
        /// </summary>
        public static DialogResult Show(string Title, string Info, MessageBoxButtons Btns = MessageBoxButtons.OK)
        {
            string OK = "确定";
            string Cancel = "取消";
            switch (Btns)
            {
                case MessageBoxButtons.OK:
                    OK = "确定";
                    break;
                case MessageBoxButtons.OKCancel:
                    OK = "确定";
                    Cancel = "取消";
                    break;
            }
            return Show(Title, Info, Btns, OK, Cancel);
        }

        /// <summary>
        /// 显示弹出对话框
        /// </summary>
        public static DialogResult Show(string Title, string Info, MessageBoxButtons Btns, string OKText, string CancelText)
        {
            return new DoMessageBox(Title, Info, Btns, OKText, CancelText).ShowDialog(GHelper.AtTopMainForm);
        }
    }
}
