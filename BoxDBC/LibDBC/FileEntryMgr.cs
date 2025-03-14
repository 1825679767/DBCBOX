
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace BoxDBC
{
	public enum TextWowEnum
	{
		enUS,
		enGB,
		koKR,
		frFR,
		deDE,
		enCN,
		zhCN,
		enTW,
		zhTW,
		esES,
		esMX,
		ruRU,
		ptPT,
		ptBR,
		itIT,
		Unk,
	}

	public class FileEntryMgr : IDisposable
	{
		public DBHeader Header { get; private set; }
		public DataTable CacheData { get; set; }
		public string FilePath { get; private set; }
		public string SaveFilePath { get; set; }
		public string FileName { get; private set; }
		public Table TableStructure { get; private set; }
		public string Key { get; private set; }
		public string Tag { get; private set; }

		public FileEntryMgr(DBHeader DHeader, string DFilePath)
		{
			Header = DHeader;
			FilePath = DFilePath;
			FileName = Path.GetFileName(DFilePath);
			SaveFilePath = DFilePath;
			TableStructure = DBCMgr.Definitions.Tables.FirstOrDefault(X => X.Name.Equals(Path.GetFileNameWithoutExtension(DFilePath), StringComparison.CurrentCultureIgnoreCase));

			LoadDefinition();
		}

		public void LoadDefinition()
		{
			if (TableStructure == null)
				return;

			Key = TableStructure.Key.Name;
			Tag = Guid.NewGuid().ToString();

			if (TableStructure.Fields.GroupBy(X => X.Name).Any(Y => Y.Count() > 1))
				return;

			LoadTableStructure();
		}

		public void LoadTableStructure()
		{
			CacheData = new DataTable() { TableName = Tag, CaseSensitive = false, RemotingFormat = SerializationFormat.Binary };

			foreach (var Fd in TableStructure.Fields)
			{
				Queue<TextWowEnum> Languages = new Queue<TextWowEnum>(Enum.GetValues(typeof(TextWowEnum)).Cast<TextWowEnum>());

				for (int i = 0; i < Fd.ArraySize; i++)
				{
					string ColumnName = Fd.Name;

					if (Fd.ArraySize > 1)
					{
						ColumnName += "_" + (i + 1);
					}

					switch (Fd.Type.ToLower())
					{
						case "sbyte":
							CacheData.Columns.Add(ColumnName, typeof(sbyte));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "byte":
							CacheData.Columns.Add(ColumnName, typeof(byte));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "int32":
						case "int":
							CacheData.Columns.Add(ColumnName, typeof(int));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "uint32":
						case "uint":
							CacheData.Columns.Add(ColumnName, typeof(uint));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "int64":
						case "long":
							CacheData.Columns.Add(ColumnName, typeof(long));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "uint64":
						case "ulong":
							CacheData.Columns.Add(ColumnName, typeof(ulong));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "single":
						case "float":
							CacheData.Columns.Add(ColumnName, typeof(float));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "boolean":
						case "bool":
							CacheData.Columns.Add(ColumnName, typeof(bool));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "string":
							CacheData.Columns.Add(ColumnName, typeof(string));
							CacheData.Columns[ColumnName].DefaultValue = string.Empty;
							break;
						case "int16":
						case "short":
							CacheData.Columns.Add(ColumnName, typeof(short));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "uint16":
						case "ushort":
							CacheData.Columns.Add(ColumnName, typeof(ushort));
							CacheData.Columns[ColumnName].DefaultValue = 0;
							break;
						case "loc":
							for (int X = 0; X < 17; X++)
							{
								if (X == 16)
								{
									CacheData.Columns.Add(Fd.Name + "_Mask", typeof(uint));
									CacheData.Columns[Fd.Name + "_Mask"].AllowDBNull = false;
									CacheData.Columns[Fd.Name + "_Mask"].DefaultValue = 0;
								}
								else
								{
									ColumnName = Fd.Name + "_" + Languages.Dequeue().ToString();
									CacheData.Columns.Add(ColumnName, typeof(string));
									CacheData.Columns[ColumnName].AllowDBNull = false;
									CacheData.Columns[ColumnName].DefaultValue = string.Empty;
								}
							}
							break;
						default:
							throw new Exception($"未知字段类型 {Fd.Type} 来源 {Fd.Name}");
					}

					CacheData.Columns[ColumnName].AllowDBNull = false;
				}
			}

			CacheData.Columns[Key].DefaultValue = null;
			CacheData.PrimaryKey = new DataColumn[] { CacheData.Columns[Key] };
			CacheData.Columns[Key].AutoIncrement = true;
			CacheData.Columns[Key].Unique = true;
		}

		public void Dispose()
		{
			CacheData?.Dispose();
			CacheData = null;
			GC.SuppressFinalize(this);
		}
	}
}
