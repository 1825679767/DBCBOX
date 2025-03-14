using DSkin.Common;
using DSkin.Controls;
using DSkin.DirectUI;
using DSkin.Forms;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxDBC
{
    public partial class MainForm : DSkinForm
    {
        private bool LoadMask { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                DBCMgr.Definitions.LoadDefinition(Application.StartupPath + "\\TableField.xml");

                string[] Cmds = Environment.GetCommandLineArgs();
                if (Cmds.Length > 1)
                    AutoArgsLoadDBCFlie(Cmds[1]);

            }
            catch (Exception Ex)
            {
                StaticMessageBox.Show("错误", Ex.Message);
                Environment.Exit(0);
            }
        }

        public void AutoAllowDrop(bool Allow)
        {
            AllowDrop = Allow;
        }

        private void AutoArgsLoadDBCFlie(string FilePath)
        {
            if (!File.Exists(FilePath))
                return;
            if (!Path.GetExtension(FilePath).Equals(".dbc", StringComparison.CurrentCultureIgnoreCase))
            {
                StaticMessageBox.Show("错误", "该文件格式不是有效的DBC文件");
                return;
            }

            FileEntryMgr RepeatEntry = DBCMgr.Entries.FirstOrDefault(X => X.FilePath == FilePath);
            if (RepeatEntry != null)
            {
                StaticMessageBox.Show("错误", "不能对同一个路径文件操作 请放入其他目录再操作");
                return;
            }

            LoadMask = true;
            string FileName = Path.GetFileName(FilePath);

            Task.Run(() =>
            {
                DBCMgr.LoadFile(FilePath);
            }).ContinueWith(T =>
            {
                if (T.IsFaulted)
                {
                    StaticMessageBox.Show("错误", "\n请保持官方文件名\n或增加TableField.xml同样的Table Name = 文件名");
                    return;
                }
                FileEntryMgr Entry = DBCMgr.Entries.FirstOrDefault(X => X.FilePath == FilePath);
                if (Entry == null)
                    return;

                TabItemTemplate TabItem = new TabItemTemplate { Text = FileName, BackColor = Color.SkyBlue };
                TabBar1.Items.Add(TabItem);
                TabBar1.Items.Where(X => X.Text != TabItem.Text).ForEach(X => X.BackColor = Color.Transparent);
                var NowPage = new DSkinTabPage { BackColor = Color.Transparent, Text = FileName };
                FileForm DoForm = new FileForm(Entry) { Dock = DockStyle.Fill };
                NowPage.Controls.Add(DoForm);
                TabControl1.TabPages.Add(NowPage);
                TabControl1.SelectedTab = NowPage;
                TabControl1.SelectedTab.Tag = FilePath;

                AsFindForm OpenForm = (AsFindForm)Application.OpenForms["AsFindForm"];
                if (OpenForm != null && !OpenForm.IsDisposed)
                    OpenForm.Close();

                GHelper.ShowMainMask(false);

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void AutoLoadDBCFlie(string FilePath)
        {
            if (!File.Exists(FilePath))
                return;
            if (!Path.GetExtension(FilePath).Equals(".dbc", StringComparison.CurrentCultureIgnoreCase))
            {
                StaticMessageBox.Show("错误", "该文件格式不是有效的DBC文件");
                return;
            }

            FileEntryMgr RepeatEntry = DBCMgr.Entries.FirstOrDefault(X => X.FilePath == FilePath);
            if (RepeatEntry != null)
            {
                StaticMessageBox.Show("错误", "不能对同一个路径文件操作 请放入其他目录再操作");
                return;
            }

            GHelper.ShowMainMask(true);
            string FileName = Path.GetFileName(FilePath);

            Task.Run(() =>
            {
                DBCMgr.LoadFile(FilePath);
            }).ContinueWith(T =>
            {
                if (T.IsFaulted)
                {
                    StaticMessageBox.Show("错误", "\n请保持官方文件名\n或增加TableField.xml同样的Table Name = 文件名");
                    return;
                }
                FileEntryMgr Entry = DBCMgr.Entries.FirstOrDefault(X => X.FilePath == FilePath);
                if (Entry == null)
                    return;

                TabItemTemplate TabItem = new TabItemTemplate { Text = FileName, BackColor = Color.SkyBlue };
                TabBar1.Items.Add(TabItem);
                TabBar1.Items.Where(X => X.Text != TabItem.Text).ForEach(X => X.BackColor = Color.Transparent);
                var NowPage = new DSkinTabPage { BackColor = Color.Transparent, Text = FileName };
                FileForm DoForm = new FileForm(Entry) { Dock = DockStyle.Fill };
                NowPage.Controls.Add(DoForm);
                TabControl1.TabPages.Add(NowPage);
                TabControl1.SelectedTab = NowPage;
                TabControl1.SelectedTab.Tag = FilePath;

                AsFindForm OpenForm = (AsFindForm)Application.OpenForms["AsFindForm"];
                if (OpenForm != null && !OpenForm.IsDisposed)
                    OpenForm.Close();

                GHelper.ShowMainMask(false);

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private string AutoFilePath
        {
            get
            {
                if (TabControl1.SelectedTab == null)
                    return string.Empty;

                string FilePath = TabControl1.SelectedTab.Tag as string;
                if (string.IsNullOrEmpty(FilePath))
                    return string.Empty;

                return FilePath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoAllowDrop(true);
            TabControl1.ItemSize = new Size(1, 1);
            if (LoadMask)
                GHelper.ShowMainMask(true);
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            LoadingForm Mask = (LoadingForm)Application.OpenForms["LoadingForm"];
            if (Mask != null && !Mask.IsDisposed)
            {
                Mask.Size = new Size(Width, Height - 70);
                Mask.StartPosition = FormStartPosition.Manual;
                Mask.Location = new Point(Location.X, Location.Y + 70);
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            LoadingForm Mask = (LoadingForm)Application.OpenForms["LoadingForm"];
            if (Mask != null && !Mask.IsDisposed)
            {
                Mask.Size = new Size(Width, Height - 70);
                Mask.StartPosition = FormStartPosition.Manual;
                Mask.Location = new Point(Location.X, Location.Y + 70);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool Changes = false;
            foreach (FileEntryMgr Entry in DBCMgr.Entries)
            {
                if (Entry.CacheData.GetChanges() != null)
                    Changes = true;
            }

            if (Changes)
            {
                DialogResult Result = StaticMessageBox.Show("提示", "你有编辑后尚未保存的更改\n未保存将不会对文件产生改变\n你确定要关闭程序吗?", MessageBoxButtons.OKCancel);
                e.Cancel = (Result == DialogResult.Cancel);
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void TabBarIcon1_Click(object sender, EventArgs e)
        {
            TabBar1.Value -= 0.20;
        }

        private void TabBarIcon2_Click(object sender, EventArgs e)
        {
            TabBar1.Value += 0.20;
        }

        private void TabBar1_AcceptTask(object sender, AcceptTaskEventArgs e)
        {
            try
            {
                switch (e.TaskName)
                {
                    case "移除选项卡":
                        {
                            var Index = TabBar1.Items.IndexOf(e.Source);
                            FileEntryMgr Entry = DBCMgr.Entries[Index];
                            if (Entry.CacheData.GetChanges() != null)
                            {
                                DialogResult Result = StaticMessageBox.Show("提示", "你有编辑后尚未保存的更改\n未保存将不会对文件产生改变\n你确定要关闭文件吗?", MessageBoxButtons.OKCancel);
                                if (Result == DialogResult.Cancel)
                                    return;
                            }

                            TabBar1.Items.Remove(e.Source);
                            TabControl1.TabPages.RemoveAt(Index);
                            Entry.Dispose();
                            DBCMgr.Entries.RemoveAt(Index);

                            AsFindForm OpenForm = (AsFindForm)Application.OpenForms["AsFindForm"];
                            if (OpenForm != null && !OpenForm.IsDisposed)
                                OpenForm.Close();
                        }
                        break;
                    case "点击选项卡":
                        {
                            TabBar1.Items.Where(X => X != e.Source).ForEach(X => X.BackColor = Color.Transparent);

                            var Index = TabBar1.Items.IndexOf(e.Source);
                            FileEntryMgr Entry = DBCMgr.Entries[Index];
                            if (TabControl1.TabPages[Index] != null)
                            {
                                AsFindForm OpenForm = (AsFindForm)Application.OpenForms["AsFindForm"];
                                if (OpenForm != null && !OpenForm.IsDisposed)
                                {
                                    OpenForm.FillData = false;
                                    OpenForm.Tag = Entry.CacheData;
                                }
                            }

                            if (TabControl1.SelectedIndex != Index)
                                TabControl1.SelectedIndex = Index;
                        }
                        break;
                }
            }
            catch (Exception) { }
        }

        private void TabBarIcon1_MouseEnter(object sender, EventArgs e)
        {
            TabBarIcon1.ForeColor = Color.White;
        }

        private void TabBarIcon1_MouseLeave(object sender, EventArgs e)
        {
            TabBarIcon1.ForeColor = Color.Gray;
        }

        private void TabBarIcon2_MouseEnter(object sender, EventArgs e)
        {
            TabBarIcon2.ForeColor = Color.White;
        }

        private void TabBarIcon2_MouseLeave(object sender, EventArgs e)
        {
            TabBarIcon2.ForeColor = Color.Gray;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] DropFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (DropFiles.Length != 1)
            {
                StaticMessageBox.Show("错误", "一次只能打开一个文件");
                return;
            }
            string FilePath = DropFiles[0];
            AutoLoadDBCFlie(FilePath);
        }

        private void OpenNewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "文件|*.dbc",
                InitialDirectory = Application.StartupPath
            };
            if (FileDialog.ShowDialog() == DialogResult.OK)
                AutoLoadDBCFlie(FileDialog.FileName);
        }

        private void SaveCurrentFile_Click(object sender, EventArgs e)
        {
            FileEntryMgr Entry = DBCMgr.Entries.FirstOrDefault(X => X.FilePath == AutoFilePath);
            if (Entry == null)
                return;

            if (Entry.CacheData.GetChanges() == null)
                return;

            Entry.CacheData.AcceptChanges();

            GHelper.ShowMainMask(true);
            Task MTask = Task.Factory.StartNew(() =>
            {
                DBCMgr.WriteOrSaveFile(Entry, Entry.SaveFilePath);
            });

            MTask.GetAwaiter().OnCompleted(() =>
            {
                GHelper.ShowMainMask(false);
            });
        }

        private void SvaeToNew_Click(object sender, EventArgs e)
        {

        }

        private void SaveToMysql_Click(object sender, EventArgs e)
        {

        }

        private void SaveToSql_Click(object sender, EventArgs e)
        {

        }

        private void SaveToXls_Click(object sender, EventArgs e)
        {

        }

        private void SaveToCSV_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StaticMessageBox.Show("使用说明", "比C++的MyDbcEditor更易操作且快2倍 界面美观\n比C#的WDB加载速度快3倍 操作响应快5倍 不卡顿\n将DBC文件拖入或[文件]打开 列表框可以更多右键功能\n支持查找替换|跳转|复制粘贴|自定义移植数据|多行粘贴\n多文件同时操作|各种格式转换|一键生成物品补丁|文件合并\n目前仅支持3.35的WDBC文件");
        }
    }
}
