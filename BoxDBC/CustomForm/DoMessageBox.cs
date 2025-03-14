using DSkin.Controls;
using DSkin.DirectUI;
using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxDBC
{
    public partial class DoMessageBox : DSkinForm
    {
        private bool _IsShowDialog = true;
        /// <summary>
        /// 是否是Dialog对话框窗体
        /// </summary>
        [Description("是否是Dialog对话框窗体")]
        public bool IsShowDialog
        {
            get { return _IsShowDialog; }
            set { _IsShowDialog = value; }
        }

        public MessageBoxButtons Buttons;

        public DoMessageBox(string Title, string Info, MessageBoxButtons Btns, string OKText, string CancelText)
        {
            InitializeComponent();

            //Animation.Effect = new EmphasisOnZoomEffect(StaticMessageBox.Zoon);
            Buttons = Btns;
            LblTitle.Text = Title;
            LblMsg.Text = Info;
            if (Btns == MessageBoxButtons.OK)
            {
                BtnCancel.Visible = false;
                BtnOk.Location = new Point(PnlBottom.Width / 2 - BtnOk.Width / 2, PnlBottom.Height / 2 - BtnOk.Height / 2);
            }

            System.Media.SystemSounds.Exclamation.Play();

            BtnOk.Text = OKText;
            BtnCancel.Text = CancelText;

            MainForm MForm = GHelper.AtTopMainForm;
            if (MForm != null)
            {
                MForm.AutoAllowDrop(true);
                StartPosition = FormStartPosition.Manual;
                Location = new Point(MForm.Location.X + (MForm.Width - Width) / 2, MForm.Location.Y + (MForm.Height - Height) / 2);
            }
            else
            {
                StartPosition = FormStartPosition.CenterScreen;
            }

            WinApis.SetForegroundWindow(Handle);
        }

        public void CloseForm(DialogResult Result = DialogResult.Cancel)
        {
            if (IsShowDialog)
            {
                DialogResult = Result;
            }
            else
            {
                Close();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            switch (Buttons)
            {
                case MessageBoxButtons.OK:
                    CloseForm(DialogResult.OK);
                    break;
                case MessageBoxButtons.OKCancel:
                    CloseForm(DialogResult.OK);
                    break;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (Buttons == MessageBoxButtons.OKCancel)
                CloseForm(DialogResult.Cancel);
        }
    }
}
