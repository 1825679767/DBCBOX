using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

namespace BoxDBC
{
	public class StringTable : IDisposable
	{
		public Dictionary<int, string> Table = new Dictionary<int, string>();
		public int Size => (int)StringStream.Length;

		public MemoryStream StringStream = new MemoryStream();
		private Dictionary<string, int> _Stringlookup = new Dictionary<string, int>();

		public StringTable()
		{
			StringStream.WriteByte(0);
		}

		public int Write(string Str)
		{
			Str = Str.Replace("\r\n", "\n").Replace(Environment.NewLine, "\n");
			int Offset = 0;
			if (Str == "")
				return Offset;

			if (!_Stringlookup.TryGetValue(Str, out Offset))
			{
				byte[] StrBytes = Encoding.UTF8.GetBytes(Str);
				Offset = (int)StringStream.Position;
				_Stringlookup.Add(Str, Offset);
				StringStream.Write(StrBytes, 0, StrBytes.Length);
				StringStream.WriteByte(0);
			}

			return Offset;
		}

		public void CopyTo(Stream Sm)
		{
			StringStream.Position = 0;
			StringStream.CopyTo(Sm);
		}

		public Dictionary<int, string> Read(BinaryReader BReader, long StringTableStart, long StringTableEnd)
		{
			if (BReader.BaseStream.Position > StringTableEnd)
				return Table;

			while (BReader.BaseStream.Position < StringTableEnd)
			{
				int Pos = (int)BReader.BaseStream.Position;
				int Index = (int)(Pos - StringTableStart);
				Table[Index] = BReader.ReadStringNull();
			}

			return Table;
		}

		public Dictionary<int, string> Read(BinaryReader BReader, long StringTableStart)
		{
			return Read(BReader, StringTableStart, BReader.BaseStream.Length);
		}

		public void Dispose()
		{
			((IDisposable)StringStream).Dispose();
		}
	}
}
