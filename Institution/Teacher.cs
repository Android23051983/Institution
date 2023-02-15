using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.DateTime;

namespace Institution
{
    internal class Teacher : Student
    {
        protected DateTime _startWork { set; get; }
        protected DateTime _finishWork { set; get; }
        protected string[] _groupsName { set; get; }
        public Teacher(string fName, string lName, DateTime date, string institution, string specialization, string[] groupsName, DateTime startWork) : base(fName, lName,  date, institution, specialization)
        {
            _groupsName = groupsName; 
            _startWork = startWork;
        }
        public Teacher(string fName, string lName, string sName, DateTime date, string institution, string specialization, string[] groupsName, DateTime startWork) : base(fName, lName, sName, date, institution, specialization)
        {
            _groupsName = groupsName; 
            _startWork = startWork;
        }

        public override string ToString()
        {

            return $"{base.ToString()} \nДата начала работы: {_startWork.ToShortDateString()}\n";
        }

    }
}
