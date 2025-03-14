
namespace BoxDBC
{
    partial class ToEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToEditForm));
            this.TextBox1 = new DSkin.Controls.DSkinTextBox();
            this.BtnOk = new DSkin.Controls.DSkinButton();
            this.BtnCancel = new DSkin.Controls.DSkinButton();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.BitmapCache = false;
            this.TextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.Location = new System.Drawing.Point(70, 30);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(360, 30);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "1";
            this.TextBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.TextBox1.WaterFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.WaterText = "";
            this.TextBox1.WaterTextOffset = new System.Drawing.Point(0, 0);
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
            this.BtnOk.Location = new System.Drawing.Point(130, 65);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.NormalImage = null;
            this.BtnOk.PressColor = System.Drawing.Color.Empty;
            this.BtnOk.PressedImage = null;
            this.BtnOk.Radius = 10;
            this.BtnOk.ShowButtonBorder = true;
            this.BtnOk.Size = new System.Drawing.Size(100, 30);
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
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.EffectColor = System.Drawing.Color.Transparent;
            this.BtnCancel.EffectValue = 0;
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.HoverColor = System.Drawing.Color.Gray;
            this.BtnCancel.HoverImage = null;
            this.BtnCancel.Location = new System.Drawing.Point(270, 65);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.NormalImage = null;
            this.BtnCancel.PressColor = System.Drawing.Color.Empty;
            this.BtnCancel.PressedImage = null;
            this.BtnCancel.Radius = 10;
            this.BtnCancel.ShowButtonBorder = true;
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.TextPadding = 0;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ToEditForm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderColor = System.Drawing.Color.Teal;
            this.BorderWidth = 2;
            this.CancelButton = this.BtnCancel;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TextBox1);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.EnableAnimation = false;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToEditForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowShadow = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入指定编号后按 [回车键]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToEditForm_FormClosing);
            this.Load += new System.EventHandler(this.ToEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinTextBox TextBox1;
        private DSkin.Controls.DSkinButton BtnOk;
        private DSkin.Controls.DSkinButton BtnCancel;
    }
}