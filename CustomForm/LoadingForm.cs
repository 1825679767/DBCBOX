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
    public partial class LoadingForm : DSkinForm
    {
        public LoadingForm()
        {
            InitializeComponent();
            ProgressIndicator1.Visible = false;
        }

        public void ShowProgressIndicator(bool Show)
        {
            ProgressIndicator1.Visible = Show;
        }

        private void LoadingForm_SizeChanged(object sender, EventArgs e)
        {
            ProgressIndicator1.Location = new Point((Width - ProgressIndicator1.Width) / 2, (Height - ProgressIndicator1.Height) / 2);
        }
    }
}
