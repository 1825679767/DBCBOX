using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BoxDBC
{
    public class TabItemTemplate : DSkin.Controls.DSkinTabItem
    {
        private DSkin.DirectUI.DuiIcon IconClose;

        public TabItemTemplate()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.IconClose = new DSkin.DirectUI.DuiIcon();
            // 
            // IconClose
            // 
            this.IconClose.DesignModeCanResize = false;
            this.IconClose.ForeColor = System.Drawing.Color.Red;
            this.IconClose.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.IconClose.Icon = DSkin.Common.FontAwesomeChars.icon_close;
            this.IconClose.IconSize = 15F;
            this.IconClose.Location = new System.Drawing.Point(180, 8);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(16, 16);
            this.IconClose.MouseEnter += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.IconClose_MouseEnter);
            this.IconClose.MouseLeave += new System.EventHandler(this.IconClose_MouseLeave);
            this.IconClose.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.IconClose_MouseClick);
            // 
            // TabItemTemplate
            // 
            this.AutoEllipsis = true;
            this.Borders.AllColor = System.Drawing.Color.Black;
            this.Borders.BottomColor = System.Drawing.Color.Black;
            this.Borders.LeftColor = System.Drawing.Color.Black;
            this.Borders.RightColor = System.Drawing.Color.Black;
            this.Borders.TopColor = System.Drawing.Color.Black;
            this.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.IconClose);
            this.EffectColor = System.Drawing.Color.SkyBlue;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HoverColor = System.Drawing.Color.Transparent;
            this.PressColor = System.Drawing.Color.Transparent;
            this.RoundStyle = DSkin.Common.RoundStyle.None;
            this.Size = new System.Drawing.Size(200, 30);
            this.Text = "AAAAAAAAAAAA";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextInnerPadding = new System.Windows.Forms.Padding(8, 4, 15, 4);
            this.MouseDown += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.TabItemTemplate_MouseDown);
            this.MouseUp += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.TabItemTemplate_MouseUp);
            this.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.TabItemTemplate_MouseClick);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Graphics Gr = Graphics.FromHwnd(IntPtr.Zero))
            {
                Width = (int)Gr.MeasureString(Text, Font).Width + 30;
                IconClose.Location = new Point(Width - 20, 8);
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (Loaded)
            {
                using (Graphics Gr = Graphics.FromHwnd(IntPtr.Zero))
                {
                    Width = (int)Gr.MeasureString(Text, Font).Width + 30;
                    IconClose.Location = new Point(Width - 20, 8);
                }
            }
        }

        private void IconClose_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            SendTask("移除选项卡");
        }

        private void IconClose_MouseEnter(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            IconClose.BackColor = Color.Black;
        }

        private void IconClose_MouseLeave(object sender, EventArgs e)
        {
            IconClose.BackColor = Color.Transparent;
        }

        private void TabItemTemplate_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            SendTask("点击选项卡");
        }

        private void TabItemTemplate_MouseDown(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void TabItemTemplate_MouseUp(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            BackColor = Color.SkyBlue;
        }
    }
}
