using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class JuniorResearchAssistant:Specialist
    {

        protected string _scientificWork { set; get; }
        protected string _scientificSupervisor { set; get; }
        public JuniorResearchAssistant(string fName, string lName, DateTime date, string qualification, int salary, string scientificWork, string scientificSupervisor, string experience, DateTime startWork) : base(fName, lName, date, qualification, salary, experience, startWork)
        {
            _scientificWork = scientificWork;
            _scientificSupervisor = scientificSupervisor;
        }

        public override string ToString()
        {

            return $"{base.ToString()}Научная работа: {_scientificWork}\nНаучный руководитель: {_scientificSupervisor}\n";
        }
    }
}
