namespace BoxDBC
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BarPanel = new DSkin.Controls.DSkinPanel();
            this.TabBar1 = new DSkin.Controls.DSkinTabBar();
            this.TabBarIcon2 = new DSkin.Controls.DSkinIcon();
            this.TabBarIcon1 = new DSkin.Controls.DSkinIcon();
            this.TabControl1 = new DSkin.Controls.DSkinTabControl();
            this.MainTopPanel = new DSkin.Controls.DSkinPanel();
            this.MenuStrip1 = new DSkin.Controls.DSkinMenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCurrentFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SvaeToNew = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToMysql = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToSql = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToXls = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.OnPanel = new DSkin.Controls.DSkinPanel();
            this.TabPanel = new DSkin.Controls.DSkinPanel();
            this.BarPanel.SuspendLayout();
            this.MainTopPanel.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.OnPanel.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.Transparent;
            this.BarPanel.Borders.AllColor = System.Drawing.Color.DimGray;
            this.BarPanel.Borders.BottomColor = System.Drawing.Color.DimGray;
            this.BarPanel.Borders.LeftColor = System.Drawing.Color.DimGray;
            this.BarPanel.Borders.RightColor = System.Drawing.Color.DimGray;
            this.BarPanel.Borders.TopColor = System.Drawing.Color.DimGray;
            this.BarPanel.Controls.Add(this.TabBar1);
            this.BarPanel.Controls.Add(this.TabBarIcon2);
            this.BarPanel.Controls.Add(this.TabBarIcon1);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("BarPanel.RightBottom")));
            this.BarPanel.Size = new System.Drawing.Size(1190, 30);
            this.BarPanel.TabIndex = 4;
            this.BarPanel.Text = "dSkinPanel1";
            // 
            // TabBar1
            // 
            this.TabBar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TabBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabBar1.EnabledLayoutContent = true;
            this.TabBar1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabBar1.Location = new System.Drawing.Point(40, 0);
            this.TabBar1.Margin = new System.Windows.Forms.Padding(0);
            this.TabBar1.Name = "TabBar1";
            this.TabBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TabBar1.Size = new System.Drawing.Size(1110, 30);
            this.TabBar1.TabIndex = 0;
            this.TabBar1.TabStop = false;
            this.TabBar1.AcceptTask += new System.EventHandler<DSkin.DirectUI.AcceptTaskEventArgs>(this.TabBar1_AcceptTask);
            // 
            // TabBarIcon2
            // 
            this.TabBarIcon2.AutoSize = false;
            this.TabBarIcon2.Dock = System.Windows.Forms.DockStyle.Right;
            this.TabBarIcon2.ForeColor = System.Drawing.Color.Gray;
            this.TabBarIcon2.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.TabBarIcon2.Icon = DSkin.Common.FontAwesomeChars.icon_angle_double_right;
            this.TabBarIcon2.IconSize = 25F;
            this.TabBarIcon2.Location = new System.Drawing.Point(1150, 0);
            this.TabBarIcon2.Margin = new System.Windows.Forms.Padding(0);
            this.TabBarIcon2.Name = "TabBarIcon2";
            this.TabBarIcon2.Size = new System.Drawing.Size(40, 30);
            this.TabBarIcon2.TabIndex = 0;
            this.TabBarIcon2.TabStop = false;
            this.TabBarIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabBarIcon2.Click += new System.EventHandler(this.TabBarIcon2_Click);
            this.TabBarIcon2.MouseEnter += new System.EventHandler(this.TabBarIcon2_MouseEnter);
            this.TabBarIcon2.MouseLeave += new System.EventHandler(this.TabBarIcon2_MouseLeave);
            // 
            // TabBarIcon1
            // 
            this.TabBarIcon1.AutoSize = false;
            this.TabBarIcon1.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabBarIcon1.ForeColor = System.Drawing.Color.Gray;
            this.TabBarIcon1.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.TabBarIcon1.Icon = DSkin.Common.FontAwesomeChars.icon_angle_double_left;
            this.TabBarIcon1.IconSize = 25F;
            this.TabBarIcon1.Location = new System.Drawing.Point(0, 0);
            this.TabBarIcon1.Margin = new System.Windows.Forms.Padding(0);
            this.TabBarIcon1.Name = "TabBarIcon1";
            this.TabBarIcon1.Size = new System.Drawing.Size(40, 30);
            this.TabBarIcon1.TabIndex = 0;
            this.TabBarIcon1.TabStop = false;
            this.TabBarIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabBarIcon1.Click += new System.EventHandler(this.TabBarIcon1_Click);
            this.TabBarIcon1.MouseEnter += new System.EventHandler(this.TabBarIcon1_MouseEnter);
            this.TabBarIcon1.MouseLeave += new System.EventHandler(this.TabBarIcon1_MouseLeave);
            // 
            // TabControl1
            // 
            this.TabControl1.BitmapCache = false;
            this.TabControl1.Borders.AllColor = System.Drawing.Color.Transparent;
            this.TabControl1.Borders.BottomColor = System.Drawing.Color.Transparent;
            this.TabControl1.Borders.LeftColor = System.Drawing.Color.Transparent;
            this.TabControl1.Borders.RightColor = System.Drawing.Color.Transparent;
            this.TabControl1.Borders.TopColor = System.Drawing.Color.Transparent;
            this.TabControl1.CausesValidation = false;
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.TabControl1.ItemBackgroundImage = null;
            this.TabControl1.ItemBackgroundImageHover = null;
            this.TabControl1.ItemBackgroundImageSelected = null;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.TabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.TabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.TabControl1.SelectedBottomLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.TabControl1.SelectedBottomLineHeight = ((uint)(2u));
            this.TabControl1.Size = new System.Drawing.Size(1190, 794);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 0;
            this.TabControl1.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.TabControl1.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.TabControl1.UpdownBtnBackColor = System.Drawing.Color.White;
            this.TabControl1.UpdownBtnBorderColor = System.Drawing.Color.Black;
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainTopPanel.Controls.Add(this.MenuStrip1);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainTopPanel.Location = new System.Drawing.Point(5, 41);
            this.MainTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("MainTopPanel.RightBottom")));
            this.MainTopPanel.Size = new System.Drawing.Size(1190, 30);
            this.MainTopPanel.TabIndex = 0;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.AllowMerge = false;
            this.MenuStrip1.Arrow = System.Drawing.Color.Black;
            this.MenuStrip1.AutoSize = false;
            this.MenuStrip1.Back = System.Drawing.Color.LightGray;
            this.MenuStrip1.BackRadius = 1;
            this.MenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.MenuStrip1.Base = System.Drawing.Color.LightSlateGray;
            this.MenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.MenuStrip1.BaseForeAnamorphosis = false;
            this.MenuStrip1.BaseForeAnamorphosisBorder = 0;
            this.MenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.MenuStrip1.BaseItemAnamorphosis = false;
            this.MenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuStrip1.BaseItemBorderShow = true;
            this.MenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("MenuStrip1.BaseItemDown")));
            this.MenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("MenuStrip1.BaseItemMouse")));
            this.MenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuStrip1.BaseItemRadius = 1;
            this.MenuStrip1.BaseItemRadiusStyle = DSkin.Common.RoundStyle.None;
            this.MenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuStrip1.BaseItemSplitterShadowColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStrip1.CheckedImage = null;
            this.MenuStrip1.ClickThrough = true;
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuStrip1.Fore = System.Drawing.Color.Black;
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.MenuStrip1.HoverFore = System.Drawing.Color.Blue;
            this.MenuStrip1.ItemAnamorphosis = false;
            this.MenuStrip1.ItemBorder = System.Drawing.Color.Transparent;
            this.MenuStrip1.ItemBorderShow = true;
            this.MenuStrip1.ItemHover = System.Drawing.Color.LightSlateGray;
            this.MenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuStrip1.ItemRadius = 4;
            this.MenuStrip1.ItemRadiusStyle = DSkin.Common.RoundStyle.All;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RadiusStyle = DSkin.Common.RoundStyle.All;
            this.MenuStrip1.Size = new System.Drawing.Size(1190, 30);
            this.MenuStrip1.SkinAllColor = true;
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.TitleAnamorphosis = true;
            this.MenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.MenuStrip1.TitleRadius = 4;
            this.MenuStrip1.TitleRadiusStyle = DSkin.Common.RoundStyle.All;
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenNewFile,
            this.SaveCurrentFile,
            this.SvaeToNew,
            this.SaveToMysql,
            this.SaveToSql,
            this.SaveToXls,
            this.SaveToCSV});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(54, 26);
            this.ToolStripMenuItem1.Text = "文件";
            // 
            // OpenNewFile
            // 
            this.OpenNewFile.Name = "OpenNewFile";
            this.OpenNewFile.Size = new System.Drawing.Size(192, 26);
            this.OpenNewFile.Text = "打开新文件";
            this.OpenNewFile.Click += new System.EventHandler(this.OpenNewFile_Click);
            // 
            // SaveCurrentFile
            // 
            this.SaveCurrentFile.Name = "SaveCurrentFile";
            this.SaveCurrentFile.Size = new System.Drawing.Size(192, 26);
            this.SaveCurrentFile.Text = "保存当前文件";
            this.SaveCurrentFile.Click += new System.EventHandler(this.SaveCurrentFile_Click);
            // 
            // SvaeToNew
            // 
            this.SvaeToNew.Name = "SvaeToNew";
            this.SvaeToNew.Size = new System.Drawing.Size(192, 26);
            this.SvaeToNew.Text = "另存为当前文件";
            this.SvaeToNew.Click += new System.EventHandler(this.SvaeToNew_Click);
            // 
            // SaveToMysql
            // 
            this.SaveToMysql.Name = "SaveToMysql";
            this.SaveToMysql.Size = new System.Drawing.Size(192, 26);
            this.SaveToMysql.Text = "保存到数据库";
            this.SaveToMysql.Click += new System.EventHandler(this.SaveToMysql_Click);
            // 
            // SaveToSql
            // 
            this.SaveToSql.Name = "SaveToSql";
            this.SaveToSql.Size = new System.Drawing.Size(192, 26);
            this.SaveToSql.Text = "转存为SQL文件";
            this.SaveToSql.Click += new System.EventHandler(this.SaveToSql_Click);
            // 
            // SaveToXls
            // 
            this.SaveToXls.Name = "SaveToXls";
            this.SaveToXls.Size = new System.Drawing.Size(192, 26);
            this.SaveToXls.Text = "转存为Xls文件";
            this.SaveToXls.Click += new System.EventHandler(this.SaveToXls_Click);
            // 
            // SaveToCSV
            // 
            this.SaveToCSV.Name = "SaveToCSV";
            this.SaveToCSV.Size = new System.Drawing.Size(192, 26);
            this.SaveToCSV.Text = "转存为CSV文件";
            this.SaveToCSV.Click += new System.EventHandler(this.SaveToCSV_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(86, 26);
            this.ToolStripMenuItem2.Text = "使用说明";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // OnPanel
            // 
            this.OnPanel.BackColor = System.Drawing.Color.Transparent;
            this.OnPanel.Borders.AllColor = System.Drawing.Color.Transparent;
            this.OnPanel.Borders.BottomColor = System.Drawing.Color.Transparent;
            this.OnPanel.Borders.LeftColor = System.Drawing.Color.Transparent;
            this.OnPanel.Borders.RightColor = System.Drawing.Color.Transparent;
            this.OnPanel.Borders.TopColor = System.Drawing.Color.Transparent;
            this.OnPanel.Controls.Add(this.TabPanel);
            this.OnPanel.Controls.Add(this.BarPanel);
            this.OnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OnPanel.Location = new System.Drawing.Point(5, 71);
            this.OnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OnPanel.Name = "OnPanel";
            this.OnPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("OnPanel.RightBottom")));
            this.OnPanel.Size = new System.Drawing.Size(1190, 824);
            this.OnPanel.TabIndex = 8;
            this.OnPanel.Text = "dSkinPanel1";
            // 
            // TabPanel
            // 
            this.TabPanel.BackColor = System.Drawing.Color.Transparent;
            this.TabPanel.Controls.Add(this.TabControl1);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPanel.Location = new System.Drawing.Point(0, 30);
            this.TabPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("TabPanel.RightBottom")));
            this.TabPanel.Size = new System.Drawing.Size(1190, 794);
            this.TabPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.BorderColor = System.Drawing.Color.DimGray;
            this.CaptionBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))))};
            this.CaptionColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 40;
            this.CaptionOffset = new System.Drawing.Point(24, 3);
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.CloseBox.Size = new System.Drawing.Size(40, 40);
            this.CloseBox.ToolTip = "关闭";
            this.Controls.Add(this.OnPanel);
            this.Controls.Add(this.MainTopPanel);
            this.DragChangeBackImage = false;
            this.EnableAnimation = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HaloColor = System.Drawing.Color.Transparent;
            this.HaloSize = 0;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconRectangle = new System.Drawing.Rectangle(8, 5, 30, 30);
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MaxBox.Size = new System.Drawing.Size(40, 40);
            this.MaxBox.ToolTip = "最大化";
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.MinBox.Size = new System.Drawing.Size(40, 40);
            this.MinBox.ToolTip = "最小化";
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.MoveMode = DSkin.Forms.MoveModes.Title;
            this.Name = "MainForm";
            this.NormalBox.NormalColor = System.Drawing.Color.White;
            this.NormalBox.Size = new System.Drawing.Size(40, 40);
            this.NormalBox.ToolTip = "还原";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowShadow = true;
            this.Text = "DBC编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.BarPanel.ResumeLayout(false);
            this.MainTopPanel.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.OnPanel.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DSkin.Controls.DSkinPanel BarPanel;
        private DSkin.Controls.DSkinIcon TabBarIcon2;
        private DSkin.Controls.DSkinIcon TabBarIcon1;
        private DSkin.Controls.DSkinTabControl TabControl1;
        private DSkin.Controls.DSkinPanel MainTopPanel;
        private DSkin.Controls.DSkinPanel OnPanel;
        private DSkin.Controls.DSkinPanel TabPanel;
        private DSkin.Controls.DSkinTabBar TabBar1;
        private DSkin.Controls.DSkinMenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenNewFile;
        private System.Windows.Forms.ToolStripMenuItem SaveCurrentFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SvaeToNew;
        private System.Windows.Forms.ToolStripMenuItem SaveToMysql;
        private System.Windows.Forms.ToolStripMenuItem SaveToSql;
        private System.Windows.Forms.ToolStripMenuItem SaveToXls;
        private System.Windows.Forms.ToolStripMenuItem SaveToCSV;
    }
}

