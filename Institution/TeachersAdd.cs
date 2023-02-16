using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class TeachersAdd : Teacher
    {
        static string[] groupsName = { "СПУ221", "СПУ223" };
        static string[] groupsName1 = { "СПУ221" };
        internal static Teacher[] teachers = {
           new Teacher("Иван", "Щербаков",
           new DateTime(1983, 5, 23),"Академия ТОР", "Программист", groupsName , new DateTime(2000, 3, 1)),
           new Teacher("Василий", "Комиссаров",
           new DateTime(1993, 7, 12), "Академия ТОР", "Программист", groupsName1, new DateTime(2003, 5, 1))
        };

        public TeachersAdd(string fName, string lName, DateTime date, string institution,string specialization, string[] groupsName, DateTime startWork) :base(fName, lName, date, institution, specialization, groupsName, startWork)
        { 
        
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
