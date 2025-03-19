using DSkin.Common;
using DSkin.Controls;
using DSkin.DirectUI;
using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BoxDBC
{
    public partial class FileForm : DSkinUserControl
    {
        private FileEntryMgr FileEntry = null;

        private bool LockModeNow { get; set; } = false;

        private bool NotInKeyIndex(string KeyId)
        {
            try
            {
                bool In = true;
                foreach (DataRow Row in FileEntry.CacheData.Rows)
                {
                    if (Row[0].ToString() == KeyId)
                        In = false;
                }
                return In;
            }
            catch (Exception) { return false; }
        }

        private string AutoHasDataString(int RowIndex)
        {
            try
            {
                DataRow Row = FileEntry.CacheData.Rows[RowIndex];
                if (FileEntry.Header.StringBlockSize > 1)
                {
                    int Index = 0;
                    for (int i = 0; i < FileEntry.CacheData.Columns.Count; i++)
                    {
                        if (Row[i].GetType() == typeof(string))
                        {
                            Index = i + 4;
                            break;
                        }
                    }

                    if (Index == 0)
                        return $"{Row[0]}";

                    return $"{Row[0]} - {Row[Index]}";
                }

                return $"{Row[0]}";
            }
            catch (Exception) { return string.Empty; }
        }

        public FileForm(FileEntryMgr OnEntry)
        {
            InitializeComponent();

            Type RType = DataGridView1.GetType();
            PropertyInfo RInfo = RType.GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            RInfo.SetValue(DataGridView1, true, null);

            FileEntry = OnEntry;
            if (FileEntry == null || FileEntry.CacheData == null)
                return;

            DataGridView1.Font = new Font("微软雅黑", 10);
            DataGridView1.Columns.Clear();

            int Num = 0;
            foreach (DataColumn Column in FileEntry.CacheData.Columns)
            {
                Num++;
                DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    HeaderText = $"[{Num}] {Column.ColumnName}",
                    Width = 160,
                });
            }

            DataGridView1.ColumnCount = FileEntry.CacheData.Columns.Count;
            DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            FmLab1.Font = new Font("微软雅黑", 11);
            FmLab2.Font = new Font("微软雅黑", 11);
            FmLab1.Text = (FileEntry != null) ? $"文件路径: {FileEntry.FilePath}" : string.Empty;
            FmLab2.Text = "当前状态: 未锁定";

            FileEntry.CacheData.AcceptChanges();
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (FileEntry == null || FileEntry.CacheData == null || FileEntry.CacheData.Columns.Count <= 0 || FileEntry.CacheData.Rows.Count <= 0)
                return;
            string DrawText = AutoHasDataString(e.RowIndex);
            var NowFont = DataGridView1.RowHeadersDefaultCellStyle.Font;
            var NowForeColor = DataGridView1.RowHeadersDefaultCellStyle.ForeColor;
            Rectangle Rect = new Rectangle(e.RowBounds.Location.X + 20, e.RowBounds.Location.Y, DataGridView1.RowHeadersWidth - 24, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, DrawText, NowFont, Rect, NowForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        private void DataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (FileEntry == null || FileEntry.CacheData == null || FileEntry.CacheData.Columns.Count <= 0 || FileEntry.CacheData.Rows.Count <= 0)
                return;
            try
            {
                e.Value = FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex];
            }
            catch (Exception)
            {

            }
        }

        private void DataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (FileEntry == null || FileEntry.CacheData == null || FileEntry.CacheData.Columns.Count <= 0 || FileEntry.CacheData.Rows.Count <= 0)
                return;
            try
            {
                if (e.Value == null && FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex].GetType() == typeof(string))
                {
                    FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex] = string.Empty;
                    return;
                }
                FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex] = e.Value;
            }
            catch (Exception)
            {

            }
        }

        private void DataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (FileEntry == null || FileEntry.CacheData == null || FileEntry.CacheData.Columns.Count <= 0 || FileEntry.CacheData.Rows.Count <= 0)
                return;

            if (e.ColumnIndex == -1 || e.RowIndex == -1 || e.RowIndex >= FileEntry.CacheData.Rows.Count)
                return;

            string ShowStr = FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex].ToString();
            if (string.IsNullOrEmpty(ShowStr))
                return;

            StringBuilder SBuilder = new StringBuilder();
            SBuilder.AppendLine(FileEntry.CacheData.Rows[e.RowIndex][e.ColumnIndex].ToString());
            e.ToolTipText = SBuilder.ToString();
        }

        private void MoveToID_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }
                string Datagram = new ToEditForm().DoShowDialog(this);
                bool In = false;
                foreach (DataRow Row in FileEntry.CacheData.Rows)
                {
                    if (Row[0].ToString() == Datagram)
                    {
                        In = true;
                        int Index = FileEntry.CacheData.Rows.IndexOf(Row);
                        DataGridView1.CurrentCell = DataGridView1.Rows[Index].Cells[DataGridView1.CurrentCell.ColumnIndex];
                        DataGridView1.CurrentRow.Selected = true;
                    }
                }
                if (Datagram != string.Empty && !In)
                    StaticMessageBox.Show("提示", "编号不存在 找不到此编号指向的索引");
            }
            catch (Exception) { }
        }

        private void FindAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }

                var AtTopMainForm = GHelper.AtTopMainForm;
                if (AtTopMainForm == null)
                    return;
                AsFindForm OpenForm = (AsFindForm)Application.OpenForms["AsFindForm"];
                if (OpenForm != null && !OpenForm.IsDisposed)
                {
                    OpenForm.FillData = false;
                    OpenForm.StartPosition = FormStartPosition.Manual;
                    OpenForm.Location = new Point(AtTopMainForm.Location.X + (AtTopMainForm.Width - OpenForm.Width) / 2, AtTopMainForm.Location.Y);
                    OpenForm.Activate();
                }
                else
                {
                    AsFindForm AsForm = new AsFindForm
                    {
                        StartPosition = FormStartPosition.Manual,
                        Tag = FileEntry.CacheData
                    };

                    AsForm.OnNextFindTextIndex += (RowIndex, ColumnIndex) =>
                    {
                        DataGridView1.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                        DataGridView1.CurrentCell = DataGridView1.Rows[RowIndex].Cells[ColumnIndex];
                    };

                    AsForm.OnReplaceTextOne += (RIndex, CIndex, OldText, NewText) =>
                    {
                        if (LockModeNow)
                        {
                            StaticMessageBox.Show("提示", "锁定模式下无法操作");
                            return;
                        }

                        string NowStr = FileEntry.CacheData.Rows[RIndex][CIndex].ToString();
                        string NowReplaceText = NowStr.Replace(OldText, NewText);
                        FileEntry.CacheData.Rows[RIndex][CIndex] = NowReplaceText;
                        DataGridView1.Refresh();
                    };

                    AsForm.OnReplaceTextAll += (ViewCells, OldText, NewText) =>
                    {
                        if (LockModeNow)
                        {
                            StaticMessageBox.Show("提示", "锁定模式下无法操作");
                            return;
                        }

                        foreach (var DataCells in ViewCells)
                        {
                            string NowStr = FileEntry.CacheData.Rows[DataCells.RowIndex][DataCells.ColumnIndex].ToString();
                            string NowReplaceText = NowStr.Replace(OldText, NewText);
                            FileEntry.CacheData.Rows[DataCells.RowIndex][DataCells.ColumnIndex] = NowReplaceText;
                        }
                        DataGridView1.Refresh();
                    };

                    AsForm.Location = new Point(AtTopMainForm.Location.X + (AtTopMainForm.Width - AsForm.Width) / 2, AtTopMainForm.Location.Y);
                    AsForm.Show(AtTopMainForm);
                }
            }
            catch (Exception) { }
        }

        private void CopyNewLine_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }
                if (DataGridView1.CurrentRow == null)
                    return;
                int CurrentIndex = DataGridView1.Rows.IndexOf(DataGridView1.CurrentRow);
                var CurrentItemArray = FileEntry.CacheData.Rows[CurrentIndex].ItemArray;
                int LastIndex = FileEntry.CacheData.Rows.Count - 1;
                string NewId = FileEntry.CacheData.Rows[LastIndex][0].ToString();
                CurrentItemArray[0] = ulong.Parse(NewId) + 1;
                var NewDataRow = FileEntry.CacheData.Rows.Add(CurrentItemArray);
                int AddIndex = LastIndex + 1;
                DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
                DataGridView1.Refresh();
                DataGridView1.CurrentCell = DataGridView1.Rows[AddIndex].Cells[0];
                DataGridView1.Rows[AddIndex].Selected = true;
            }
            catch (Exception) { }
        }

        private void CopyNewLineTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }
                if (DataGridView1.CurrentRow == null)
                    return;

                string NewId = new ToEditForm().DoShowDialog(this);
                if (NewId != string.Empty)
                {
                    int CurrentIndex = DataGridView1.Rows.IndexOf(DataGridView1.CurrentRow);
                    var CurrentItemArray = FileEntry.CacheData.Rows[CurrentIndex].ItemArray;
                    bool Add = true;
                    foreach (DataRow Row in FileEntry.CacheData.Rows)
                    {
                        if (Row[0].ToString() == NewId)
                        {
                            int AddIndex = FileEntry.CacheData.Rows.IndexOf(Row);
                            for (int i = 1; i < CurrentItemArray.Length; i++)
                            {
                                Row[i] = CurrentItemArray[i];
                            }

                            DataGridView1.Refresh();
                            DataGridView1.CurrentCell = DataGridView1.Rows[AddIndex].Cells[0];
                            DataGridView1.Rows[AddIndex].Selected = true;
                            Add = false;
                        }
                    }
                    if (Add)
                    {
                        int LastIndex = FileEntry.CacheData.Rows.Count - 1;

                        /*
                        var LastItemArray = FileEntry.CacheData.Rows[LastIndex].ItemArray;
                        if (LastItemArray[0].GetType() != typeof(string) && int.Parse(NewId) < (int)LastItemArray[0])
                        {
                            StaticMessageBox.Show("提示", "由于排序模式 不能小于最大编号");
                            return;
                        }
                        */

                        int AddIndex = FileEntry.CacheData.Rows.Count;
                        CurrentItemArray[0] = int.Parse(NewId);
                        var NewDataRow = FileEntry.CacheData.Rows.Add(CurrentItemArray);
                        DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
                        DataGridView1.Refresh();
                        DataGridView1.CurrentCell = DataGridView1.Rows[AddIndex].Cells[0];
                        DataGridView1.Rows[AddIndex].Selected = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void DeleteCellRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }

                if (DataGridView1.SelectedCells.Count == 0)
                {
                    StaticMessageBox.Show("提示", "没有选中单元格");
                    return;
                }

                DialogResult Result = StaticMessageBox.Show("提示", "你确定要删除这些数据吗?\n删除后保存才能生效\n不保存则重新打开文件即可\n防止误删重要数据", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    int LastIndex = 0;
                    foreach (DataGridViewCell ViewCell in DataGridView1.SelectedCells)
                    {
                        if (ViewCell.OwningRow != null)
                        {
                            int Index = DataGridView1.Rows.IndexOf(ViewCell.OwningRow);
                            LastIndex = Index;
                            FileEntry.CacheData.Rows.RemoveAt(Index);
                        }
                    }
                    DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
                    DataGridView1.Refresh();
                    if (DataGridView1.Rows[LastIndex] != null)
                    {
                        DataGridView1.CurrentCell = DataGridView1.Rows[LastIndex].Cells[0];
                        DataGridView1.Rows[LastIndex].Selected = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void DeleteLines_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }

                if (DataGridView1.SelectedRows.Count == 0)
                {
                    StaticMessageBox.Show("提示", "没有选中整行");
                    return;
                }
                DialogResult Result = StaticMessageBox.Show("提示", "你确定要删除这些数据吗?\n删除后保存才能生效\n不保存则重新打开文件即可\n防止误删重要数据", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    int LastIndex = 0;
                    foreach (DataGridViewRow ViewRow in DataGridView1.SelectedRows)
                    {
                        int Index = DataGridView1.Rows.IndexOf(ViewRow);
                        LastIndex = Index;
                        FileEntry.CacheData.Rows.RemoveAt(Index);
                    }
                    DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
                    DataGridView1.Refresh();
                    if (DataGridView1.Rows[LastIndex] != null)
                    {
                        DataGridView1.CurrentCell = DataGridView1.Rows[LastIndex].Cells[0];
                        DataGridView1.Rows[LastIndex].Selected = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void PasteMulti_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }
                if (DataGridView1.CurrentCell.IsInEditMode)
                    return;
                string Context = Clipboard.GetText();
                if (string.IsNullOrEmpty(Context))
                    return;
                DialogResult Result = StaticMessageBox.Show("提示", "你确定要把剪切板数据粘贴到此表?", MessageBoxButtons.OKCancel);
                if (Result == DialogResult.OK)
                {
                    int LastIndex = DataGridView1.Rows.Count - 1;
                    string[] PastValue = Context.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    bool On = false;
                    foreach (var Line in PastValue)
                    {
                        string[] SResult = Line.Split('\t');
                        if (SResult.Length == FileEntry.CacheData.Columns.Count && NotInKeyIndex(SResult[0]))
                        {
                            DataRow Row = FileEntry.CacheData.Rows.Add(SResult);
                            int Index = FileEntry.CacheData.Rows.IndexOf(Row);
                            LastIndex = Index;
                            On = true;
                        }
                    }

                    if (On)
                    {
                        DataGridView1.RowCount = FileEntry.CacheData.Rows.Count;
                        DataGridView1.Refresh();
                        DataGridView1.CurrentCell = DataGridView1.Rows[LastIndex].Cells[0];
                        DataGridView1.Rows[LastIndex].Selected = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void CustomData_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }
            }
            catch (Exception) { }
        }

        private void SaveNowFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (LockModeNow)
                {
                    StaticMessageBox.Show("提示", "锁定模式下无法操作");
                    return;
                }

                if (FileEntry.CacheData.GetChanges() == null)
                    return;

                FileEntry.CacheData.AcceptChanges();
                GHelper.ShowMainMask(true);
                Task MTask = Task.Factory.StartNew(() =>
                {
                    DBCMgr.WriteOrSaveFile(FileEntry, FileEntry.SaveFilePath);
                });

                MTask.GetAwaiter().OnCompleted(() =>
                {
                    GHelper.ShowMainMask(false);
                });
            }
            catch (Exception) { }
        }

        private void LockMode_Click(object sender, EventArgs e)
        {
            try
            {
                LockModeNow = !LockModeNow;
                foreach (DataGridViewColumn Column in DataGridView1.Columns)
                    Column.ReadOnly = LockModeNow;

                FmLab2.ForeColor = LockModeNow ? Color.Red : Color.Blue;
                FmLab2.Text = LockModeNow ? "当前状态: 已锁定 无法操作" : "当前状态: 未锁定";
            }
            catch (Exception) { }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (sender != null && sender.GetType() == typeof(DSkinDataGridView))
                {
                    if (ModifierKeys == Keys.Control)
                    {
                        if (e.KeyCode == Keys.V)
                        {
                            PasteMulti_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.S)
                        {
                            SaveNowFile_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.F)
                        {
                            FindAs_Click(null, null);
                        }
                    }
                    else if(ModifierKeys == Keys.Alt)
                    {
                        if (e.KeyCode == Keys.A)
                        {
                            MoveToID_Click(null, null);
                        }
                        else if(e.KeyCode == Keys.Q)
                        {
                            CopyNewLine_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.W)
                        {
                            CopyNewLineTo_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.G)
                        {
                            DeleteCellRow_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.D)
                        {
                            DeleteLines_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.E)
                        {
                            CustomData_Click(null, null);
                        }
                        else if (e.KeyCode == Keys.R)
                        {
                            LockMode_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
