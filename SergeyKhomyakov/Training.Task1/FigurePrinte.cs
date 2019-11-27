using System;

namespace Training.Task1
{
    class FigurePrinte
    {
        /// <summary>
        /// Task 1.2. Метод выводит на консоль изображение "правой стороны треугольника"
        /// </summary>
        /// <param name=”height”>Высота треугольника </param>
        public void ShowRightTriangle(int height)
        {
            for (int i = 0; i < height + 1; i++)
            {
                for (int j = 0; j != i; j++)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Task 1.3. Метод выводит на консоль изображение "Треугольника"
        /// </summary>
        /// <param name=”height”>Высота треугольника </param>
        public void ShowEquilateralTriangle(int height)
        {

            for (int i = 0; i < height + 1; i++) // построение строк 
            {
                for (int j = height; j != 0; j--) // построение левой части  
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 0; j != height; j++) // построение правой части 
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Task 1.4. Метод выводит на консоль изображение "Елки"
        /// </summary>
        /// <param name=”countOfTriangle”>Количество треугольников</param>
        public void ShowTriangleTree(int countOfTriangle)
        {
            for (int d = 0; d <= countOfTriangle; d++) // построение количество треугольников 
            {
                for (int i = 0; i <= d; i++) // построение строк 
                {

                    for (int j = countOfTriangle; j != 0; j--) // построение левой части  
                    {
                        if (j <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    for (int j = 0; j != countOfTriangle + 1; j++) // построение правой части 
                    {
                        if (j <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
