﻿using System;

namespace ExperimentalTraining.Task2
{
    class Program
    {
        private static int СheckInputNumber()
        {
            var stringNumber = string.Empty;
            int number;

            stringNumber = Console.ReadLine();

            while (!int.TryParse(stringNumber, out number) || number < 0)
            {
                if (number < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число");
                }
                else
                {
                    Console.WriteLine("Я не понимаю что вы ввели :(((");
                }
                Console.WriteLine();

                Console.Write("Введите число: ");
                stringNumber = Console.ReadLine();
                Console.WriteLine();
            }
            return number;
        }
        private static void ShowRound() 
        {
            Console.Write("Введите координату Х - ");
            int x = СheckInputNumber();
            Console.Write("Введите координату Y - ");
            int y = СheckInputNumber();
            Console.Write("Введите радиус R - ");
            int r = СheckInputNumber();
            Round round = new Round(x,y,r);
            round.ShowRound();
        }
        private static void ShowTriangle() 
        {
            Console.Write("Введите сторону A - ");
            int a = СheckInputNumber();
            Console.Write("Введите сторону B - ");
            int b = СheckInputNumber();
            Console.Write("Введите сторону C - ");
            int c = СheckInputNumber();
            Triangle triangle = new Triangle(a,b,c);
            triangle.ShowTriangle();
        }
        private static void ShowUser() 
        {
            Console.Write("Введите фамилию - ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя - ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество - ");
            string middleName = Console.ReadLine();
            Console.Write("Введите возраст - ");
            int age = СheckInputNumber();
            User user = new User(lastName,firstName,middleName,age);
            user.ShowUser();
        }
        private static void ShowWorkWithMyString() 
        {
            Console.WriteLine("Введите первую строку");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string secondLine = Console.ReadLine();
            MyString myString = new MyString();
            Console.WriteLine($"Соединил две строки: {myString.Concat(firstLine,secondLine)}");
            Console.WriteLine($"Сравнение двух строк {myString.Equals(firstLine,secondLine)}");
        }
        private static void ShowEmployee() 
        {
            Console.Write("Введите фамилию - ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя - ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество - ");
            string middleName = Console.ReadLine();
            Console.Write("Введите возраст - ");
            int age = СheckInputNumber();
            Console.WriteLine("Введите вашу должность");
            string position = Console.ReadLine();
            Console.WriteLine("Введите ваш рабочий стаж");
            int workExperience = СheckInputNumber();
            var employee = new Employee(lastName,firstName,middleName,age,workExperience,position);
            employee.ShowUser();
        }
        private static void ShowRing() 
        {
            Console.Write("Введите координату Х - ");
            int x = СheckInputNumber();
            Console.Write("Введите координату Y - ");
            int y = СheckInputNumber();
            Console.Write("Введите внешний радиус R - ");
            int r = СheckInputNumber();
            Console.Write("Введите внутренний радиус R - ");
            int interiorR = СheckInputNumber();
            var ring = new Ring(x,y,r,interiorR);
            ring.ShowRound();
        }
        static void Main(string[] args)
        {
            string[] menuTask = new string[] { "1 - ROUND", "2 - TRIANGLE", "3 - USER", "4 - MY STRING", "5 - EMPLOYEE", "6 - RING", "7 - VECTOR GRAPHICS EDITOR", "8 - GAME", "0 - EXIT"};
            bool isExit = false;
            int numberTask;
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
