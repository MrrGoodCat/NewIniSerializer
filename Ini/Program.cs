using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniFile;

namespace Ini
{
    class Program
    {
        static void Main(string[] args)
        {
            //IniFile.IniFile ini = new IniFile.IniFile(@"myIni.ini");
            Students stud = new Students();

            stud.Name = "Vasia";
            stud.Age = 19;
            stud.Subject = "Math";
            stud.Teacher = "Yana";
            stud.Town = "Vynnitsa";
            //ini.Write("name", "Rita", "owner");
            //ini.Write("age", "19", "owner");

            //Console.WriteLine(ini.Read("name", "owner"));

            IniSerializer ser = new IniSerializer(@"myIni.ini");
            ser.Serialize(stud);
            ser.Deserialize(stud);

            Console.WriteLine(stud.Name);
            Console.WriteLine(stud.Subject);
            Console.WriteLine(stud.Teacher);
            Console.WriteLine(stud.Town);
            Console.WriteLine(stud.Age);

            Console.ReadLine();
        }
    }
}
