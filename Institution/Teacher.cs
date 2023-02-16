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
        protected string[] _groupsName;
        public Teacher(string fName, string lName, DateTime date, string institution, string specialization, string[] groupsName, DateTime startWork) : base(fName, lName,  date, institution, specialization)
        {
            _groupsName = new string[groupsName.Length];
            for (int i = 0; i < groupsName.Length; i++)
            {
                _groupsName[i] = groupsName[i];
            }
            _startWork = startWork;
        }
        public Teacher(string fName, string lName, string sName, DateTime date, string institution, string specialization, string[] groupsName, DateTime startWork) : base(fName, lName, sName, date, institution, specialization)
        {
            _groupsName = new string[groupsName.Length];
            for (int i=0; i<groupsName.Length; i++)
            {
               _groupsName[i] = groupsName[i]; 
            }
            _startWork = startWork;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("Имя: "); sb.Append(_firstName); sb.Append("\n");
            sb.Append("Фамилия: "); sb.Append(_lastName); sb.Append("\n");
            sb.Append("Дата рождения: "); sb.Append(_birthDate.ToShortDateString()); sb.Append("\n");
            sb.Append("Преподаю в: "); sb.Append(_institution); sb.Append("\n");
            sb.Append("Преподаю в группе(группах):\n");
            for(int i=0; i<_groupsName.Length; i++)
            {
                sb.Append(_groupsName[i]);
                sb.Append(", ");
            }
            sb.Append("\n");
            sb.Append("Дата поступления на работу: "); sb.Append(_startWork.ToShortDateString());
            sb.Append("\n");
            return sb.ToString();
        }

    }
}
