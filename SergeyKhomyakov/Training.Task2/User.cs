using System;

namespace Training.Task2
{
    class User
    {
        private string _lastName;
        private string _firstName;
        private string _middleName;
        private DateTime _birthOfDate;

        public User(string LastName, string FirstName, string MiddleName, DateTime BirthOfDate)
        {
            this._lastName = LastName;
            this._firstName = FirstName;
            this._middleName = MiddleName;
            this._birthOfDate = BirthOfDate;
        }

        private int Age 
        {
            get 
            {
                return DateTime.Now.Year - _birthOfDate.Year;
            }
        }
        public virtual void ShowUser()
        {
            Console.WriteLine($"Здравствуйте !! \n{_lastName} {_firstName} {_middleName} \nВы родились {_birthOfDate.ToString("dd.MM.yyyy")} году, сейчас вам {Age}");
        }
    }
}
