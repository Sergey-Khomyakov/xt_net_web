using System;
using System.Collections.Generic;
using Training.Task6.Entity;
using Training.Task6.BLL;
using Training.Task6.Common;
using Training.Task6.BLL.Interfaces;
using System.Linq;

namespace Training.Task6.ConsolePL
{
    public class ViewUI
    {
        private IUserLogic _userLogic = DependencyResolver.UserLogic;

        /// <summary>
        /// Show User Interface
        /// </summary>
        public void Start()
        {
            ShowMenu();
            int inputnumber;
            do
            {
                Console.WriteLine("Input number:");
                Console.Write(">");
                inputnumber = GetCheckInputUser();
                switch (inputnumber)
                {
                    case 0:
                        Console.WriteLine("See you later !");
                        break;
                    case 1:
                        ShowAllUser();
                        break;
                    case 2:
                        AddUser();
                        break;
                    case 3:
                        DeleteUser();
                        break;
                }
            } while (inputnumber != 0);           
        }
        private int GetCheckInputUser()
        {
            string input = Console.ReadLine();
            int numberInput = 0;
            while (!int.TryParse(input,out numberInput) || numberInput > 3 || numberInput < 1)
            {
                Console.WriteLine("number not found");
                Console.Write(">");
                input = Console.ReadLine();
            }
            return numberInput;
        }
        private void DeleteUser() 
        {
            Console.WriteLine("Enter Id user");
            string idUsers = Console.ReadLine();
            var id = 0;
            while (!int.TryParse(idUsers,out id))
            {
                Console.WriteLine("Enter Id user");
                idUsers = Console.ReadLine();
            }
            _userLogic.DeleteById(id);
        }

        private void AddUser()
        {
            var idAdd = _userLogic.Add(new Entity.User()
            {
                Name = GetUserName(),
                DateOfBirth = GetDateOfBirth()        
            });
        }

        private string GetUserName() 
        {
            Console.WriteLine("Enter Name");
            string userName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userName) || string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Enter Name");
                userName = Console.ReadLine();
            }
            return userName;
        }
        private DateTime GetDateOfBirth() 
        {
            DateTime dateTime;
            Console.WriteLine("Enter date of birth (mm/dd/yyyy): {0:d}", new DateTime(2008, 1, 7));
            Console.Write(">");
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.WriteLine("Enter the date and time correctly!!!");
                Console.Write(">");
            }
            return dateTime;
        }
        private void ShowAllUser() 
        {
            if (_userLogic.GetAll().Count() == 0)
            {
                Console.WriteLine("base is empty");
            }
            else 
            {
                foreach (var item in _userLogic.GetAll())
                {
                    Console.WriteLine($"Id: {item.Id}, User: {item.Name}, Date of birgh: {item.DateOfBirth.ToString("MM/dd/yyyy")}, Age: {item.Age}");
                }
            }
        }
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************************************");
            Console.WriteLine("** Welcome to the database of the game 'World of Tanks' **");
            Console.WriteLine("**********************************************************");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("0 - Exite");
            Console.WriteLine("1 - Show Users");
            Console.WriteLine("2 - Add Users");
            Console.WriteLine("3 - Delete User ");
            Console.WriteLine();
        }
    }
}
