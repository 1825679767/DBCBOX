
namespace BoxDBC
{
    partial class FileForm
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHost = new DSkin.Controls.ControlHost();
            this.DataPanel = new DSkin.Controls.DSkinPanel();
            this.DataGridView1 = new DSkin.Controls.DSkinDataGridView();
            this.ContextMenuStrip1 = new DSkin.Controls.DSkinContextMenuStrip();
            this.MoveToID = new System.Windows.Forms.ToolStripMenuItem();
            this.FindAs = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyNewLine = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyNewLineTo = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCellRow = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteLines = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomData = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNowFile = new System.Windows.Forms.ToolStripMenuItem();
            this.LockMode = new System.Windows.Forms.ToolStripMenuItem();
            this.BmPanel = new DSkin.Controls.DSkinPanel();
            this.FmLab1 = new DSkin.Controls.DSkinLabel();
            this.FmLab2 = new DSkin.Controls.DSkinLabel();
            this.CHost.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.BmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHost
            // 
            this.CHost.Controls.Add(this.DataPanel);
            this.CHost.Controls.Add(this.BmPanel);
            this.CHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHost.Location = new System.Drawing.Point(0, 0);
            this.CHost.Margin = new System.Windows.Forms.Padding(0);
            this.CHost.Name = "CHost";
            this.CHost.Size = new System.Drawing.Size(1190, 794);
            this.CHost.TabIndex = 0;
            this.CHost.TabStop = false;
            this.CHost.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // DataPanel
            // 
            this.DataPanel.BackColor = System.Drawing.Color.Transparent;
            this.DataPanel.Controls.Add(this.DataGridView1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("DataPanel.RightBottom")));
            this.DataPanel.Size = new System.Drawing.Size(1190, 764);
            this.DataPanel.TabIndex = 0;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridView1.ColumnFont = null;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 30;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DataGridView1.EnabledScrollbarBeautify = false;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.DataGridView1.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.LineNumber = false;
            this.DataGridView1.LineNumberForeColor = System.Drawing.Color.Transparent;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView1.MouseCellBackColor = System.Drawing.Color.SkyBlue;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersWidth = 120;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.RowTemplate.Height = 30;
            this.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ShowCellErrors = false;
            this.DataGridView1.ShowRowErrors = false;
            this.DataGridView1.Size = new System.Drawing.Size(1190, 764);
            this.DataGridView1.SkinGridColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.TabStop = false;
            this.DataGridView1.TitleBack = null;
            this.DataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.DataGridView1.TitleBackColorEnd = System.Drawing.Color.DarkGray;
            this.DataGridView1.VirtualMode = true;
            this.DataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.DataGridView1_CellToolTipTextNeeded);
            this.DataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DataGridView1_CellValueNeeded);
            this.DataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DataGridView1_CellValuePushed);
            this.DataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.ContextMenuStrip1.Back = System.Drawing.Color.OldLace;
            this.ContextMenuStrip1.BackRadius = 4;
            this.ContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.ContextMenuStrip1.CheckedImage = null;
            this.ContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.ContextMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.ContextMenuStrip1.ItemAnamorphosis = false;
            this.ContextMenuStrip1.ItemBorder = System.Drawing.Color.Transparent;
            this.ContextMenuStrip1.ItemBorderShow = false;
            this.ContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ContextMenuStrip1.ItemRadius = 1;
            this.ContextMenuStrip1.ItemRadiusStyle = DSkin.Common.RoundStyle.None;
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveToID,
            this.FindAs,
            this.CopyNewLine,
            this.CopyNewLineTo,
            this.DeleteCellRow,
            this.DeleteLines,
            this.PasteMulti,
            this.CustomData,
            this.SaveNowFile,
            this.LockMode});
            this.ContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ContextMenuStrip1.ItemSplitterShadowColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.RadiusStyle = DSkin.Common.RoundStyle.All;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(346, 244);
            this.ContextMenuStrip1.SkinAllColor = true;
            this.ContextMenuStrip1.TitleAnamorphosis = true;
            this.ContextMenuStrip1.TitleColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip1.TitleRadius = 4;
            this.ContextMenuStrip1.TitleRadiusStyle = DSkin.Common.RoundStyle.All;
            // 
            // MoveToID
            // 
            this.MoveToID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoveToID.Name = "MoveToID";
            this.MoveToID.Size = new System.Drawing.Size(345, 24);
            this.MoveToID.Text = "移动到指定编号行(Alt+A)";
            this.MoveToID.Click += new System.EventHandler(this.MoveToID_Click);
            // 
            // FindAs
            // 
            this.FindAs.Name = "FindAs";
            this.FindAs.Size = new System.Drawing.Size(345, 24);
            this.FindAs.Text = "全局查找替换(Ctrl+F)";
            this.FindAs.Click += new System.EventHandler(this.FindAs_Click);
            // 
            // CopyNewLine
            // 
            this.CopyNewLine.Name = "CopyNewLine";
            this.CopyNewLine.Size = new System.Drawing.Size(345, 24);
            this.CopyNewLine.Text = "复制当前行到新行(Alt+Q)";
            this.CopyNewLine.Click += new System.EventHandler(this.CopyNewLine_Click);
            // 
            // CopyNewLineTo
            // 
            this.CopyNewLineTo.Name = "CopyNewLineTo";
            this.CopyNewLineTo.Size = new System.Drawing.Size(345, 24);
            this.CopyNewLineTo.Text = "复制当前行到指定行(Alt+W)";
            this.CopyNewLineTo.Click += new System.EventHandler(this.CopyNewLineTo_Click);
            // 
            // DeleteCellRow
            // 
            this.DeleteCellRow.Name = "DeleteCellRow";
            this.DeleteCellRow.Size = new System.Drawing.Size(345, 24);
            this.DeleteCellRow.Text = "删除此单元格所在的一行或多行(Alt+G)";
            this.DeleteCellRow.Click += new System.EventHandler(this.DeleteCellRow_Click);
            // 
            // DeleteLines
            // 
            this.DeleteLines.Name = "DeleteLines";
            this.DeleteLines.Size = new System.Drawing.Size(345, 24);
            this.DeleteLines.Text = "删除选中的一行或多行(Alt+D)";
            this.DeleteLines.Click += new System.EventHandler(this.DeleteLines_Click);
            // 
            // PasteMulti
            // 
            this.PasteMulti.Name = "PasteMulti";
            this.PasteMulti.Size = new System.Drawing.Size(345, 24);
            this.PasteMulti.Text = "粘贴一行或多行(Ctrl+V)";
            this.PasteMulti.Click += new System.EventHandler(this.PasteMulti_Click);
            // 
            // CustomData
            // 
            this.CustomData.Name = "CustomData";
            this.CustomData.Size = new System.Drawing.Size(345, 24);
            this.CustomData.Text = "自定义处理(从另一个相同结构的表)(Alt+E)";
            this.CustomData.Click += new System.EventHandler(this.CustomData_Click);
            // 
            // SaveNowFile
            // 
            this.SaveNowFile.Name = "SaveNowFile";
            this.SaveNowFile.Size = new System.Drawing.Size(345, 24);
            this.SaveNowFile.Text = "保存当前文件(Ctrl+S)";
            this.SaveNowFile.Click += new System.EventHandler(this.SaveNowFile_Click);
            // 
            // LockMode
            // 
            this.LockMode.Name = "LockMode";
            this.LockMode.Size = new System.Drawing.Size(345, 24);
            this.LockMode.Text = "切换锁定模式(Alt+R)";
            this.LockMode.Click += new System.EventHandler(this.LockMode_Click);
            // 
            // BmPanel
            // 
            this.BmPanel.BackColor = System.Drawing.Color.Transparent;
            this.BmPanel.Controls.Add(this.FmLab1);
            this.BmPanel.Controls.Add(this.FmLab2);
            this.BmPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BmPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BmPanel.Location = new System.Drawing.Point(0, 764);
            this.BmPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BmPanel.Name = "BmPanel";
            this.BmPanel.RightBottom = ((System.Drawing.Image)(resources.GetObject("BmPanel.RightBottom")));
            this.BmPanel.Size = new System.Drawing.Size(1190, 30);
            this.BmPanel.TabIndex = 0;
            // 
            // FmLab1
            // 
            this.FmLab1.AutoSize = false;
            this.FmLab1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FmLab1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FmLab1.ForeColor = System.Drawing.Color.Blue;
            this.FmLab1.Location = new System.Drawing.Point(0, 0);
            this.FmLab1.Margin = new System.Windows.Forms.Padding(0);
            this.FmLab1.Name = "FmLab1";
            this.FmLab1.Size = new System.Drawing.Size(590, 30);
            this.FmLab1.TabIndex = 0;
            this.FmLab1.TabStop = false;
            this.FmLab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FmLab1.TextInnerPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // FmLab2
            // 
            this.FmLab2.AutoSize = false;
            this.FmLab2.Dock = System.Windows.Forms.DockStyle.Right;
            this.FmLab2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FmLab2.ForeColor = System.Drawing.Color.Blue;
            this.FmLab2.Location = new System.Drawing.Point(600, 0);
            this.FmLab2.Margin = new System.Windows.Forms.Padding(0);
            this.FmLab2.Name = "FmLab2";
            this.FmLab2.Size = new System.Drawing.Size(590, 30);
            this.FmLab2.TabIndex = 0;
            this.FmLab2.TabStop = false;
            this.FmLab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FmLab2.TextInnerPadding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.CHost);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FileForm";
            this.Size = new System.Drawing.Size(1190, 794);
            this.Load += new System.EventHandler(this.FileForm_Load);
            this.CHost.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.BmPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.ControlHost CHost;
        private DSkin.Controls.DSkinContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MoveToID;
        private System.Windows.Forms.ToolStripMenuItem CopyNewLine;
        private System.Windows.Forms.ToolStripMenuItem DeleteLines;
        private System.Windows.Forms.ToolStripMenuItem FindAs;
        private System.Windows.Forms.ToolStripMenuItem PasteMulti;
        private System.Windows.Forms.ToolStripMenuItem CustomData;
        private System.Windows.Forms.ToolStripMenuItem CopyNewLineTo;
        private System.Windows.Forms.ToolStripMenuItem SaveNowFile;
        private System.Windows.Forms.ToolStripMenuItem LockMode;
        private DSkin.Controls.DSkinLabel FmLab1;
        private DSkin.Controls.DSkinLabel FmLab2;
        private DSkin.Controls.DSkinPanel BmPanel;
        private DSkin.Controls.DSkinPanel DataPanel;
        public DSkin.Controls.DSkinDataGridView DataGridView1;
        private System.Windows.Forms.ToolStripMenuItem DeleteCellRow;
    }
}
