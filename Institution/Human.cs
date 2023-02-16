using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Human
    {

        protected string _firstName { get; init; } = default;
        protected string _lastName { get; init; } = default;
        protected readonly string _secondName;
        protected DateTime _birthDate { get; init; }

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

        public override string ToString()
        {

            return $"\nФамилия: {_lastName} \nИмя: {_firstName} \nОтчество: {_secondName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }
    }
}
