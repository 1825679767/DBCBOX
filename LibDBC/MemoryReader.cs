using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace BoxDBC
{
    public class MemoryReader : IDisposable
    {
        public ulong BaseAddress { get; private set; }
        public IntPtr ProcessHandle { get; private set; }

        public void Dispose()
        {
            if (ProcessHandle != IntPtr.Zero && !CloseHandle(ProcessHandle))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            GC.SuppressFinalize(this);
        }

        ~MemoryReader()
        {
            Dispose();
        }

        public byte[] ReadBytes(IntPtr IAddress, uint Count)
        {
            var AtBuffer = new byte[Count];
            if (!ReadProcessMemory(ProcessHandle, IAddress, AtBuffer, Count, out int BytesRead))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            if (BytesRead != Count)
                throw new Exception("读取的字节数与所需的字节数不匹配");
            return AtBuffer;
        }

        public T Read<T>(IntPtr IAddress) where T : struct
        {
            object Ret = default(T);
            if (typeof(T) == typeof(string))
                return (T)(object)ReadCString(IAddress);

            var AtBuffer = ReadBytes(IAddress, (uint)Marshal.SizeOf(typeof(T)));
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Object:
                    GCHandle handle = GCHandle.Alloc(AtBuffer, GCHandleType.Pinned);
                    Marshal.PtrToStructure(handle.AddrOfPinnedObject(), Ret);
                    handle.Free();
                    break;
                case TypeCode.Boolean:
                    Ret = BitConverter.ToBoolean(AtBuffer, 0);
                    break;
                case TypeCode.Char:
                    Ret = BitConverter.ToChar(AtBuffer, 0);
                    break;
                case TypeCode.Byte:
                    Ret = AtBuffer[0];
                    break;
                case TypeCode.Int16:
                    Ret = BitConverter.ToInt16(AtBuffer, 0);
                    break;
                case TypeCode.UInt16:
                    Ret = BitConverter.ToUInt16(AtBuffer, 0);
                    break;
                case TypeCode.Int32:
                    Ret = BitConverter.ToInt32(AtBuffer, 0);
                    break;
                case TypeCode.UInt32:
                    Ret = BitConverter.ToUInt32(AtBuffer, 0);
                    break;
                case TypeCode.Int64:
                    Ret = BitConverter.ToInt64(AtBuffer, 0);
                    break;
                case TypeCode.UInt64:
                    Ret = BitConverter.ToUInt64(AtBuffer, 0);
                    break;
                case TypeCode.Single:
                    Ret = BitConverter.ToSingle(AtBuffer, 0);
                    break;
                case TypeCode.Double:
                    Ret = BitConverter.ToDouble(AtBuffer, 0);
                    break;
                default:
                    throw new NotSupportedException($"未知类型 {typeof(T).Name}");
            }

            return (T)Ret;
        }

        public string ReadCString(IntPtr IAddress)
        {
            var AtBuffer = new List<byte>();
            int i = 0;
            byte Current = Read<byte>((IntPtr)(IAddress.ToInt32() + i));
            while (Current != 0)
            {
                AtBuffer.Add(Current);
                i++;
                Current = Read<byte>((IntPtr)(IAddress.ToInt32() + i));
            }
            return Encoding.UTF8.GetString(AtBuffer.ToArray());
        }

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccess dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        private enum ProcessAccess
        {
            AllAccess = 0x2 | 0x40 | 0x400 | 0x200 | 0x1 | 0x8 | 0x10 | 0x20 | 0x100000
        }
    }
}
