using System;

namespace ExperimentalTraining.Task2
{
    internal class Employee : User
    {
        private int workExperience;
        private string Position;
        public Employee(string lastname, string firstname, string middlename, int age, int workExperience,string position) 
            : base(lastname, firstname, middlename, age)
        {
            this.workExperience = workExperience;
            this.Position = position;
        }

        private int WorkExperience 
        {
            get { return workExperience; }
            set 
            {
                if (value >= 0 && value < 99) 
                {
                    workExperience = value;
                }
            }
        }
        public override void ShowUser()
        {
            base.ShowUser();
            Console.WriteLine($"Ваш стаж работы {workExperience} \nВаша должность {Position}");
        }

    }
}
