using System;

namespace Training.Task2
{
    class MyString
    {
        private char[] chararray;

        public MyString(string str) 
        {
            chararray = str.ToCharArray();
        }
        /// <summary>
        /// Compares two lines
        /// </summary>
        /// <param name="firstLine">First line</param>
        /// <param name="secondLine">second line</param>
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
        /// Concatenates two lines
        /// </summary>
        /// <param name="firstLine">First line</param>
        /// <param name="secondLine">second line</param>
        /// <returns></returns>
        public string Concat(string firstLine, string secondLine)
        {
            string resultString = string.Empty;
            resultString = firstLine + secondLine;
            return resultString;
        }
        /// <summary>
        /// Converts an array of characters to a string
        /// </summary>
        /// <param name="array">character array</param>
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
        /// Converts a string to an array of characters
        /// </summary>
        /// <param name="str">string</param>
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
        /// Looks for a character in a string, if it does not find a character returns -1
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="ch">Char</param>
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
    