
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxDBC
{
    /// <summary>
    /// 全局帮助类
    /// </summary>
    public static class GHelper
    {
        public static MainForm AtTopMainForm
        {
            get
            {
                MainForm MForm = (MainForm)Application.OpenForms["MainForm"];
                if (MForm == null || MForm.IsDisposed)
                    return null;

                return MForm;
            }
        }

        public static void ShowMainMask(bool Show)
        {
            if (AtTopMainForm == null)
                return;

            AtTopMainForm.AutoAllowDrop(!Show);
            if (Show)
            {
                LoadingForm Mask = new LoadingForm
                {
                    Size = new Size(AtTopMainForm.Width, AtTopMainForm.Height - 70),
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(AtTopMainForm.Location.X, AtTopMainForm.Location.Y + 70)
                };
                Mask.ShowProgressIndicator(true);
                Mask.Show(AtTopMainForm);
            }
            else
            {
                LoadingForm Mask = (LoadingForm)Application.OpenForms["LoadingForm"];
                if (Mask != null && !Mask.IsDisposed)
                    Mask.Close();
            }
        }
    }

    public class FindDataStore
    {
        public string CellValue { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }
}