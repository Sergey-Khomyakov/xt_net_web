using System;

namespace Training.Task5
{
    class File
    {
        public string NameFile { get; set; }
        public DateTime dateTime { get; set; }
        public string Text { get; set; }

        public File(string name, DateTime DateTime, string text) 
        {
            NameFile = name;
            dateTime = DateTime;
            Text = text;
        }
    }
}
