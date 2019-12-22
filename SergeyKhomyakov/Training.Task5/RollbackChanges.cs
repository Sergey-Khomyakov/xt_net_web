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
        private List<string> _contentsByFileNameInLog;
        private List<string> _contentsOfLogFile;
        public RollbackChanges(string path) 
        {
            _path = path;
            _pathLog = path + @"\Log\Log.txt";           
        }
        public void Start()
        {
            _nameFile = GetNameFile();
            FileContent();
            if (_contentsByFileNameInLog.Count == 0)
            {
                Console.WriteLine("Error: Rollback not possible");
            }
            else 
            {
                DateTimeRollback();
                FileRollBack();
            }
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
            foreach (var item in _contentsByFileNameInLog)
            {
                Console.WriteLine($"{GetRecordFromLogFile(item, "Date of change - ").Remove(22)}");
            }
        }

        /// <summary>
        /// Removes entries from the log file
        /// </summary>
        private void CleaningLog() 
        {
            var dateTime = new DateTime();
            string[] splitestring; 
            for (int i = 0; i < _contentsByFileNameInLog.Count; i++)
            {
                splitestring = _contentsByFileNameInLog[i].Split(' ');
                dateTime = Convert.ToDateTime(splitestring[8] + " " + splitestring[9] + " " + splitestring[10]);
                if (dateTime < _dateTime) 
                {
                    _contentsOfLogFile.Add(_contentsByFileNameInLog[i]); 
                }
            }
            using (var writer = new StreamWriter(_pathLog))
            {
                foreach (var item in _contentsOfLogFile)
                {
                    writer.WriteLine(item);     
                }
            }
        }

        /// <summary>
        /// Get file contents Log
        /// </summary>
        /// <returns></returns>
        private void FileContent() 
        {
            _contentsByFileNameInLog = new List<string>();
            _contentsOfLogFile = new List<string>();

            using (var streamReader = new StreamReader(_pathLog))
            {
                var arrayLog = streamReader
                    .ReadToEnd()
                    .Split('\r', '\n');

                foreach (var item in arrayLog)
                {
                    if (!string.IsNullOrWhiteSpace(item) && item.Contains(_nameFile))
                    {
                        _contentsByFileNameInLog.Add(item);
                    }
                    else if (!string.IsNullOrWhiteSpace(item)) 
                    {
                        _contentsOfLogFile.Add(item);
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves file contents for a specific date
        /// </summary>
        /// <param name="line">String from Log file </param>
        /// <param name="txt">Substring</param>
        /// <returns></returns>
        private string GetRecordFromLogFile(string line, string txt) 
        {
            int startIndex = line.LastIndexOf(txt);
            return line.Substring(startIndex + txt.Length);
        }

        /// <summary>
        /// Сhecking for the ability to roll back a specific file to a specific date and time
        /// </summary>
        /// <returns></returns>
        private bool IsCheckRollback()
        {
            bool isCanRollBack = false;
            string date = _dateTime.ToString();
            for (int i = 0; i < _contentsByFileNameInLog.Count; i++)
            {
                if (_contentsByFileNameInLog[i].Contains(_dateTime.ToString()) && _contentsByFileNameInLog[i].Contains(_nameFile)) 
                {
                    isCanRollBack = true;
                    _writeInFile = GetRecordFromLogFile(_contentsByFileNameInLog[i],"Text - ");
                    break;
                }
            }
            if (!isCanRollBack) 
            {
                Console.WriteLine("File cannot be rolled back to this date and time");
            }
            return isCanRollBack;
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
