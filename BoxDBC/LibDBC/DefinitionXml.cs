using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BoxDBC
{
    [Serializable]
    public class DefinitionXml
    {
        [XmlElement("Table")]
        public HashSet<Table> Tables { get; set; } = new HashSet<Table>();

        public void LoadDefinition(string XMLPath)
        {
            try
            {
                XmlSerializer Deser = new XmlSerializer(typeof(DefinitionXml));
                using (var FStream = new FileStream(XMLPath, FileMode.Open, FileAccess.Read))
                {
                    DefinitionXml Def = (DefinitionXml)Deser.Deserialize(FStream);
                    var NewTables = Def.Tables.Where(X => Tables.Count(Y => X.Name == Y.Name) == 0).ToList();
                    NewTables.ForEach(X => X.Load());
                    Tables.UnionWith(NewTables.Where(X => X.Key != null));
                }
            }
            catch { throw new Exception($"Table加载错误"); }
        }
    }

    [Serializable]
    public class Table
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement("Field")]
        public List<Field> Fields { get; set; }
        [XmlIgnore]
        public Field Key { get; private set; }
        public void Load()
        {
            Key = Fields.FirstOrDefault(X => X.IsIndex);
        }
    }

    [Serializable]
    public class Field
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Type { get; set; }
        [XmlAttribute, DefaultValue(1)]
        public int ArraySize { get; set; } = 1;
        [XmlAttribute, DefaultValue(false)]
        public bool IsIndex { get; set; } = false;
    }
}
