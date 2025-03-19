
namespace BoxDBC
{
    partial class DoMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoMessageBox));
            this.LblMsg = new DSkin.Controls.DSkinLabel();
            this.LblTitle = new DSkin.Controls.DSkinLabel();
            this.PnlBottom = new DSkin.Controls.DSkinPanel();
            this.BtnOk = new DSkin.Controls.DSkinButton();
            this.BtnCancel = new DSkin.Controls.DSkinButton();
            this.PnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = false;
            this.LblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMsg.EffectColor = System.Drawing.Color.Transparent;
            this.LblMsg.EffectValue = 0;
            this.LblMsg.Enabled = false;
            this.LblMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblMsg.Location = new System.Drawing.Point(19, 59);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(442, 162);
            this.LblMsg.TabIndex = 33;
            this.LblMsg.TabStop = false;
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = false;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.EffectColor = System.Drawing.Color.Transparent;
            this.LblTitle.EffectValue = 0;
            this.LblTitle.Enabled = false;
            this.LblTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.ForeColor = System.Drawing.Color.Black;
            this.LblTitle.Location = new System.Drawing.Point(19, 19);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(442, 40);
            this.LblTitle.TabIndex = 34;
            this.LblTitle.TabStop = false;
            this.LblTitle.Text = "类型";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.PnlBottom.Controls.Add(this.BtnOk);
            this.PnlBottom.Controls.Add(this.BtnCancel);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PnlBottom.Location = new System.Drawing.Point(19, 221);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.RightBottom = ((System.Drawing.Image)(resources.GetObject("PnlBottom.RightBottom")));
            this.PnlBottom.Size = new System.Drawing.Size(442, 60);
            this.PnlBottom.TabIndex = 35;
            // 
            // BtnOk
            // 
            this.BtnOk.AdaptImage = true;
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOk.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnOk.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnOk.ButtonBorderWidth = 1;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnOk.EffectColor = System.Drawing.Color.Transparent;
            this.BtnOk.EffectValue = 0;
            this.BtnOk.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.HoverColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnOk.HoverImage = null;
            this.BtnOk.Location = new System.Drawing.Point(20, 10);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.NormalImage = null;
            this.BtnOk.PressColor = System.Drawing.Color.Empty;
            this.BtnOk.PressedImage = null;
            this.BtnOk.Radius = 10;
            this.BtnOk.ShowButtonBorder = true;
            this.BtnOk.Size = new System.Drawing.Size(100, 40);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "确定";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOk.TextPadding = 0;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AdaptImage = true;
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancel.BaseColor = System.Drawing.Color.Silver;
            this.BtnCancel.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnCancel.ButtonBorderWidth = 1;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancel.EffectColor = System.Drawing.Color.Transparent;
            this.BtnCancel.EffectValue = 0;
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.HoverColor = System.Drawing.Color.Gray;
            this.BtnCancel.HoverImage = null;
            this.BtnCancel.Location = new System.Drawing.Point(320, 10);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.NormalImage = null;
            this.BtnCancel.PressColor = System.Drawing.Color.Empty;
            this.BtnCancel.PressedImage = null;
            this.BtnCancel.Radius = 10;
            this.BtnCancel.ShowButtonBorder = true;
            this.BtnCancel.Size = new System.Drawing.Size(100, 40);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.TextPadding = 0;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DoMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderColor = System.Drawing.Color.Teal;
            this.BorderWidth = 2;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 4;
            this.CaptionOffset = new System.Drawing.Point(0, 50);
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnlBottom);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.EnableAnimation = false;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconRectangle = new System.Drawing.Rectangle(5, -55, 16, 16);
            this.MoveMode = DSkin.Forms.MoveModes.None;
            this.Name = "DoMessageBox";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Radius = 8;
            this.ShowInTaskbar = false;
            this.ShowShadow = true;
            this.ShowSystemButtons = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.SudokuPartitionWidth = new System.Windows.Forms.Padding(35);
            this.Text = "";
            this.PnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinLabel LblMsg;
        private DSkin.Controls.DSkinLabel LblTitle;
        private DSkin.Controls.DSkinPanel PnlBottom;
        private DSkin.Controls.DSkinButton BtnOk;
        private DSkin.Controls.DSkinButton BtnCancel;
    }
}