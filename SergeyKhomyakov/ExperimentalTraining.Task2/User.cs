using System;

namespace ExperimentalTraining.Task2
{
    class User
    {
        private string lastName;
        private string firstName;
        private string middleName;     
        private int age;

        public User(string LastName, string FirstName, string MiddleName, int Age)
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.middleName = MiddleName;
            this.age = Age;
        }

        private int Age 
        {
            get 
            {
                return age;
            }
            set
            {
                if (value >= 0 && value < 99) 
                {
                    age = value;
                }
            }
        }
        public virtual void ShowUser()
        {
            int dateOfBirth = DateTime.Now.Year - Age;
            Console.WriteLine($"Здравствуйте !! \n{lastName} {firstName} {middleName} \nВы родились в {dateOfBirth} году, сейчас вам {age}");
        }
    }
}
