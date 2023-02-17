using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class JuniorResearchAssistantsAdd : JuniorResearchAssistant
    {

        internal static JuniorResearchAssistant[] juniorResearchAssistant = {
           new JuniorResearchAssistant("Иван", "Щербаков",
           new DateTime(1983, 5, 23), "Программист",11000, "Безопасность в интернете", "Масляков Максим Игнатьевич", "5",new DateTime(2000, 3, 1)),
           new JuniorResearchAssistant("Василий", "Комиссаров",
           new DateTime(1993, 7, 12), "Программист",11000,"Правила графического дизайна", "Минкин Семён Фёдорович", "3", new DateTime(2003, 5, 1))
        };

        public JuniorResearchAssistantsAdd(string fName, string lName, DateTime date, string qualification, int salary, string scientificWork, string scientificSupervisor, string experience, DateTime startWork) :base(fName, lName, date, qualification, salary, scientificWork, scientificSupervisor, experience, startWork)
        { 
        }

        public override string ToString() 
        {
            return $"{base.ToString()}";
        }
    }
}
