using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Human
    {

        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        protected readonly string _secondName;
        protected DateTime _birthDate { get; set; }

        public Human(string fName, string lName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _secondName = " - ";
            _birthDate = date;
        }

        public Human(string fName, string lName, string sName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _secondName = sName;
            _birthDate = date;
        }
        public Human() { }

        //Form1 form1 = Application.OpenForms[0] as Form1;
        public override string ToString()
        {

            return $"\nФамилия: {_lastName} \nИмя: {_firstName} \nОтчество: {_secondName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }
    }
}
