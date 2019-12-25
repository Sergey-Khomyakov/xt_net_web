using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.Task1
{
    class StringOperations
    {
        /// <summary>
        /// Task 1.6. Set and change the font style
        /// </summary>
        public void ShowFontAdjustment()
        {
            List<string> listFont = new List<string>();
            int number = 0;
            var stringNumber = string.Empty;
            Console.WriteLine($"Label Options: None");
            while (true)
            {
                Console.WriteLine("Enter:");
                Console.WriteLine($"\t 1: Bold");
                Console.WriteLine($"\t 2: Italic");
                Console.WriteLine($"\t 3: Underline");
                stringNumber = Console.ReadLine();
                while (!int.TryParse(stringNumber, out number) || number > 3)
                {
                    Console.WriteLine("Enter an existing number !");
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
                    Console.Write($"Label options: ");
                    foreach (var list in listFont)
                    {
                        Console.Write(list + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("If you want to exit the program, enter the number 0");
                    number = 0;
                }

            }
        }

        /// <summary>
        /// Task 1.11 Print the average word length in the entered text string
        /// </summary>
        /// <param name="textString"> text string</param>
        public void ShowAverageWordLength(string textString) 
        {                      
            textString = CheckTextForPunctuation(textString);
            string[] stringarray = textString.Split();
            int sum = SumOfLengthsAllWords(stringarray);
            Console.WriteLine($"Средняя длина = {sum / stringarray.Length}");
        }

        /// <summary>
        /// Task 1.12 Doubles in the first line entered all characters belonging to the second line entered
        /// </summary>
        /// <param name="firstLine">First line</param>
        /// <param name="secondLine">Second line</param>
        public void ShowCharDoubler(string firstLine, string secondLine)
        {
            var line = new StringBuilder();

            foreach (var ch in firstLine) 
            {
                line.Append(ch);
                if (!char.IsPunctuation(ch) && !char.IsSeparator(ch)) 
                {
                    line.Append(ch);
                }               
            }
            Console.WriteLine(line);
        }

        private string CheckTextForPunctuation(string textString) 
        {
            var text = new StringBuilder(textString.Length);

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
    }
}
