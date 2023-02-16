using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class SpecialistsAdd : Specialist
    {
        internal static Specialist[] specialists = {
           new Specialist("Иван", "Щербаков",
           new DateTime(1983, 5, 23), new DateTime(2000, 3, 1), "Программист",11000, "5"),
           new Specialist("Василий", "Комиссаров",
           new DateTime(1993, 7, 12), new DateTime(2003, 5, 1), "Программист",11000,"3")
        };

        public SpecialistsAdd(string fName, string lName, DateTime date, DateTime stariWork, string qualification, int salary, string experience) : base(fName, lName, date, stariWork,qualification, salary, experience)
        {
            
        }
        public SpecialistsAdd(string fName, string lName, string sName, DateTime date, DateTime startWork, string qualification) : base(fName, lName, sName, date, startWork, qualification)
        {

        }

        public static Specialist[] SpecialistAdd(string fName, string lName, DateTime date, DateTime startWork, string qualification)
        {
            Specialist[] specialistAdd = new Specialist[specialists.Length + 1];
            for (int i = 0; i < specialistAdd.Length - 1; i++)
                specialistAdd[i] = specialists[i];
            //studentAdd[studentAdd.Length-1] = new Student("Сергей", "Сизов", new DateTime(1989, 8, 2), "Академия ТОР", "СПУ221", "Разработка программного обеспечения");
            specialistAdd[specialistAdd.Length - 1] = new Specialist(fName, lName, date, startWork, qualification);
            specialists = new Specialist[specialistAdd.Length - 1];
            specialists = specialistAdd;
            return specialists;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
