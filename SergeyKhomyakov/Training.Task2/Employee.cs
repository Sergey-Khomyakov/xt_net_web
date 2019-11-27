using System;

namespace Training.Task2
{
    internal class Employee : User
    {
        private int _workExperience;
        private string _position;
        public Employee(string lastname, string firstname, string middlename, DateTime birthOfDate, int workExperience,string position) 
            : base(lastname, firstname, middlename, birthOfDate)
        {
            this._workExperience = workExperience;
            this._position = position;
        }

        private int WorkExperience 
        {
            get { return _workExperience; }
            set 
            {
                if (value >= 0 && value < 99) 
                {
                    _workExperience = value;
                }
            }
        }
        public override void ShowUser()
        {
            base.ShowUser();
            Console.WriteLine($"Ваш стаж работы {_workExperience} \nВаша должность {_position}");
        }

    }
}
