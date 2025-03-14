using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BoxDBC
{
    public enum FalshType : uint
    {
        /// <summary>
        /// 停止闪烁
        /// </summary>
        Stop = 0,
        /// <summary>
        /// 只闪烁标题
        /// </summary>
        Caption = 1,
        /// <summary>
        /// 只闪烁任务栏
        /// </summary>
        Tray = 2,
        /// <summary>
        /// 标题和任务栏同时闪烁
        /// </summary>
        All = 3,
        /// <summary>
        /// 参数1
        /// </summary>
        Param1 = 4,
        /// <summary>
        /// 参数2
        /// </summary>
        Param2 = 12,
        /// <summary>
        /// 无条件闪烁任务栏直到发送停止标志或者窗口被激活 如果未激活 停止时高亮
        /// </summary>
        Timer = Tray | Param1,
        /// <summary>
        /// 未激活时闪烁任务栏直到发送停止标志或者窗体被激活 停止后高亮
        /// </summary>
        TimerNofg = Tray | Param2,
    }

    internal static class WinApis
    {
        static WinApis() { }

        #region 程序单例运行
        ///<summary>
        /// 该函数设置由不同线程产生的窗口的显示状态
        /// </summary>
        [DllImport("User32.dll")]
        public static extern bool ShowWindowAsync(IntPtr Wnd, int CmdShow);

        ///<summary>
        /// 设置顶级窗口并显示 仅一次
        /// </summary>
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr Wnd);

        private static void HandleRunningInstance(Process Instance)
        {
            ShowWindowAsync(Instance.MainWindowHandle, 1);
            SetForegroundWindow(Instance.MainWindowHandle);
        }

        private static Process RuningInstance()
        {
            Process CurrentProcess = Process.GetCurrentProcess();
            Process[] Processes = Process.GetProcessesByName(CurrentProcess.ProcessName);

            foreach (Process DoProcess in Processes)
            {
                if (DoProcess.Id != CurrentProcess.Id)
                {
                    return DoProcess;
                }
            }

            return null;
        }

        /// <summary>
        /// 程序以单例运行 
        /// </summary>
        public static void SoftSingle()
        {
            Process DoProcess = RuningInstance();
            if (DoProcess == null)
            {
                MainForm MForm = new MainForm();
                Application.Run(MForm);
            }
            else
            {
                HandleRunningInstance(DoProcess);
            }
        }

        /// <summary>
        /// 窗口动画弹出
        /// </summary>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr Wnd, int DateTime, int DwFlags);

        public static bool DoShowAnimateWindow(IntPtr Wnd)
        {
            ShowWindowAsync(Wnd, 1);
            SetForegroundWindow(Wnd);
            return AnimateWindow(Wnd, 500, 0x40000 | 0x0008);
        }
        #endregion

        #region 任务栏闪烁
        /// <summary>
        /// 包含系统应在指定时间内闪烁窗口次数和闪烁状态的信息
        /// </summary>
        public struct FlashWinfo
        {
            /// <summary>
            /// 结构大小
            /// </summary>
            public uint CbSize;
            /// <summary>
            /// 要闪烁或停止的窗口句柄
            /// </summary>
            public IntPtr Wnd;
            /// <summary>
            /// 闪烁的类型
            /// </summary>
            public uint DwFlags;
            /// <summary>
            /// 闪烁窗口的次数
            /// </summary>
            public uint Count;
            /// <summary>
            /// 窗口闪烁的频度 毫秒为单位 若该值为0 则为默认图标的闪烁频度
            /// </summary>
            public uint DwTimeout;
        }

        [DllImport("user32.dll")]
        public static extern bool FlashWindowEx(ref FlashWinfo Winfo);

        /// <summary>
        /// 闪烁 参数1=句柄 参数2=类型
        /// </summary>
        public static void FlashTaskBar(IntPtr Wnd, FalshType FType)
        {
            FlashWinfo FInfo = new FlashWinfo();
            FInfo.CbSize = Convert.ToUInt32(Marshal.SizeOf(FInfo));
            FInfo.Wnd = Wnd;
            FInfo.DwFlags = (uint)FType;
            FInfo.Count = uint.MaxValue;
            FInfo.DwTimeout = 512;
            FlashWindowEx(ref FInfo);
        }

        /// <summary>
        /// 主窗口显示闪烁 参数1=主窗口 参数2=显示或关闭
        /// </summary>
        public static void MainShowFlashTaskBar(MainForm ParentForm, bool Show)
        {
            FlashTaskBar(ParentForm.Handle, Show ? FalshType.Tray : FalshType.Stop);
        }

        #endregion
    }
}
