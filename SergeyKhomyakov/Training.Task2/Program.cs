using System;

namespace Training.Task2
{
    class Program
    {
        private static int СheckInputNumber()
        {
            var stringNumber = string.Empty;
            int number = 0;

            stringNumber = Console.ReadLine();

            while (!int.TryParse(stringNumber, out number) || number < 0)
            {
                if (number <= 0)
                {
                    Console.WriteLine("Enter a positive number !");
                }
                else 
                {
                    Console.WriteLine("I do not understand what you entered :(((");
                }             
                Console.WriteLine();

                Console.Write("Insert the number: ");
                stringNumber = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        private static string CheckInputWordOnNull() 
        {
            string str = string.Empty;

            while (true) 
            {
                str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Row is empty !!");
                    Console.Write("Enter the string - ");
                }
                else 
                {
                    break;
                }
            }         
            return str;
        }
        private static void ShowRound() 
        {
            Console.Write("Enter the coordinate Х - ");
            int x = СheckInputNumber();
            Console.Write("Enter the coordinate Y - ");
            int y = СheckInputNumber();
            Console.Write("Enter radius R - ");
            int r = СheckInputNumber();
            Round round = new Round(x,y,r);
            round.ShowRound();
        }
        private static void ShowTriangle() 
        {
            Console.Write("Enter side A - ");
            int a = СheckInputNumber();
            Console.Write("Enter side B - ");
            int b = СheckInputNumber();
            Console.Write("Enter side C - ");
            int c = СheckInputNumber();
            Triangle triangle = new Triangle(a,b,c);
            triangle.ShowTriangle();
        }
        private static void ShowUser() 
        {
            Console.Write("Enter last name - ");
            string lastName = CheckInputWordOnNull();
            Console.Write("Enter your name - ");
            string firstName = CheckInputWordOnNull();
            Console.Write("Enter middle name - ");
            string middleName = CheckInputWordOnNull();
            Console.Write("Enter date of birth - ");
            DateTime birthOfDate;
            while(true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out birthOfDate)) 
                {
                    break;
                }
                Console.Write("Enter date of birth { Day Month Year} : ");
            }
            User user = new User(lastName,firstName,middleName, birthOfDate);
            user.ShowUser();
        }
        private static void ShowWorkWithMyString() 
        {
            Console.WriteLine("Enter the first line");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Enter the second line");
            string secondLine = Console.ReadLine();
            MyString myString = new MyString(firstLine);
            Console.WriteLine($"Joined two lines: {myString.Concat(firstLine,secondLine)}");
            Console.WriteLine($"Compare two strings {myString.Equals(firstLine,secondLine)}");
        }
        private static void ShowEmployee() 
        {
            Console.Write("Enter last name - ");
            string lastName = CheckInputWordOnNull();
            Console.Write("Enter your name - ");
            string firstName = CheckInputWordOnNull();
            Console.Write("Enter middle name - ");
            string middleName = CheckInputWordOnNull();
            Console.Write("Enter date of birth - ");
            int age = СheckInputNumber();
            Console.WriteLine("Enter your position");
            string position = CheckInputWordOnNull();
            Console.WriteLine("Enter your work experience");
            int workExperience = СheckInputNumber();
            DateTime birthOfDate;
            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out birthOfDate))
                {
                    break;
                }
                Console.Write("Enter date of birth { Day Month Year} : ");
            }
            var employee = new Employee(lastName,firstName,middleName, birthOfDate, workExperience,position);
            employee.ShowUser();
        }
        private static void ShowRing() 
        {
            Console.Write("Enter the coordinate Х - ");
            int x = СheckInputNumber();
            Console.Write("Enter the coordinate Y - ");
            int y = СheckInputNumber();
            Console.Write("Enter outer radius R - ");
            int r = СheckInputNumber();
            Console.Write("Enter the inner radius R - ");
            int interiorR = СheckInputNumber();
            var ring = new Ring(x,y,r,interiorR);
            ring.ShowRound();
        }
        static void Main(string[] args)
        {
            string[] menuTask = new string[] { "1 - ROUND", "2 - TRIANGLE", "3 - USER", "4 - MY STRING", "5 - EMPLOYEE", "6 - RING", "7 - VECTOR GRAPHICS EDITOR", "8 - GAME", "0 - EXIT"};
            bool isExit = false;
            int numberTask = 0;
            while (!isExit) 
            {
                Console.WriteLine("********************************");
                foreach (var task in menuTask)
                {
                    Console.WriteLine(task);
                }
                Console.WriteLine("********************************");
                Console.Write("Задание № ");
                numberTask = СheckInputNumber();
                switch (numberTask) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        ShowRound();
                        break;
                    case 2:
                        ShowTriangle();
                        break;
                    case 3:
                        ShowUser();
                        break;
                    case 4:
                        ShowWorkWithMyString();
                        break;
                    case 5:
                        ShowEmployee();
                        break;
                    case 6:
                        ShowRing();
                        break;
                }
            }
        }
    }
}
