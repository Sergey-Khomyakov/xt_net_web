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
            } while (!isExit);
        }
    }
}
