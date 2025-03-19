using DSkin.DirectUI;
using DSkin.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxDBC
{
    public partial class AsFindForm : DSkinForm
    {
        /// <summary>
        /// 查找事件类
        /// </summary>
        public delegate void NextFindTextEventHandler(int RowIndex, int ColumnIndex);
        /// <summary>
        /// 当查找
        /// </summary>
        public event NextFindTextEventHandler OnNextFindTextIndex;

        /// <summary>
        /// 替换1
        /// </summary>
        public delegate void OnReplaceTextOneEventHandler(int RowIndex, int ColumnIndex, string OldText, string NewText);
        /// <summary>
        /// 替换1
        /// </summary>
        public event OnReplaceTextOneEventHandler OnReplaceTextOne;

        /// <summary>
        /// 替换2
        /// </summary>
        public delegate void OnReplaceTextAllEventHandler(List<FindDataStore> FindDataStores, string OldText, string NewText);
        /// <summary>
        /// 替换2
        /// </summary>
        public event OnReplaceTextAllEventHandler OnReplaceTextAll;

        public List<FindDataStore> FindDataStores = new List<FindDataStore>();

        public int NowSelect = 0;

        public bool FillData = false;

        private bool AtCustomFind(bool Equals, bool MatchCase, string Text1, string Text2)
        {
            if (Equals)
            {
                if (MatchCase)
                    return Text1.Equals(Text2);
                else
                    return Text1.Equals(Text2, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                if (MatchCase)
                    return Text1.Contains(Text2);
                else
                    return Text1.IndexOf(Text2) >= 0;
            }
        }

        public (int, int) AutoOneFindNow(DataTable CacheData, bool Equals, bool MatchCase, string FindText)
        {
            for (int i = 0; i < CacheData.Rows.Count; i++)
            {
                for (int j = 0; j < CacheData.Columns.Count; j++)
                {
                    if (AtCustomFind(Equals, MatchCase, CacheData.Rows[i][j].ToString(), FindText))
                    {
                        return (i, j);
                    }
                }
            }

            return (-1, -1);
        }

        public void FistFindNow(string FindText)
        {
            FindDataStores.Clear();
            if (string.IsNullOrEmpty(TextBox1.Text))
                return;

            NowSelect = 0;
            bool Equals = CheckBox1.Checked;
            bool MatchCase = CheckBox2.Checked;
            var CacheData = Tag as DataTable;

            TsLab1.Text = $"查找中............";
            Task.Run(() =>
            {
                var (RIndex, CIndex) = AutoOneFindNow(CacheData, Equals, MatchCase, FindText);
                if (RIndex >= 0 && CIndex >= 0)
                    OnNextFindTextIndex?.Invoke(RIndex, CIndex);

                for (int i = 0; i < CacheData.Rows.Count; i++)
                    for (int j = 0; j < CacheData.Columns.Count; j++)
                        if (AtCustomFind(Equals, MatchCase, CacheData.Rows[i][j].ToString(), FindText))
                            FindDataStores.Add(new FindDataStore { CellValue = CacheData.Rows[i][j].ToString(), RowIndex = i, ColumnIndex = j });

            }).ContinueWith(T =>
            {
                if (T.IsFaulted)
                {
                    TsLab1.Text = $"找不到匹配的项目...请重新查找";
                    return;
                }
                int GsSelect = FindDataStores.Count > 0 ? 1 : 0;
                TsLab1.Text = $"共找到: {FindDataStores.Count} 个匹配项 当前第: {GsSelect} 个";
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void NextFindNow(string FindText)
        {
            if (string.IsNullOrEmpty(FindText))
                return;

            if (!FindDataStores.Any())
                return;

            NowSelect++;
            if (NowSelect >= FindDataStores.Count)
                NowSelect = 0;

            OnNextFindTextIndex?.Invoke(FindDataStores[NowSelect].RowIndex, FindDataStores[NowSelect].ColumnIndex);
            int GsSelect = NowSelect + 1;
            TsLab1.Text = $"共找到: {FindDataStores.Count} 个匹配项 当前第: {GsSelect} 个";
        }

        public AsFindForm()
        {
            InitializeComponent();
        }

        private void AsFindForm_Load(object sender, EventArgs e)
        {

        }

        private void AsFindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
   
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            FillData = false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            FillData = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillData = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!FillData)
            {
                FistFindNow(TextBox1.Text);
                FillData = true;
            }

            NextFindNow(TextBox1.Text);
        }

        private void BtnThs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox2.Text))
                return;

            if (!FindDataStores.Any())
                return;

            try
            {
                OnReplaceTextOne?.Invoke(FindDataStores[NowSelect].RowIndex, FindDataStores[NowSelect].ColumnIndex, FindDataStores[NowSelect].CellValue, TextBox2.Text);
                TsLab2.Text = $"成功替换: 1 个匹配项";
                FindDataStore FindStore = FindDataStores[NowSelect];
                FindDataStores.Remove(FindStore);
                NextFindNow(TextBox1.Text);
            } catch { }
        }

        private void BtnAs_Click(object sender, EventArgs e)
        {
            try
            {
                OnReplaceTextAll?.Invoke(FindDataStores, TextBox1.Text, TextBox2.Text);
                TsLab2.Text = $"成功替换: {FindDataStores.Count} 个匹配项";
                FindDataStores.Clear();
                FillData = false;
                BtnNext_Click(null, null);
            }
            catch { }
        }
    }
}
