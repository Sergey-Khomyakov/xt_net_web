using System;
using System.Text.RegularExpressions;

namespace Training.Task7
{
    class Program
    {
        /// <summary>
        /// Task 7.1 Сheck in the date text in the format dd-mm-yyyy
        /// </summary>
        /// <param name="txt">Enter text</param>
        private static void FindingDateTimeInText(string txt) 
        {
            string pattern = @"\b(?<day>\d{1,2})-(?<month>\d{1,2})-(?<year>\d{2,4})\b";
            var res = Regex.IsMatch(txt, pattern);
            if (res) 
            {
                Console.WriteLine($"In the text '{txt}' contains date");
            }
            else
            {
                Console.WriteLine("There is no date in the text");
            }
        }

        /// <summary>
        /// Task 7.2 HTML tags in text underline
        /// </summary>
        /// <param name="txt">Enter text</param>
        private static void ChangeHTMLtags(string txt) 
        {
            string pattern = @"\<.+?\>";
            var res = Regex.Replace(txt, pattern, "_");

            Console.WriteLine($"Resuld change: {res}");
        }

        /// <summary>
        /// Task 7.3 Check email in text
        /// </summary>
        /// <param name="txt">Enter text</param>
        private static void CheckEmailInText(string txt) 
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            var res = Regex.Matches(txt, pattern);
            foreach (var item in res)
            {
                Console.WriteLine($"Email: {item}");
            }
        }
        /// <summary>
        /// Task 7.4 Сhecking the number for format
        /// </summary>
        /// <param name="txt">Enter text</param>
        private static void CheckNumberFormat(string txt) 
        {
            var regularNotation = @"\b-*[0-9,\.]+\b";
            var scientificNotation = @"-?[\d.]+(?:e-?\d+)?";

            if (Regex.IsMatch(txt, regularNotation))
            {
                Console.WriteLine("This number is in normal notation.");
            }
            else if (Regex.IsMatch(txt, scientificNotation)) 
            {
                Console.WriteLine("This number is in scientific notation.");
            }
            else
            {
                Console.WriteLine("This is not a number");
            }
        }

        /// <summary>
        /// Task 7.5 How many times in the text time occurs.
        /// </summary>
        /// <param name="txt">Enter text</param>
        private static void TimeCounter(string txt) 
        {
            var pattern = @"\b([0-1]?[0-9]|2[0-3]):[0-5][0-9]\b";
            var res = Regex.Matches(txt, pattern);
            Console.WriteLine($"Time in the text is present {res.Count} time");
        }
        private static void View() 
        {
            string[] array = new string[] { "1 - DATE EXISTANCE", "2 - HTML REPLACER", "3 - EMAIL FINDER", "4 - NUMBER VALIDATOR", "5 - TIME COUNTER" };
            var isFlag = false;
            int number = 0;
            string input = string.Empty;
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            do
            {
                Console.WriteLine("Enter number:");
                Console.Write(">");
                input = Console.ReadLine();
                while (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Enter number");
                    Console.Write(">");
                    input = Console.ReadLine();
                }
                switch (number)
                {
                    case 0:
                        isFlag = true;
                        break;
                    case 1:
                        Console.Write("Enter text containing a date in the format dd-mm-yyyy:");
                        input = Console.ReadLine();
                        FindingDateTimeInText(input);
                        break;
                    case 2:
                        Console.Write("Enter text: ");
                        input = Console.ReadLine();
                        ChangeHTMLtags(input);
                        break;
                    case 3:
                        Console.Write("Enter text: ");
                        input = Console.ReadLine();
                        CheckEmailInText(input);
                        break;
                    case 4:
                        Console.Write("Enter number: ");
                        input = Console.ReadLine();
                        CheckNumberFormat(input);
                        break;
                    case 5:
                        Console.Write("Enter text: ");
                        input = Console.ReadLine();
                        TimeCounter(input);
                        break;
                    default:
                        Console.WriteLine("Number not found !");
                        break;
                }
            } while (!isFlag);
        }
        static void Main(string[] args)
        {
            View();
        }
    }
}
