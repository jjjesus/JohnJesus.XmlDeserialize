using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace JohnJesus.XmlDeserialize
{
    public class ConfigSettingsFactory
    {
        public static ConfigSettings createConfig(string xmlFile)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(ConfigSettings));
            TextReader reader = new StreamReader(xmlFile);
            var obj = deserializer.Deserialize(reader);
            reader.Close();
            ConfigSettings settings = (ConfigSettings)obj;
            return settings;
        }
    }
}
