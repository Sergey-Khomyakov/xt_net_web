using System;

namespace Training.Task2.VectorGraphicsEditor
{
    class Program
    {
        private static void GetMenu()
        {
            Console.WriteLine("Выберите фигру: ");
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Линия");
            Console.WriteLine("3 - Кольцо");
            Console.WriteLine("4 - Окружность");
            Console.WriteLine("5 - Прямоугольник");
            Console.WriteLine("===================");
            Console.Write("Фигура - ");
        }
        static void Main(string[] args)
        {
            string figureNumberString = string.Empty;
            int numberFigure;
            do
            {
                GetMenu();
                figureNumberString = Console.ReadLine();
                while (!int.TryParse(figureNumberString, out numberFigure) || numberFigure > 5 || numberFigure == 0)
                {
                    Console.WriteLine("Фигура не найдена ");
                    Console.Write("Фигура - ");
                    figureNumberString = Console.ReadLine();
                }
                switch (numberFigure)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали фигуру Круг");
                        Round myRound = new Round();
                        myRound.GetСoordinates();
                        myRound.ShowFigures();
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали фигуру Линию");
                        Line myLine = new Line();
                        myLine.GetСoordinates();
                        myLine.ShowFigures();
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали фигуру Кольцо");
                        Ring myRing = new Ring();
                        myRing.GetСoordinates();
                        myRing.ShowFigures();
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали фигуру Окружность");
                        Сircle myСircle = new Сircle();
                        myСircle.GetСoordinates();
                        myСircle.ShowFigures();
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали фигуру Прямоугольник");
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.GetСoordinates();
                        myRectangle.ShowFigures();
                        break;
                }
            } while (true);
        }
    }
}
