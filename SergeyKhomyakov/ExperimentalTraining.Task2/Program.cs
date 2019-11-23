using System;

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
                }
            }
        }
    }
}
