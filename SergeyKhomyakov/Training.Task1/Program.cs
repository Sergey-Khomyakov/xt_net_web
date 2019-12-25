using System;

namespace Training.Task1
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
                if (number < 0)
                {
                    Console.WriteLine("You entered a negative number");
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
        private static void ShowRectangle() 
        {                        
            Console.WriteLine("Enter width");
            int width = СheckInputNumber();
            Console.WriteLine("Enter length");
            int heigth = СheckInputNumber();
            NumberOperations rectangle = new NumberOperations();
            rectangle.ShowAreaOfRectangel(width, heigth);
            Console.WriteLine();

        }
        private static void ShowTriangle() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            FigurePrinte rightTriangle = new FigurePrinte();
            rightTriangle.ShowRightTriangle(number);
            Console.WriteLine();
        }
        private static void ShowAnotherTriangle() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            FigurePrinte triangle = new FigurePrinte();
            triangle.ShowEquilateralTriangle(number);
            Console.WriteLine();
        }
        private static void ShowXMasTree() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            FigurePrinte tree = new FigurePrinte();
            tree.ShowTriangleTree(number);
            Console.WriteLine();
        }
        private static void ShowSumOfNumbers() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            NumberOperations sumOfNumbers = new NumberOperations();
            Console.WriteLine($"Amount = {sumOfNumbers.GetSumOfNumbersMultiplesOf(number, new int[] { 3, 5 })}");
            Console.WriteLine();
        }

        private static void ShowFontAdjustment() 
        {
            StringOperations fontAdjustment = new StringOperations();
            fontAdjustment.ShowFontAdjustment();
            Console.WriteLine();
        }
        private static void ShowArrayProcessing() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            ArrayOperations array = new ArrayOperations();
            array.ShowArray(number);
            Console.WriteLine();
        }
        private static void ShowNoPositive() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            ArrayOperations array1 = new ArrayOperations();
            array1.ShowNoPositiveNumbersInArray(number);
            Console.WriteLine();
        }

        private static void ShowNonNegativeSum() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            ArrayOperations array2 = new ArrayOperations();
            array2.ShowSumOfNonNegativeElementsInArray(number);
            Console.WriteLine();
        }
        private static void ShowTwoDArray() 
        {
            Console.Write("Insert the number: ");
            int number = СheckInputNumber();
            ArrayOperations array3 = new ArrayOperations();
            array3.ShowSumEvenPositionsInArray(number);
            Console.WriteLine();
        }
        private static void ShowAverageStringLength() 
        {
            Console.Write("Enter the string: ");
            string textLine = Console.ReadLine();
            StringOperations stringOperations = new StringOperations();
            stringOperations.ShowAverageWordLength(textLine);
            Console.WriteLine();
        }
        private static void ShowCharDoubler() 
        {
            Console.Write("Enter the first line: ");
            string firstLine = Console.ReadLine();
            Console.Write("Enter the second line: ");
            string secondLine = Console.ReadLine();
            StringOperations stringOperations1 = new StringOperations();
            stringOperations1.ShowCharDoubler(firstLine,secondLine);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int number = 0;
            int numberTask = 0;
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
                Console.Write("The task № ");
                numberTask = СheckInputNumber();
                switch (numberTask) 
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        ShowRectangle();
                        break;
                    case 2:
                        ShowTriangle();
                        break;
                    case 3:
                        ShowAnotherTriangle();
                        break;
                    case 4:
                        ShowXMasTree();
                        break;
                    case 5:
                        ShowSumOfNumbers();
                        break;
                    case 6:
                        ShowFontAdjustment();
                        break;
                    case 7:
                        ShowArrayProcessing();
                        break;
                    case 8:
                        ShowNoPositive();
                        break;
                    case 9:
                        ShowNonNegativeSum();
                        break;
                    case 10:
                        ShowTwoDArray();
                        break;
                    case 11:
                        ShowAverageStringLength();
                        break;
                    case 12:
                        ShowCharDoubler();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
