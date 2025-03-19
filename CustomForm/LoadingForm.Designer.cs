
namespace BoxDBC
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.ProgressIndicator1 = new DSkin.Controls.DSkinProgressIndicator();
            this.SuspendLayout();
            // 
            // ProgressIndicator1
            // 
            this.ProgressIndicator1.AnimationSpeed = 80;
            this.ProgressIndicator1.AutoStart = true;
            this.ProgressIndicator1.BackColor = System.Drawing.Color.LightGray;
            this.ProgressIndicator1.CircleSize = 0.8F;
            this.ProgressIndicator1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProgressIndicator1.ForeColor = System.Drawing.Color.Blue;
            this.ProgressIndicator1.Location = new System.Drawing.Point(500, 350);
            this.ProgressIndicator1.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressIndicator1.Name = "ProgressIndicator1";
            this.ProgressIndicator1.Percentage = 0F;
            this.ProgressIndicator1.ShowText = true;
            this.ProgressIndicator1.Size = new System.Drawing.Size(200, 200);
            this.ProgressIndicator1.TabIndex = 0;
            this.ProgressIndicator1.TabStop = false;
            this.ProgressIndicator1.Text = "正在执行中......";
            this.ProgressIndicator1.TextDisplay = DSkin.Controls.TextDisplayModes.Text;
            this.ProgressIndicator1.Visible = false;
            // 
            // LoadingForm
            // 
            this.ActiveFocus = false;
            this.AllowDrop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CanResize = false;
            this.CaptionColor = System.Drawing.Color.Transparent;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionShowMode = DSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.ProgressIndicator1);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.EnableAnimation = false;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MoveMode = DSkin.Forms.MoveModes.None;
            this.Name = "LoadingForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowSystemButtons = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.SizeChanged += new System.EventHandler(this.LoadingForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinProgressIndicator ProgressIndicator1;
    }
}