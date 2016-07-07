using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniFile
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IniKeyAttribute : Attribute
    {
        public string ElementName { get; set; }
    }
}
