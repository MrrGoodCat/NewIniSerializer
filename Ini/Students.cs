using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniFile;

namespace Ini
{
    public class Students
    {
        string name = "Rita";
        int age;
        string town;
        string subject;
        string teacher;

        [IniSection(ElementName = "owner")]
        [IniKey(ElementName = "name")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [IniSection(ElementName = "Salsa")]
        [IniKey(ElementName = "age")]
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        [IniSection(ElementName = "owner")]
        [IniKey(ElementName = "Native town")]
        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }
        }

        [IniSection(ElementName = "Univer")]
        [IniKey(ElementName = "subject")]
        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        [IniSection(ElementName = "Univer")]
        [IniKey(ElementName = "teacher")]
        public string Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }
    }
}
