
namespace BoxDBC
{
    partial class AsFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsFindForm));
            this.Label1 = new DSkin.Controls.DSkinLabel();
            this.TextBox1 = new DSkin.Controls.DSkinTextBox();
            this.Label2 = new DSkin.Controls.DSkinLabel();
            this.TextBox2 = new DSkin.Controls.DSkinTextBox();
            this.BtnNext = new DSkin.Controls.DSkinButton();
            this.BtnCancel = new DSkin.Controls.DSkinButton();
            this.BtnThs = new DSkin.Controls.DSkinButton();
            this.BtnAs = new DSkin.Controls.DSkinButton();
            this.CheckBox1 = new DSkin.Controls.DSkinCheckBox();
            this.CheckBox2 = new DSkin.Controls.DSkinCheckBox();
            this.TsLab1 = new DSkin.Controls.DSkinLabel();
            this.TsLab2 = new DSkin.Controls.DSkinLabel();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = false;
            this.Label1.Location = new System.Drawing.Point(10, 50);
            this.Label1.Margin = new System.Windows.Forms.Padding(0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 30);
            this.Label1.TabIndex = 0;
            this.Label1.TabStop = false;
            this.Label1.Text = "查找目标:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox1
            // 
            this.TextBox1.BitmapCache = false;
            this.TextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.Location = new System.Drawing.Point(110, 52);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox1.MaxLength = 2147483647;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(320, 26);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.TextBox1.WaterFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.WaterText = "";
            this.TextBox1.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = false;
            this.Label2.Location = new System.Drawing.Point(10, 100);
            this.Label2.Margin = new System.Windows.Forms.Padding(0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 30);
            this.Label2.TabIndex = 0;
            this.Label2.TabStop = false;
            this.Label2.Text = "替换内容:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox2
            // 
            this.TextBox2.BitmapCache = false;
            this.TextBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox2.Location = new System.Drawing.Point(110, 102);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox2.MaxLength = 2147483647;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(320, 26);
            this.TextBox2.TabIndex = 1;
            this.TextBox2.TransparencyKey = System.Drawing.Color.Empty;
            this.TextBox2.WaterFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox2.WaterText = "";
            this.TextBox2.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // BtnNext
            // 
            this.BtnNext.AdaptImage = true;
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNext.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnNext.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnNext.ButtonBorderWidth = 1;
            this.BtnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNext.DrawDisabled = true;
            this.BtnNext.EffectColor = System.Drawing.Color.Transparent;
            this.BtnNext.EffectValue = 0;
            this.BtnNext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNext.HoverImage = null;
            this.BtnNext.Location = new System.Drawing.Point(460, 40);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.NormalImage = null;
            this.BtnNext.PressColor = System.Drawing.Color.Empty;
            this.BtnNext.PressedImage = null;
            this.BtnNext.Radius = 10;
            this.BtnNext.ShowButtonBorder = true;
            this.BtnNext.Size = new System.Drawing.Size(120, 30);
            this.BtnNext.TabIndex = 0;
            this.BtnNext.TabStop = false;
            this.BtnNext.Text = "查找下一个";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNext.TextPadding = 0;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AdaptImage = true;
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnCancel.ButtonBorderWidth = 1;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.EffectColor = System.Drawing.Color.Transparent;
            this.BtnCancel.EffectValue = 0;
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.HoverColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancel.HoverImage = null;
            this.BtnCancel.Location = new System.Drawing.Point(460, 160);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.NormalImage = null;
            this.BtnCancel.PressColor = System.Drawing.Color.Empty;
            this.BtnCancel.PressedImage = null;
            this.BtnCancel.Radius = 10;
            this.BtnCancel.ShowButtonBorder = true;
            this.BtnCancel.Size = new System.Drawing.Size(120, 30);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.TextPadding = 0;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnThs
            // 
            this.BtnThs.AdaptImage = true;
            this.BtnThs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnThs.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnThs.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnThs.ButtonBorderWidth = 1;
            this.BtnThs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnThs.EffectColor = System.Drawing.Color.Transparent;
            this.BtnThs.EffectValue = 0;
            this.BtnThs.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnThs.ForeColor = System.Drawing.Color.White;
            this.BtnThs.HoverColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnThs.HoverImage = null;
            this.BtnThs.Location = new System.Drawing.Point(460, 80);
            this.BtnThs.Margin = new System.Windows.Forms.Padding(0);
            this.BtnThs.Name = "BtnThs";
            this.BtnThs.NormalImage = null;
            this.BtnThs.PressColor = System.Drawing.Color.Empty;
            this.BtnThs.PressedImage = null;
            this.BtnThs.Radius = 10;
            this.BtnThs.ShowButtonBorder = true;
            this.BtnThs.Size = new System.Drawing.Size(120, 30);
            this.BtnThs.TabIndex = 0;
            this.BtnThs.TabStop = false;
            this.BtnThs.Text = "替换当前";
            this.BtnThs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnThs.TextPadding = 0;
            this.BtnThs.Click += new System.EventHandler(this.BtnThs_Click);
            // 
            // BtnAs
            // 
            this.BtnAs.AdaptImage = true;
            this.BtnAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAs.BaseColor = System.Drawing.Color.DodgerBlue;
            this.BtnAs.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.BtnAs.ButtonBorderWidth = 1;
            this.BtnAs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAs.EffectColor = System.Drawing.Color.Transparent;
            this.BtnAs.EffectValue = 0;
            this.BtnAs.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAs.ForeColor = System.Drawing.Color.White;
            this.BtnAs.HoverColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAs.HoverImage = null;
            this.BtnAs.Location = new System.Drawing.Point(460, 120);
            this.BtnAs.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAs.Name = "BtnAs";
            this.BtnAs.NormalImage = null;
            this.BtnAs.PressColor = System.Drawing.Color.Empty;
            this.BtnAs.PressedImage = null;
            this.BtnAs.Radius = 10;
            this.BtnAs.ShowButtonBorder = true;
            this.BtnAs.Size = new System.Drawing.Size(120, 30);
            this.BtnAs.TabIndex = 0;
            this.BtnAs.TabStop = false;
            this.BtnAs.Text = "全部替换";
            this.BtnAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAs.TextPadding = 0;
            this.BtnAs.Click += new System.EventHandler(this.BtnAs_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBox1.Checked = false;
            this.CheckBox1.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.CheckBox1.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox1.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.CheckBox1.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.CheckBox1.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.CheckBox1.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.CheckBox1.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.CheckBox1.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox1.CheckRectWidth = 14;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.CheckBox1.InnerPaddingWidth = 2;
            this.CheckBox1.InnerRectInflate = 3;
            this.CheckBox1.Location = new System.Drawing.Point(110, 150);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(84, 24);
            this.CheckBox1.SpaceBetweenCheckMarkAndText = 3;
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.TabStop = false;
            this.CheckBox1.Text = "全词匹配";
            this.CheckBox1.TextColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckBox2.Checked = false;
            this.CheckBox2.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.CheckBox2.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox2.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.CheckBox2.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.CheckBox2.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.CheckBox2.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.CheckBox2.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.CheckBox2.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox2.CheckRectWidth = 14;
            this.CheckBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.CheckBox2.InnerPaddingWidth = 2;
            this.CheckBox2.InnerRectInflate = 3;
            this.CheckBox2.Location = new System.Drawing.Point(210, 150);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(98, 24);
            this.CheckBox2.SpaceBetweenCheckMarkAndText = 3;
            this.CheckBox2.TabIndex = 0;
            this.CheckBox2.TabStop = false;
            this.CheckBox2.Text = "匹配大小写";
            this.CheckBox2.TextColorDisabled = System.Drawing.Color.Gray;
            this.CheckBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // TsLab1
            // 
            this.TsLab1.AutoSize = false;
            this.TsLab1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsLab1.ForeColor = System.Drawing.Color.Red;
            this.TsLab1.Location = new System.Drawing.Point(8, 206);
            this.TsLab1.Margin = new System.Windows.Forms.Padding(0);
            this.TsLab1.Name = "TsLab1";
            this.TsLab1.Size = new System.Drawing.Size(320, 30);
            this.TsLab1.TabIndex = 0;
            this.TsLab1.TabStop = false;
            this.TsLab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsLab2
            // 
            this.TsLab2.AutoSize = false;
            this.TsLab2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsLab2.ForeColor = System.Drawing.Color.Green;
            this.TsLab2.Location = new System.Drawing.Point(340, 206);
            this.TsLab2.Margin = new System.Windows.Forms.Padding(0);
            this.TsLab2.Name = "TsLab2";
            this.TsLab2.Size = new System.Drawing.Size(250, 30);
            this.TsLab2.TabIndex = 0;
            this.TsLab2.TabStop = false;
            this.TsLab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AsFindForm
            // 
            this.AnimationType = DSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderColor = System.Drawing.Color.Teal;
            this.BorderWidth = 2;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(600, 240);
            this.Controls.Add(this.TsLab2);
            this.Controls.Add(this.TsLab1);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.BtnAs);
            this.Controls.Add(this.BtnThs);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.EnableAnimation = false;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsFindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "搜索查找替换";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsFindForm_FormClosing);
            this.Load += new System.EventHandler(this.AsFindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinLabel Label1;
        private DSkin.Controls.DSkinTextBox TextBox1;
        private DSkin.Controls.DSkinLabel Label2;
        private DSkin.Controls.DSkinTextBox TextBox2;
        private DSkin.Controls.DSkinButton BtnCancel;
        private DSkin.Controls.DSkinButton BtnThs;
        private DSkin.Controls.DSkinButton BtnAs;
        private DSkin.Controls.DSkinCheckBox CheckBox1;
        private DSkin.Controls.DSkinCheckBox CheckBox2;
        private DSkin.Controls.DSkinButton BtnNext;
        private DSkin.Controls.DSkinLabel TsLab1;
        private DSkin.Controls.DSkinLabel TsLab2;
    }
}