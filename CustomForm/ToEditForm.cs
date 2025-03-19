using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxDBC
{
    public partial class ToEditForm : DSkinForm
    {
        public string ToNumId { get; private set; } = string.Empty;
        public ToEditForm()
        {
            InitializeComponent();
        }

        private void ToEditForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ToNumId = TextBox1.Text.Trim();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public string DoShowDialog(Control Owner)
        {
            ShowDialog(Owner);
            return ToNumId;
        }
    }
}
