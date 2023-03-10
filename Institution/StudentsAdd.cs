using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class StudentsAdd: Student
    {
        internal static Student[] students = {
           new Student("Андрей", "Щербаков",
           new DateTime(1983, 5, 23), new DateTime(1992,9,1),"Академия ТОР", "СПУ221", "Разработка программного обеспечения"),
           new Student("Андрей", "Комиссаров",
           new DateTime(1993, 7, 12), new DateTime(2001,9,1),"академия ТОР", "СПУ221", "Разработка программного обеспечения")
        };

        public StudentsAdd(string fName, string lName, DateTime date, DateTime startStudy, string institution, string gName, string specialization) : base(fName, lName, date, startStudy, institution, gName, specialization)
        {
            
        }
         public StudentsAdd(string fName, string lName, string sName, DateTime date, DateTime startStudy, string institution, string gName, string specialization) : base(fName, lName, sName, date, startStudy, institution, gName, specialization)
        {
            
        }

        public static Student[] StudentAdd(string fName, string lName, DateTime date, DateTime startStudy, string institution, string gName, string specialization)
        {
            Student[] studentAdd = new Student[students.Length+1];
            for (int i=0; i<studentAdd.Length-1; i++)
                studentAdd[i] = students[i];
            //studentAdd[studentAdd.Length-1] = new Student("Сергей", "Сизов", new DateTime(1989, 8, 2), "Академия ТОР", "СПУ221", "Разработка программного обеспечения");
            studentAdd[studentAdd.Length - 1] = new Student(fName, lName, date, startStudy, institution, gName, specialization);
            students = new Student[studentAdd.Length-1];
            students = studentAdd;
            return students;
        }
        public static Student[] StudentAdd(string fName, string lName, string sName, DateTime date, DateTime startStudy, string institution, string gName, string specialization)
        {
            Student[] studentAdd = new Student[students.Length+1];
            for (int i=0; i<studentAdd.Length-1; i++)
                studentAdd[i] = students[i];
            //studentAdd[studentAdd.Length-1] = new Student("Сергей", "Сизов", new DateTime(1989, 8, 2), "Академия ТОР", "СПУ221", "Разработка программного обеспечения");
            studentAdd[studentAdd.Length - 1] = new Student(fName, lName, sName, date, startStudy, institution, gName, specialization);
            students = new Student[studentAdd.Length-1];
            students = studentAdd;
            return students;
        }

        public override string ToString() 
        { 
            return base.ToString();
        }
    }
}
