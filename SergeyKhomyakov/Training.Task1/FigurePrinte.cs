using System;

namespace Training.Task1
{
    class FigurePrinte
    {
        /// <summary>
        /// Task 1.2. Show image of the "right side of the triangle"
        /// </summary>
        /// <param name=”height”>Triangle height </param>
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
        /// Task 1.3. Show Triangle
        /// </summary>
        /// <param name=”height”>Triangle height </param>
        public void ShowEquilateralTriangle(int height)
        {

            for (int i = 0; i < height + 1; i++) // line building 
            {
                for (int j = height; j != 0; j--) // building the left side  
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
                for (int j = 0; j != height; j++) // building the right side 
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
        /// Task 1.4. Show TriangleTree
        /// </summary>
        /// <param name=”countOfTriangle”>The number of triangles</param>
        public void ShowTriangleTree(int countOfTriangle)
        {
            for (int d = 0; d <= countOfTriangle; d++) // building the number of triangles
            {
                for (int i = 0; i <= d; i++) // line building
                {

                    for (int j = countOfTriangle; j != 0; j--) // building the left side 
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
                    for (int j = 0; j != countOfTriangle + 1; j++) // building the right side 
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
