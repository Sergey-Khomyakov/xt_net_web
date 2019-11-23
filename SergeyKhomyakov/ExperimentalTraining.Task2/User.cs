using System;

namespace ExperimentalTraining.Task2
{
    class User
    {
        private string LastName { get; set; } // Фамилия
        private string FirstName { get; set; } // Имя
        private string MiddleName { get; set; } // Отчество       
        private int Age { get; set; }  // Возраст

        public User(string lastname, string firstname, string middlename, int age)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.Age = age;
        }
        public void ShowUser()
        {
            int dateOfBirth = DateTime.Now.Year - Age;
            Console.WriteLine($"Здравствуйте !! \n{LastName} {FirstName} {MiddleName} \nВы родились в {dateOfBirth} году, сейчас вам {Age}");
        }
    }
}
