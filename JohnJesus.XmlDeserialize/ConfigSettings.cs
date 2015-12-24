using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace JohnJesus.XmlDeserialize
{
    public class ConfigSettings
    {
        [XmlElement("SettingsName")]
        public string SettingsName { get; set; }
        [XmlElement("PositionX")]
        public int PositionX { get; set; }
        [XmlElement("PositionY")]
        public int PositionY { get; set; }
        [XmlElement("PositionZ")]
        public int PositionZ { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder("Config Settings\n");
            sb.AppendLine(             "===============");
            sb.AppendFormat("\tPositionX : {0}\n", this.PositionX);
            sb.AppendFormat("\tPositionY : {0}\n", this.PositionY);
            sb.AppendFormat("\tPositionZ : {0}\n", this.PositionZ);

            return sb.ToString();
        }
    }
}
