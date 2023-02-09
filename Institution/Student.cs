using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Student:Human
    {
        protected string _institution { get; set; }
        protected string _groupName { get; set; }
        protected string _specialization { get; set; }
        public Student(string fName, string lName, DateTime date, string institution, string gName, string specialization) : base(fName, lName, date)
        {
            _institution = institution;
            _groupName = gName;
            _specialization = specialization;
        }
        public string Show()
        {
            
            return $"Фамилия: {_lastName} \nИмя: {_firstName} \nОтчество: {_secondName}\nДата рождения: {_birthDate.ToShortDateString()} \nУчусь в: {_institution}\nГруппа: {_groupName}\nСпециализация: {_specialization} \n\n";
        }
    }
}
