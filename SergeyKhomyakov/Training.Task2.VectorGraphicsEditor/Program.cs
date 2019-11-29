using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureNumberString = string.Empty;
            int numberFigure;
            bool isExit = false;
            string[] arraymenu = new string[] {"Выберите фигру: ", "0 - Выход", "1 - Круг", "2 - Линия", "3 - Кольцо", "4 - Окружность", "5 - Прямоугольник", "==================="};
            do
            {
                foreach (var item in arraymenu) 
                {
                    Console.WriteLine(item);
                }
                Console.Write("Фигура - ");
                figureNumberString = Console.ReadLine();
                while (!int.TryParse(figureNumberString, out numberFigure) || numberFigure > 5)
                {
                    Console.WriteLine("Фигура не найдена ");
                    Console.Write("Фигура - ");
                    figureNumberString = Console.ReadLine();
                }
                switch (numberFigure)
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Console.WriteLine("Вы выбрали фигуру Круг");
                        var myRound = new Round(new Point(5,5), 5.5);
                        myRound.ShowFigures();
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали фигуру Линию");
                        var myLine = new Line(new Point(3,4), new Point(5,5));
                        myLine.ShowFigures();
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали фигуру Кольцо");
                        var myRing = new Ring(new Point(4,5), 10,5);
                        myRing.ShowFigures();
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали фигуру Окружность");
                        var myСircle = new Circle(new Point(3,3), 10);
                        myСircle.ShowFigures();
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали фигуру Прямоугольник");
                        var myRectangle = new Rectangle(new Point(5,5), new Point(5,10), new Point(10,10), new Point(10,5));
                        myRectangle.ShowFigures();
                        break;
                }
            } while (!isExit);
        }
    }
}
