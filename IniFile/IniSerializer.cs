using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniFile
{
    public class IniSerializer
    {
        public string IniFilePath { get; set; }
        IniFile ini;

        public IniSerializer(string iniFilePath)
        {
            IniFilePath = iniFilePath;
            ini = new IniFile(IniFilePath);
        }

        public void Serialize(object t)
        {
            var ListOfProperties = from at in t.GetType().GetProperties()
                       where at.GetCustomAttributes(false).Any(a => a is IniKeyAttribute) && at.GetCustomAttributes(false).Any(a => a is IniSectionAttribute)
                                   select at;
            IniKeyAttribute key = null;
            IniSectionAttribute section = null;
            foreach (var property in ListOfProperties)
            {
                section = (IniSectionAttribute)Attribute.GetCustomAttribute(property, typeof(IniSectionAttribute));
                key = (IniKeyAttribute)Attribute.GetCustomAttribute(property, typeof(IniKeyAttribute));
                ini.Write(key.ElementName, property.GetValue(t).ToString(), section.ElementName);
            }
        }

        public void Deserialize(object t)
        {
            var ListOfProperties = from at in t.GetType().GetProperties()
                       where at.GetCustomAttributes(false).Any(a => a is IniKeyAttribute) && at.GetCustomAttributes(false).Any(a => a is IniSectionAttribute)
                       select at;
            IniKeyAttribute key = null;
            IniSectionAttribute section = null;
            foreach (var property in ListOfProperties)
            {
                section = (IniSectionAttribute)Attribute.GetCustomAttribute(property, typeof(IniSectionAttribute));
                key = (IniKeyAttribute)Attribute.GetCustomAttribute(property, typeof(IniKeyAttribute));
                property.SetValue(t, Convert.ChangeType(ini.Read(key.ElementName, section.ElementName), property.PropertyType));
            }
        }
    }
}
