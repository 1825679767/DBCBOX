using System.IO;
using System.Text;

namespace BoxDBC
{
    public class DBHeader
    {
        public string WTypeName { get; set; }
        public uint RecordCount { get; set; }
        public uint FieldCount { get; set; }
        public uint RecordSize { get; set; }
        public uint StringBlockSize { get; set; }

        public DBHeader()
        {

        }

		public int GetStringOffset(BinaryReader BReader, int j, uint i) => BReader.ReadInt32();

		public virtual void WriteHeader(BinaryWriter BW, FileEntryMgr EntryMgr)
        {
            BW.Write(Encoding.UTF8.GetBytes(WTypeName));
            BW.Write(EntryMgr.CacheData.Rows.Count);
            BW.Write(FieldCount);
            BW.Write(RecordSize);
            BW.Write((uint)1);
        }

        public void WriteRecordPadding(BinaryWriter BW, long Offset)
        {
            if (BW.BaseStream.Position - Offset < RecordSize)
                BW.BaseStream.Position += (RecordSize - (BW.BaseStream.Position - Offset));
        }
    }
}
