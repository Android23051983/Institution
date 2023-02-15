using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Student:Human
    {
        protected DateTime _startStudy { get; set; }
        protected string _institution { get; set; }
        protected string _groupName { get; set; }
        protected string _specialization { get; set; }
        public Student(string fName, string lName, DateTime date, DateTime startStudy, string institution, string gName, string specialization) : base(fName, lName, date)
        {
            _startStudy = startStudy;
            _institution = institution;
            _groupName = gName;
            _specialization = specialization;
        } 
        public Student(string fName, string lName, string sName, DateTime date, DateTime startStudy, string institution, string gName, string specialization) : base(fName, lName, sName, date)
        {
            _startStudy = startStudy;
            _institution = institution;
            _groupName = gName;
            _specialization = specialization;
        }
        public override string ToString()
        {
            
            return $"{base.ToString()} \nУчусь в: {_institution}\nГруппа: {_groupName}\nСпециализация: {_specialization}\nДата начала учебы: {_startStudy.ToShortDateString()}\n";
        }
    }
}
