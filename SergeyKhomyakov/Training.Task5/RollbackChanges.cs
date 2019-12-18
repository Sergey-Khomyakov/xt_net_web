using System;

namespace Training.Task5
{
    class RollbackChanges
    {
        private DateTime _dateTime;
        private string _path;
        public RollbackChanges(string path) 
        {
            _path = path;
        }
        public void Start()
        {
            Console.WriteLine("Enter the date and time the file was rolled back in the format: {0:g}", new DateTime(2008, 1, 7, 15, 12, 30));
            Console.Write(">");
            while (!DateTime.TryParse(Console.ReadLine(), out _dateTime))
            {
                Console.WriteLine("Enter the date and time correctly!!!");
                Console.Write(">");
            }
        }
    }
}
