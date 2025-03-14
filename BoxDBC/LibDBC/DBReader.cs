
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;

namespace BoxDBC
{
	public class DBReader
	{
		public FileEntryMgr ReadFileMStream(MemoryStream MStream, string FilePath)
		{
			MStream.Position = 0;
			using (var BReader = new BinaryReader(MStream, Encoding.UTF8))
			{
                DBHeader Header = new DBHeader
                {
                    WTypeName = BReader.ReadString(4),
                    RecordCount = BReader.ReadUInt32(),
                    FieldCount = BReader.ReadUInt32(),
                    RecordSize = BReader.ReadUInt32(),
                    StringBlockSize = BReader.ReadUInt32()
                };

				if (BReader.BaseStream.Length < 20)
					throw new InvalidDataException("文件已损坏");

				if (!Header.WTypeName.Equals("WDBC", StringComparison.OrdinalIgnoreCase))
					throw new Exception("未知的文件类型");

				if (Header.RecordSize == 0 || Header.RecordCount == 0)
					throw new Exception("文件不包含任何记录");

				FileEntryMgr EntryMgr = new FileEntryMgr(Header, FilePath);
				if (EntryMgr.TableStructure == null)
					throw new Exception("TableField.xml 定义缺失");

				long Pos = BReader.BaseStream.Position;
				long StringTableStart = BReader.BaseStream.Position += Header.RecordCount * Header.RecordSize;
				Dictionary<int, string> StringTable = new StringTable().Read(BReader, StringTableStart);
				BReader.Scrub(Pos);
				ReadIntoTable(ref EntryMgr, BReader, StringTable);
				MStream.Dispose();
				return EntryMgr;
			}
		}

		public FileEntryMgr ReadFileMStream(string FilePath)
		{
			return ReadFileMStream(new MemoryStream(File.ReadAllBytes(FilePath)), FilePath);
		}

		public void ReadIntoTable(ref FileEntryMgr EntryMgr, BinaryReader BReader, Dictionary<int, string> StringTable)
		{
			TypeCode[] ColumnTypes = EntryMgr.CacheData.Columns.Cast<DataColumn>().Select(x => Type.GetTypeCode(x.DataType)).ToArray();
			FieldStructureEntry[] FieldBits = new FieldStructureEntry[EntryMgr.CacheData.Columns.Count].ToArray();
			uint Recordsize = EntryMgr.Header.RecordSize;
			for (uint i = 0; i < EntryMgr.Header.RecordCount; i++)
			{
				long Offset = BReader.BaseStream.Position;
				var Row = EntryMgr.CacheData.NewRow();
				for (int j = 0; j < EntryMgr.CacheData.Columns.Count; j++)
				{
					switch (ColumnTypes[j])
					{
						case TypeCode.Boolean:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadBoolean());
							break;
						case TypeCode.SByte:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadSByte());
							break;
						case TypeCode.Byte:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadByte());
							break;
						case TypeCode.Int16:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadInt16());
							break;
						case TypeCode.UInt16:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadUInt16());
							break;
						case TypeCode.Int32:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadInt32(FieldBits[j]));
							break;
						case TypeCode.UInt32:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadUInt32(FieldBits[j]));
							break;
						case TypeCode.Int64:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadInt64(FieldBits[j]));
							break;
						case TypeCode.UInt64:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadUInt64(FieldBits[j]));
							break;
						case TypeCode.Single:
							Row.SetField(EntryMgr.CacheData.Columns[j], BReader.ReadSingle());
							break;
						case TypeCode.String:
							int Index = EntryMgr.Header.GetStringOffset(BReader, j, i);
							Row.SetField(EntryMgr.CacheData.Columns[j], StringTable.ContainsKey(Index) ? StringTable[Index] : string.Empty);
							break;
						default:
							throw new Exception($"{i} 列中的字段类型未知");
					}
				}

				EntryMgr.CacheData.Rows.Add(Row);
				if (BReader.BaseStream.Position - Offset < Recordsize)
					BReader.BaseStream.Position += (Recordsize - (BReader.BaseStream.Position - Offset));
				else if (BReader.BaseStream.Position - Offset > Recordsize)
					throw new Exception("字段的定义超过结构大小");
			}
		}
	}
}
