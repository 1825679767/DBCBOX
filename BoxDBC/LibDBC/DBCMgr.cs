using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;

namespace BoxDBC
{
	class DBCMgr
	{
		public static DefinitionXml Definitions { get; set; } = new DefinitionXml();
		public static List<FileEntryMgr> Entries { get; set; } = new List<FileEntryMgr>();

		public static void LoadFile(string FilePath)
		{
			DBReader Reader = new DBReader();
			FileEntryMgr Entry = Reader.ReadFileMStream(FilePath);
			if (Entry != null)
				Entries.Add(Entry);

			ForceGC();
		}

		public static void WriteOrSaveFile(FileEntryMgr EntryMgr, string FilePath)
		{
			using (var FStream = new FileStream(FilePath, FileMode.Create))
			using (var MStream = new MemoryStream())
			using (var BW = new BinaryWriter(MStream))
			{
				StringTable St = new StringTable();
				EntryMgr.Header.WriteHeader(BW, EntryMgr);
				WriteIntoFile(EntryMgr, BW, EntryMgr.CacheData.AsEnumerable(), ref St);
				if (St.Size > 0)
				{
					long pos = BW.BaseStream.Position;
					BW.Scrub(0x10);
					BW.Write(St.Size);
					BW.Scrub(pos);
					St.CopyTo(BW.BaseStream);
				}
				St.Dispose();
				MStream.Position = 0;
				MStream.CopyTo(FStream);
			}
		}

		private static void WriteIntoFile(FileEntryMgr EntryMgr, BinaryWriter BW, IEnumerable<DataRow> Rows, ref StringTable St)
		{
			TypeCode[] ColumnTypes = EntryMgr.CacheData.Columns.Cast<DataColumn>().Select(x => Type.GetTypeCode(x.DataType)).ToArray();
			FieldStructureEntry[] FieldBits = new FieldStructureEntry[EntryMgr.CacheData.Columns.Count].ToArray();
			foreach (DataRow Row in Rows)
			{
				long Offset = BW.BaseStream.Position;
				for (int j = 0; j < EntryMgr.CacheData.Columns.Count; j++)
				{
					switch (ColumnTypes[j])
					{
						case TypeCode.SByte:
							BW.Write(Row.Field<sbyte>(j));
							break;
						case TypeCode.Byte:
							BW.Write(Row.Field<byte>(j));
							break;
						case TypeCode.Int16:
							BW.Write(Row.Field<short>(j));
							break;
						case TypeCode.UInt16:
							BW.Write(Row.Field<ushort>(j));
							break;
						case TypeCode.Int32:
							BW.WriteInt32(Row.Field<int>(j), FieldBits?[j]);
							break;
						case TypeCode.UInt32:
							BW.WriteUInt32(Row.Field<uint>(j), FieldBits?[j]);
							break;
						case TypeCode.Int64:
							BW.WriteInt64(Row.Field<long>(j), FieldBits?[j]);
							break;
						case TypeCode.UInt64:
							BW.WriteUInt64(Row.Field<ulong>(j), FieldBits?[j]);
							break;
						case TypeCode.Single:
							BW.Write(Row.Field<float>(j));
							break;
						case TypeCode.String:
							BW.Write(St.Write(Row.Field<string>(j)));
							break;
						default:
							throw new Exception($"未知类型代码 {ColumnTypes[j]}");
					}
				}
				EntryMgr.Header.WriteRecordPadding(BW, Offset);
			}
		}

		public static void ForceGC()
		{
			GC.Collect();
			GC.WaitForFullGCComplete();
		}
	}

	public class FieldStructureEntry
	{
		public short Bits;
		public ushort Offset;

		public int ByteCount
		{
			get
			{
				int Value = (32 - Bits) >> 3;
				return (Value < 0 ? Math.Abs(Value) + 4 : Value);
			}
		}
	}
}
