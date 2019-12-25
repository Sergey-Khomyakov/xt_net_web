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

        public virtual void ShowUser()
        {
            Console.WriteLine($"Hello !! \n{_lastName} {_firstName} {_middleName} \nYou were born {_birthOfDate.ToString("dd.MM.yyyy")} year, now you {Age}");
        }

        private int Age 
        {
            get 
            {
                return DateTime.Now.Year - _birthOfDate.Year;
            }
        }

    }
}
