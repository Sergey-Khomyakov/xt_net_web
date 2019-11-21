using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_Basics
{
    class StringOperations
    {
        /// <summary>
        /// Task 1.6. Метод позволяет устанавливать и изменять начертание шрифта 
        /// </summary>
        public void GetFontAdjustment()
        {
            List<string> listFont = new List<string>();
            int number = 0;
            var stringNumber = string.Empty;
            Console.WriteLine($"Параметры надписи: None");
            while (true)
            {
                Console.WriteLine("Введите:");
                Console.WriteLine($"\t 1: Bold");
                Console.WriteLine($"\t 2: Italic");
                Console.WriteLine($"\t 3: Underline");
                stringNumber = Console.ReadLine();
                while (!int.TryParse(stringNumber, out number) || number > 3) // Проверка ввода 
                {
                    Console.WriteLine("Введите существующее число !");
                    stringNumber = Console.ReadLine();
                }
                if (number == 0)
                {
                    break;
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            {
                                if (listFont.Count(x => x == "Bold") >= 1)
                                {
                                    listFont.Remove("Bold");
                                }
                                else
                                {
                                    listFont.Add("Bold");
                                }

                                break;
                            }
                        case 2:
                            {
                                if (listFont.Count(x => x == "Italic") >= 1)
                                {
                                    listFont.Remove("Italic");
                                }
                                else
                                {
                                    listFont.Add("Italic");
                                }

                                break;
                            }
                        case 3:
                            {
                                if (listFont.Count(x => x == "Underline") >= 1)
                                {
                                    listFont.Remove("Underline");
                                }
                                else
                                {
                                    listFont.Add("Underline");
                                }

                                break;
                            }
                    }
                    Console.Write($"Параметры надписи: ");
                    foreach (var list in listFont)
                    {
                        Console.Write(list + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Если хотите выйти из программы введите число 0");
                    number = 0;
                }

            }
        }

        /// <summary>
        /// Task 1.11 Метод выводи среднюю длину слова во введённой текстовой строке
        /// </summary>
        /// <param name="textString"> текстовая строка</param>
        public void GetAverageWordLength(string textString) 
        {                      
            textString = CheckTextForPunctuation(textString);
            string[] stringarray = textString.Split();
            int sum = SumOfLengthsAllWords(stringarray);
            Console.WriteLine($"Средняя длина = {sum / stringarray.Length}");
        }

        private string CheckTextForPunctuation(string textString) 
        {
            var text = new StringBuilder();

            foreach (char txt in textString)
            {
                if (!char.IsPunctuation(txt) && !char.IsNumber(txt) && !char.IsSymbol(txt))
                {
                    text.Append(txt);
                }
            }
            return text.ToString();
        }

        private int SumOfLengthsAllWords(string[] array)
        {   
            int sum = 0;        
            foreach (var line in array)
            {
                sum += line.Length;
            }
            return sum;
        }
        /// <summary>
        /// Task 1.12 Метод удваивает в первой введённой строке все символы, принадлежащие второй введённой строке
        /// </summary>
        /// <param name="firstLine">Первая строка</param>
        /// <param name="secondLine">Вторая строка</param>
        public void GetCharDoubler(string firstLine, string secondLine) 
        {
            var firstCharArray = firstLine.ToCharArray();
            var secondCharArrray = secondLine.ToCharArray();

            string resultString = CharDoublerInString(firstCharArray, secondCharArrray);

            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(resultString);
        }

        private string CharDoublerInString(char[] firstCharArray, char[] secondCharArrray)
        {
            string resultString = string.Empty;

            for (int i = 0; i < firstCharArray.Length; i++)
            {
                for (int j = 0; j < secondCharArrray.Length; j++)
                {
                    if (firstCharArray[i] == secondCharArrray[j] && 
                        (!char.IsPunctuation(secondCharArrray[j]) && !char.IsNumber(secondCharArrray[j]) && !char.IsWhiteSpace(secondCharArrray[j])))
                    {
                        resultString += secondCharArrray[j];
                        break;
                    }
                }
                resultString += firstCharArray[i];
            }
            return resultString;
        }

    }
}
