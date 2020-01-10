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
        private IAwardLogic _awardLogic = DependencyResolver.AwardLogic;
        private IUserAndAwardLogic _userawardLogic = DependencyResolver.UserAwardLogic;

        /// <summary>
        /// Show User Interface
        /// </summary>
        public void Start()
        {
            ShowMenu();          
        }
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************************************");
            Console.WriteLine("** Welcome to the database of the game 'World of Tanks' **");
            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            int inputnumber;
            do
            {            
                Console.WriteLine("Menu:");
                Console.WriteLine("0 - Exite");
                Console.WriteLine("1 - User");
                Console.WriteLine("2 - Award");
                Console.WriteLine("=============");
                Console.WriteLine("Input number:");
                Console.Write(">");
                inputnumber = GetUserInputId();
                switch (inputnumber)
                {
                    case 0:
                        Console.WriteLine("See you later !");
                        break;
                    case 1:
                        ShowUserMenu();
                        break;
                    case 2:
                        ShowAwardMenu();
                        break;
                    default:
                        Console.WriteLine("number not found");
                        break;
                }
            } while (inputnumber != 0);
        }

        #region Task 6.1 User
        private void ShowUserMenu() 
        {
            int inputnumber;
            do
            {            
                Console.WriteLine("0 - Exite");
                Console.WriteLine("1 - Show Users");
                Console.WriteLine("2 - Add Users");
                Console.WriteLine("3 - Delete User ");
                Console.WriteLine("4 - Add rewards to user");
                Console.WriteLine("5 - Remove user rewards");
                Console.WriteLine("=============");
                Console.WriteLine("Input number:");
                Console.Write(">");
                inputnumber = GetUserInputId();
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
                    case 4:
                        AddAdwardUser();
                        break;
                    case 5:
                        DeleteAdwardUser();
                        break;
                    default:
                        Console.WriteLine("number not found");
                        break;
                }
            } while (inputnumber != 0);
        }
        private void ShowAllUser() 
        {
            var users = _userLogic.GetAll().ToList();

            if (users.Count == 0)
            {
                Console.WriteLine("base is empty");
            }
            else 
            {
                foreach (var item in users)
                {
                    Console.WriteLine("==============================================");
                    Console.WriteLine($"Id: {item.Id}\nUser: {item.Name}\nDate of birgh: {item.DateOfBirth.ToString("MM/dd/yyyy")}\nAge: {item.Age}");
                    Console.Write("Award: ");

                    var titles = from awardUser in _userawardLogic.GetAllAwardUser(item.Id)
                                 join award in _awardLogic.GetAll() on awardUser.AwardId equals award.Id
                                 select(award.Title);

                    foreach (var award in titles)
                    {
                        Console.Write($"{award} ");
                    }
                    Console.WriteLine();
                }
            }
        }        
        private void AddUser()
        {            
            Console.WriteLine("Enter Name");
            Console.Write(">");
            var name = GetUserInput();

            var idAdd = _userLogic.Add(new Entity.User()
            {
                Name = name,
                DateOfBirth = GetDateOfBirth(),
                
            });
            Console.WriteLine($"User Add id: {idAdd}");
        }
        private void DeleteUser() 
        {
            Console.WriteLine("Enter Id user");
            Console.Write(">");
            var id = GetUserInputId();

            if (IsCheckUserInBase(id)) 
            {
                _userLogic.DeleteById(id);
                _userawardLogic.DeleteUser(id);
            }

        }
        private bool IsCheckUserInBase(int userId)
        {
            var users = _userLogic.GetAll().ToList();

            foreach (var item in users)
            {
                if (item.Id == userId)
                {                   
                    return true;
                }
            }
            Console.WriteLine("This user is not in the database");
            return false;
        }
        #endregion

        #region Task 6.2 Award
        private void ShowAwardMenu() 
        {
            int inputnumber;
            do
            {           
                Console.WriteLine("0 - Exite");
                Console.WriteLine("1 - Show Award");            
                Console.WriteLine("2 - Add Award");
                Console.WriteLine("3 - Delete Award");
                Console.WriteLine("=============");
                Console.WriteLine("Input number:");
                Console.Write(">");
                inputnumber = GetUserInputId();
                switch (inputnumber)
                {
                    case 0:
                        Console.WriteLine("See you later !");
                        break;
                    case 1:
                        ShowAllAward();
                        break;
                    case 2:
                        AddAward();
                        break;
                    case 3:
                        DeleteAward();
                        break;
                    default:
                        Console.WriteLine("number not found");
                        break;
                }
            } while (inputnumber != 0);
        }
        private void ShowAllAward() 
        {
            var awards = _awardLogic.GetAll().ToList();

            if (awards.Count() == 0)
            {
                Console.WriteLine("base is empty");
            }
            else
            {
                foreach (var item in awards)
                {
                    Console.WriteLine($"Id: {item.Id}\nTitle: {item.Title}");
                }
            }
        }
        private void AddAward() 
        {
            Console.WriteLine("Enter Award");
            Console.Write(">");
            var title = GetUserInput();

            _awardLogic.Add(new Award()
            {
                Title = title
            });
        }    
        private void DeleteAward()
        {
            Console.WriteLine("Enter Id award");
            Console.Write(">");
            var id = GetUserInputId();

            if (IsCheckAwardInBase(id)) 
            {
                _awardLogic.DeleteById(id);
            }
        }
        private bool IsCheckAwardInBase(int awardId)
        {
            var awards = _awardLogic.GetAll().ToList();

            foreach (var item in awards)
            {
                if (item.Id == awardId)
                {
                    return true;
                }
            }
            Console.WriteLine("This award is not in the database");
            return false;
        }
        #endregion

        #region CheckInputUser
        /// <summary>
        /// Check User Input UserId and AwardId
        /// </summary>
        /// <returns></returns>
        private int GetUserInputId() 
        {
            string userId = Console.ReadLine();
            var id = 0;
            while (!int.TryParse(userId,out id))
            {
                Console.WriteLine("Enter Id");
                Console.Write(">");
                userId = Console.ReadLine();
            }
            return id;
        }
        /// <summary>
        /// Check User Input UserName and AwardTitle
        /// </summary>
        /// <returns></returns>
        private string GetUserInput() 
        {
            string userInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("String Empty !!");
                Console.Write(">");
                userInput = Console.ReadLine();
            }
            return userInput;
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
        #endregion

        #region Helper (many to many)
        private void AddAdwardUser() 
        {
            ShowAllAward();

            Console.WriteLine("Enter id User");
            Console.Write(">");
            var userId = GetUserInputId();

            if (_userLogic.GetAll().Where(n => n.Id == userId).Count() == 0)
            {
                Console.WriteLine("No such user !!");
            }
            else 
            {
                Console.WriteLine("Enter id Award");
                Console.Write(">");
                var awardId = GetUserInputId();   
            
                if (IsCheckUserAwardInBase(awardId,userId)) 
                {
                    _userawardLogic.AddUserRewards(userId, awardId);
                }    
            }    
        }
        private void DeleteAdwardUser()
        {
            Console.WriteLine("Enter id User");
            Console.Write(">");
            var userId = GetUserInputId();
            if (_userawardLogic.GetAllAwardUser(userId).Count() == 0)
            {
                Console.WriteLine("User has no rewards");
            }
            else 
            {
                Console.WriteLine("Enter id Award");
                Console.Write(">");
                var awardId = GetUserInputId();

                if (!IsCheckUserAwardInBase(awardId, userId)) 
                {
                    _userawardLogic.DeleteUserRewards(userId, awardId);
                }   
            }
        }        
        private bool IsCheckUserAwardInBase(int awardId, int userId) 
        {
            var userAward = _userawardLogic.GetAllAwardUser(userId).ToList();

            foreach (var item in userAward)
            {
                if (item.AwardId == awardId) 
                {
                    Console.WriteLine("The user has such an award.");
                    return false;
                }
            }
            return true;
        }
        #endregion

    }
}
