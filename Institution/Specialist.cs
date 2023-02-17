using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institution
{
    internal class Specialist:Human
    {
        private readonly DateTime _startWork;
        protected string _qualification { get; set; }
        protected string _experience { get; set; }
        private readonly int _minimalSalary = 16242 ;
        protected int _salary { get; set; }

        public Specialist(string fName, string lName, DateTime date, DateTime startWork, string qualification, int salary, string experience) :base(fName, lName, date)
        {
           
            _qualification = qualification;
            _experience = experience;
            _salary = salary;
        } 
        public Specialist(string fName, string lName, string sName, DateTime date, DateTime startWork, string qualification) :base(fName, lName, sName, date)
        {
            //switch (specialization)
            //{
            //    case "Разработка Программного Обеспечения":
            //        _qualification = "Программист";
            //        break;
            //    case "WEB разработка Full-stack":
            //        _qualification = "WEB разработчик";
            //        break;
            //    case "Компьютерная Графика и Дизайн":
            //        _qualification = "Графический дизайнер";
            //        break;
            //    case "Сети и Кибербезопасность":
            //        _qualification = "Мастер по настройке компьютерных сетей";
            //        break;
            //}
            _qualification= qualification;
            DateTime dateTime = DateTime.Today;
            DateTime differenceDateTime = new DateTime((dateTime - startWork).Ticks);

            _experience = string.Format("{0} лет / {1} месяцев / {2} дней/", (differenceDateTime.Year - 1), (differenceDateTime.Month - 1), (differenceDateTime.Day - 1));

        }
        public Specialist(string fName, string lName, DateTime date, DateTime startWork, DateTime finishWork, string qualification) : base(fName, lName, date)
        {
        //    switch (specialization)
        //    {
        //        case "Разработка Программного Обеспечения":
        //            _qualification = "Программист";
        //            break;
        //        case "WEB разработка Full-stack":
        //            _qualification = "WEB разработчик";
        //            break;
        //        case "Компьютерная Графика и Дизайн":
        //            _qualification = "Графический дизайнер";
        //            break;
        //        case "Сети и Кибербезопасность":
        //            _qualification = "Мастер по настройке компьютерных сетей";
        //            break;
        //    }
            DateTime dateTime = DateTime.Today;
            DateTime differenceDateTime = new DateTime((dateTime - startWork).Ticks);

            _experience = string.Format("{0} лет / {1} месяцев / {2} дней/", (differenceDateTime.Year - 1), (differenceDateTime.Month - 1), (differenceDateTime.Day - 1));

        }
        public Specialist(string fName, string lName, string sName, DateTime date, DateTime startWork, DateTime finishWork, string qualification) :base(fName, sName, lName, date)
        {
            /*switch (specialization)
            {
                case "Разработка Программного Обеспечения":
                    _qualification = "Программист";
                    break;
                case "WEB разработка Full-stack":
                    _qualification = "WEB разработчик";
                    break;
                case "Компьютерная Графика и Дизайн":
                    _qualification = "Графический дизайнер";
                    break;
                case "Сети и Кибербезопасность":
                    _qualification = "Мастер по настройке компьютерных сетей";
                    break;
            }*/
            
            //DateTime dateTime = DateTime.Today;
            DateTime differenceDateTime = new DateTime((finishWork - startWork).Ticks);

            _experience = string.Format("{0} лет / {1} месяцев / {2} дней/", (differenceDateTime.Year - 1), (differenceDateTime.Month - 1), (differenceDateTime.Day - 1));

        }

        public Specialist(string fName, string lName, DateTime date, DateTime startWork, string qualification) : base(fName, lName, date)
        {
            //switch (specialization)
            //{
            //    case "Разработка Программного Обеспечения":
            //        _qualification = "Программист";
            //        break;
            //    case "WEB разработка Full-stack":
            //        _qualification = "WEB разработчик";
            //        break;
            //    case "Компьютерная Графика и Дизайн":
            //        _qualification = "Графический дизайнер";
            //        break;
            //    case "Сети и Кибербезопасность":
            //        _qualification = "Мастер по настройке компьютерных сетей";
            //        break;
            //}
            _qualification = qualification;
            DateTime dateTime = DateTime.Today;
            DateTime differenceDateTime = new DateTime((dateTime - startWork).Ticks);

            _experience = string.Format("{0} лет / {1} месяцев / {2} дней/", (differenceDateTime.Year-1), (differenceDateTime.Month-1),(differenceDateTime.Day-1));
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nКвалификация: {_qualification}\nОпыт работы(Стаж): {_experience} года(лет)\n";
        }
    }
}
