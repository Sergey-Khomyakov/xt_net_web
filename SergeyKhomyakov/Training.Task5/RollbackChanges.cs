using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Training.Task5
{
    class RollbackChanges
    {
        private DateTime _dateTime;
        private string _path;
        private string _nameFile;
        private string _pathLog;
        private string _writeInFile;
        private List<File> _file;
        public RollbackChanges(string path) 
        {
            _path = path;
            _pathLog = path + @"\Log\Log.txt";           
        }
        public void Start()
        {
            _nameFile = GetNameFile();
            FileContent();
            DateTimeRollback();
            FileRollBack();
        }

        /// <summary>
        /// Writes file changes
        /// </summary>
        private void FileRollBack()
        {
            using (var writer = new StreamWriter(_path + @"\" + _nameFile)) 
            {
                writer.WriteLine(_writeInFile);
            }
            CleaningLog();
            Console.WriteLine("File successfully roll back");
        }
        /// <summary>
        /// Displays the dates of possible rollbacks to the console
        /// </summary>
        private void ShowDateTimeInLog()
        {
            foreach (var item in _file)
            {
                if (item.NameFile == _nameFile) 
                {
                    Console.WriteLine(item.dateTime);
                }
            }
        }
        /// <summary>
        /// Removes entries from the log file
        /// </summary>
        private void CleaningLog()
        {
            var newLog = new List<File>();
            foreach (var item in _file)
            {
                if (item.NameFile != _nameFile || item.dateTime < _dateTime)
                {
                    newLog.Add(item);
                }
            }
            using (var writer = new StreamWriter(_pathLog))
            {
                foreach (var item in newLog)
                {
                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        /// <summary>
        /// Get file contents Log
        /// </summary>
        /// <returns></returns>
        private void FileContent()
        {
            _file = new List<File>();
            using (var streamReader = new StreamReader(_pathLog))
            {
                while (streamReader.Peek() >= 0)
                {
                    var jsonfile = JsonConvert.DeserializeObject<File>(streamReader.ReadLine());
                    if (jsonfile != null)
                    {
                        _file.Add(new File(jsonfile.NameFile, jsonfile.dateTime, jsonfile.Text));
                    } 
                }
            }
        }

        /// <summary>
        /// Сhecking for the ability to roll back a specific file to a specific date and time
        /// </summary>
        /// <returns></returns>
        private bool IsCheckRollback()
        {
            bool isCanRollBack = false;

            foreach (var item in _file)
            {
                if (EqualsUpToSeconds(item.dateTime, _dateTime) && item.NameFile == _nameFile) 
                {
                    isCanRollBack = true;
                    _writeInFile = item.Text;
                    break;
                }
            }
            if (!isCanRollBack)
            {
                Console.WriteLine("File cannot be rolled back to this date and time");
            }
            return isCanRollBack;
        }
        private static bool EqualsUpToSeconds(DateTime dt1, DateTime dt2)
        {
            return dt1.Year == dt2.Year && dt1.Month == dt2.Month && dt1.Day == dt2.Day &&
                   dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute && dt1.Second == dt2.Second;
        }
        /// <summary>
        /// Gets the date and time by which you need to roll back the file
        /// </summary>
        private void DateTimeRollback() 
        {
            ShowDateTimeInLog();
            do
            {
                Console.WriteLine("Enter the date and time the file was rolled back in the format (mm/dd/yyyy): {0:G}", new DateTime(2008, 1, 7, 15, 12, 30));
                Console.Write(">");
                while (!DateTime.TryParse(Console.ReadLine(), out _dateTime))
                {
                    Console.WriteLine("Enter the date and time correctly!!!");
                    Console.Write(">");
                }
            } while (!IsCheckRollback());
        }

        /// <summary>
        /// Gets the file name entered by the user
        /// </summary>
        /// <returns></returns>
        private string GetNameFile() 
        {
            string[] arrayFile = Directory.GetFiles(_path, "*.txt");
            string nameFile = string.Empty;
            bool isFileFound = false;
            do
            {
                Console.WriteLine("Enter name file.txt:");
                Console.Write(">");
                nameFile = Console.ReadLine();
                foreach (var item in arrayFile)
                {
                    if (item == _path + @"\" + nameFile) 
                    {
                        isFileFound = true;
                        break;
                    }
                }
                if (!isFileFound) 
                {
                    Console.WriteLine("File not found !!");
                }
            } while (!isFileFound);

            return nameFile;
        }
    }
}
