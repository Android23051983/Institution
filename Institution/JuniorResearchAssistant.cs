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
        public JuniorResearchAssistant(string fName, string lName, DateTime date, DateTime startWork, string qualification, string scientificWork, string scientificSupervisor) : base(fName, lName, date, startWork, qualification)
        {
            _scientificWork = scientificWork;
            _scientificSupervisor = scientificSupervisor;
        }

        public override string ToString()
        {

            return $"{base.ToString()}\n";
        }
    }
}
