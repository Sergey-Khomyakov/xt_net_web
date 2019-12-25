using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureNumberString = string.Empty;
            int numberFigure = 0;
            bool isExit = false;
            string[] arraymenu = new string[] { "Choose a figure: ", "0 - Exit", "1 - Circle", "2 - Line", "3 - Ring", "4 - Circumference", "5 - Rectangle", "==================="};
            do
            {
                foreach (var item in arraymenu) 
                {
                    Console.WriteLine(item);
                }
                Console.Write("Figure - ");
                figureNumberString = Console.ReadLine();
                while (!int.TryParse(figureNumberString, out numberFigure) || numberFigure > 5)
                {
                    Console.WriteLine("No shape found ");
                    Console.Write("Figure - ");
                    figureNumberString = Console.ReadLine();
                }
                switch (numberFigure)
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Console.WriteLine("You have selected the Circle shape");
                        var myRound = new Round(new Point(5,5), 5.5);
                        myRound.ShowFigures();
                        break;
                    case 2:
                        Console.WriteLine("You have selected a line shape");
                        var myLine = new Line(new Point(3,4), new Point(5,5));
                        myLine.ShowFigures();
                        break;
                    case 3:
                        Console.WriteLine("You have selected the Ring shape");
                        var myRing = new Ring(new Point(4,5), 10,5);
                        myRing.ShowFigures();
                        break;
                    case 4:
                        Console.WriteLine("You have selected the Circle shape");
                        var myСircle = new Circle(new Point(3,3), 10);
                        myСircle.ShowFigures();
                        break;
                    case 5:
                        Console.WriteLine("You have selected a Rectangle shape");
                        var myRectangle = new Rectangle(new Point(5,5), new Point(5,10), new Point(10,5), new Point(10,10));
                        myRectangle.ShowFigures();
                        break;
                }
            } while (!isExit);
        }
    }
}
