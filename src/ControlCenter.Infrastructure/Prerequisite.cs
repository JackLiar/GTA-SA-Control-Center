using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace ControlCenter.Infrastructure
{
    public static class Prerequisite
    {
        private static readonly IList<string> Prerequisites = new List<string>
        {
            "GTASACarPics",
            "GTASACars",
            "GTASACarTypes",
            "GTASACheats",
            "GTASAColors",
            "GTASALocations",
            "GTASAShortcuts",
            "GTASAWeapons"
        };

        private static object GetResource(string name)
        {
            var rm = new ResourceManager("ControlCenter.Infrastructure.Properties.Resources", Assembly.GetExecutingAssembly());
            var resourceSet = rm.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            return resourceSet.Cast<DictionaryEntry>().FirstOrDefault(r => (string) r.Key == name).Value;
        }

        private static void RegenerateXml(string name)
        {
            var xml = GetResource(name) as string;
            File.WriteAllText(@".\" + name + ".xml", xml);
        }

        /// <summary>
        /// Check ControlCenter's prerequisites, if not exist regenerate files
        /// </summary>
        public static void Check()
        {
            foreach (var prerequisite in Prerequisites)
            {
                var sb = new StringBuilder();
                var name = sb.Append(AppDomain.CurrentDomain.BaseDirectory).Append(prerequisite).Append(".xml")
                    .ToString();
                if (!File.Exists(name))
                {
                    RegenerateXml(prerequisite);
                }
            }
        }
    }
}