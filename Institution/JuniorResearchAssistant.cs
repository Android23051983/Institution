using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class JuniorResearchAssistant:Specialist
    {
        public JuniorResearchAssistant(string fName, string lName, DateTime date, DateTime startWork, string qualification) : base(fName, lName, date, startWork, qualification)
        { 
        
        }

        public override string ToString()
        {

            return $"{base.ToString()}\n";
        }
    }
}
