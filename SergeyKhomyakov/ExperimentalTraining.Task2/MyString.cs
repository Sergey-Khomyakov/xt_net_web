using System;

namespace ExperimentalTraining.Task2
{
    class MyString
    {
        /// <summary>
        /// Метод стравнивает две строки
        /// </summary>
        /// <param name="firstLine">первая строка</param>
        /// <param name="secondLine">вторая строка</param>
        /// <returns></returns>
        public bool Equals(string firstLine, string secondLine)
        {
            if (firstLine.Length != secondLine.Length)
            {
                return false;
            }
            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] != secondLine[i])
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод объединяет две строки 
        /// </summary>
        /// <param name="firstLine">первая строка</param>
        /// <param name="secondLine">вторая строка</param>
        /// <returns></returns>
        public string Concat(string firstLine, string secondLine)
        {
            string resultString = string.Empty;
            resultString = firstLine + secondLine;
            return resultString;
        }
        /// <summary>
        /// Метод преобразует массив символов в строку
        /// </summary>
        /// <param name="array">массив символов</param>
        /// <returns></returns>
        public string ConvetrToString(char[] array)
        {
            string str = string.Empty;
            for (int i = 0; i < array.Length - 1; i++)
            {
                str += array[i];
            }
            return str;
        }
        /// <summary>
        /// Метод преобразует строку в массив символов
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns></returns>
        public char[] ConvertToCharArray(string str)
        {
            char[] cha = new char[str.Length];
            for (int i = 0; i < cha.Length - 1; i++)
            {
                cha[i] = str[i];
            }
            return cha;
        }
        /// <summary>
        /// Метод поиска символа в строке, если не находит символ возвращает -1
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="ch">символ</param>
        /// <returns></returns>
        public int GetIndexOfChar(string str, char ch)
        {
            int index = 0;
            for (int i = 0; i < str.Length;)
            {
                if (str[i] == ch)
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
    }
}
    