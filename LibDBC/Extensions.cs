﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BoxDBC
{
    public static class Extensions
    {
        public static string DoReverse(this string Str)
        {
            return new string(Str.ToCharArray().Reverse().ToArray());
        }

        public static string ReadStringNull(this BinaryReader BReader)
        {
            byte Num;
            List<byte> Temp = new List<byte>();

            while ((Num = BReader.ReadByte()) != 0)
                Temp.Add(Num);

            return Encoding.UTF8.GetString(Temp.ToArray());
        }

        public static sbyte[] ReadSByte(this BinaryReader BReader, int Count)
        {
            var Arr = new sbyte[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadSByte();

            return Arr;
        }

        public static byte[] ReadByte(this BinaryReader BReader, int Count)
        {
            var Arr = new byte[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadByte();

            return Arr;
        }

        public static int[] ReadInt32(this BinaryReader BReader, int Count)
        {
            var Arr = new int[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadInt32();

            return Arr;
        }

        public static uint[] ReadUInt32(this BinaryReader BReader, int Count)
        {
            var Arr = new uint[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadUInt32();

            return Arr;
        }

        public static float[] ReadSingle(this BinaryReader BReader, int Count)
        {
            var Arr = new float[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadSingle();

            return Arr;
        }

        public static long[] ReadInt64(this BinaryReader BReader, int Count)
        {
            var Arr = new long[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadInt64();

            return Arr;
        }

        public static ulong[] ReadUInt64(this BinaryReader BReader, int Count)
        {
            var Arr = new ulong[Count];
            for (int i = 0; i < Count; i++)
                Arr[i] = BReader.ReadUInt64();

            return Arr;
        }

        public static string ReadString(this BinaryReader BReader, int Count)
        {
            byte[] StringArray = BReader.ReadBytes(Count);
            return Encoding.UTF8.GetString(StringArray);
        }

        public static int ReadInt32(this BinaryReader BReader, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                return BReader.ReadInt32();
            
            byte[] Bytes = new byte[sizeof(int)];
            for (int i = 0; i < FieldMap.ByteCount; i++)
                Bytes[i] = BReader.ReadByte();

            return BitConverter.ToInt32(Bytes, 0);
        }

        public static uint ReadUInt32(this BinaryReader BReader, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                return BReader.ReadUInt32();

            byte[] Bytes = new byte[sizeof(uint)];
            for (int i = 0; i < FieldMap.ByteCount; i++)
                Bytes[i] = BReader.ReadByte();

            return BitConverter.ToUInt32(Bytes, 0);
        }

        public static long ReadInt64(this BinaryReader BReader, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                return BReader.ReadInt64();

            byte[] Bytes = new byte[sizeof(long)];
            for (int i = 0; i < FieldMap.ByteCount; i++)
                Bytes[i] = BReader.ReadByte();

            return BitConverter.ToInt64(Bytes, 0);
        }

        public static ulong ReadUInt64(this BinaryReader BReader, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                return BReader.ReadUInt64();

            byte[] Bytes = new byte[sizeof(ulong)];
            for (int i = 0; i < FieldMap.ByteCount; i++)
                Bytes[i] = BReader.ReadByte();

            return BitConverter.ToUInt64(Bytes, 0);
        }

        public static void Scrub(this BinaryReader BReader, long Pos)
        {
            BReader.BaseStream.Position = Pos;
        }

        public static void Scrub(this BinaryWriter BReader, long Pos)
        {
            BReader.BaseStream.Position = Pos;
        }


        public static void WriteInt32(this BinaryWriter BReader, int value, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                BReader.Write(value);
            else
                BReader.Write(BitConverter.GetBytes(value), 0, FieldMap.ByteCount);
        }

        public static void WriteUInt32(this BinaryWriter BReader, uint value, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                BReader.Write(value);
            else
                BReader.Write(BitConverter.GetBytes(value), 0, FieldMap.ByteCount);
        }

        public static void WriteInt64(this BinaryWriter BReader, long value, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                BReader.Write(value);
            else
                BReader.Write(BitConverter.GetBytes(value), 0, FieldMap.ByteCount);
        }

        public static void WriteUInt64(this BinaryWriter BReader, ulong value, FieldStructureEntry FieldMap = null)
        {
            if (FieldMap == null)
                BReader.Write(value);
            else
                BReader.Write(BitConverter.GetBytes(value), 0, FieldMap.ByteCount);
        }

        public static void WriteArray<T>(this BinaryWriter BReader, T[] Data)
        {
            byte[] Bytes = new byte[Data.Length * System.Runtime.InteropServices.Marshal.SizeOf(typeof(T))];
            Buffer.BlockCopy(Data, 0, Bytes, 0, Bytes.Length);
            BReader.Write(Bytes);
        }
    }
}