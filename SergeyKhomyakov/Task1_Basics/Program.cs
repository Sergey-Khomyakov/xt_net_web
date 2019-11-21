using System;

namespace Task1_Basics
{
    class Program
    {
        private static int NumberInputСheck()
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
        static void Main(string[] args)
        {
            int number, numberTask;
            bool isExit = false;
            string[] arrayTask = { "0 - EXIT","1 - RECTANGLE", "2 - TRIANGLE", "3 - ANOTHER TRIANGLE", "4 - X-MAS TREE",
                "5 - SUM OF NUMBERS", "6 - FONT ADJUSTMENT", "7 - ARRAY PROCESSING", "8 - NO POSITIVE", "9 - NON-NEGATIVE SUM", "10 - 2D ARRAY",
                "11 - AVERAGE STRING LENGTH", "12 - CHAR DOUBLER"};
            while(!isExit)
            {
                Console.WriteLine("********************************");
                foreach (var Task in arrayTask) 
                {
                    Console.WriteLine(Task);
                }
                Console.Write("Задание № ");
                numberTask = NumberInputСheck();
                switch (numberTask) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:      
                        
                        Console.WriteLine("Введите ширину");
                        int width = NumberInputСheck();
                        Console.WriteLine("Введите длину");
                        int heigth = NumberInputСheck();
                        NumberOperations rectangle = new NumberOperations();
                        Console.WriteLine(rectangle.GetAreaOfRectangel(width, heigth));
                        Console.WriteLine();
                        break;

                    case 2:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        FigurePrinte rightTriangle = new FigurePrinte();
                        rightTriangle.GetRightTriangle(number);
                        Console.WriteLine();
                        break;

                    case 3:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        FigurePrinte triangle = new FigurePrinte();
                        triangle.GetEquilateralTriangle(number);
                        Console.WriteLine();
                        break;

                    case 4:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        FigurePrinte tree = new FigurePrinte();
                        tree.GetTriangleTree(number);
                        Console.WriteLine();
                        break;

                    case 5:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        NumberOperations sumOfNumbers = new NumberOperations();
                        sumOfNumbers.GetSumOfNumbersMultiplesOfThreeOrFive(number);
                        Console.WriteLine();
                        break;

                    case 6:

                        StringOperations fontAdjustment = new StringOperations();
                        fontAdjustment.GetFontAdjustment();
                        Console.WriteLine();
                        break;

                    case 7:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        ArrayOperations array = new ArrayOperations();
                        array.GetArray(number);
                        Console.WriteLine();
                        break;

                    case 8:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        ArrayOperations array1 = new ArrayOperations();
                        array1.GetNoPositiveNumbersInArray(number);
                        Console.WriteLine();
                        break;

                    case 9:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        ArrayOperations array2 = new ArrayOperations();
                        array2.GetSumOfNonNegativeElementsInArray(number);
                        Console.WriteLine();
                        break;

                    case 10:

                        Console.Write("Введите число: ");
                        number = NumberInputСheck();
                        ArrayOperations array3 = new ArrayOperations();
                        array3.GetSumEvenPositionsInArray(number);
                        Console.WriteLine();
                        break;

                    case 11:

                        Console.Write("Введите строку: ");
                        string textLine = Console.ReadLine();
                        StringOperations stringOperations = new StringOperations();
                        stringOperations.GetAverageWordLength(textLine);
                        Console.WriteLine();
                        break;

                    case 12:

                        Console.Write("Введите первую строку: ");
                        string firstLine = Console.ReadLine();
                        Console.Write("Введите вторую строку: ");
                        string secondLine = Console.ReadLine();
                        StringOperations stringOperations1 = new StringOperations();
                        stringOperations1.GetCharDoubler(firstLine,secondLine);
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
