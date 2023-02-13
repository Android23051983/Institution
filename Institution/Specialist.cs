using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Specialist:Student
    {
        string _qualification;
        public Specialist(string fName, string lName, DateTime date, string institution, string gName, string qualification, string specialization) :base(fName, lName, date, institution, gName, specialization)
        {
            _qualification = qualification;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nКвалификация: {_qualification}\n\n";
        }
    }
}
