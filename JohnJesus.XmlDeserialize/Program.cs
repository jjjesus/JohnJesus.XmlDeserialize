using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JohnJesus.XmlDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFilename = "ConfigSettings.xml";

            var configSettings = ConfigSettingsFactory.createConfig(xmlFilename);
            Console.WriteLine(configSettings.ToString());

            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();
        }
    }
}
