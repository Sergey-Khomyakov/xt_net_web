using System;
using System.Collections.Generic;
using System.IO;

namespace Training.Task5
{
    class LogFile
    {
        private string _path;

        private List<string> _newlog;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        private string _pathLog;
        public LogFile(string path) 
        {
            _path = path;
            _pathLog = path + @"\Log\Log.txt";
            CreatedFolder();
            //WriteFile();
        }

        private void CreatedFolder() 
        {
            Directory.CreateDirectory(_path + @"\Log");
        }
        /// <summary>
        /// Adds changes to the logs
        /// </summary>
        private void WriteFile(string logging)
        {
            using (_streamWriter = new StreamWriter(_pathLog, true))
            {
                _streamWriter.WriteLine(logging);
            }
        }

        /// <summary>
        /// Changes in the logs
        /// </summary>
        private void OverwritesFile(List<string> logging) 
        {
            using (_streamWriter = new StreamWriter(_pathLog))
            {
                foreach (var item in logging)
                {
                    _streamWriter.WriteLine(item);
                }
            }
        }        
        private List<string> ReaderLogFile() 
        {
            List<string> list = new List<string>();

            using (_streamReader = new StreamReader(_pathLog))
            {
                var arrayLog = _streamReader
                    .ReadToEnd()
                    .Split('\r','\n');
                
                foreach (var item in arrayLog)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Writes changes to the logs
        /// </summary>
        public void ChangedFile(string nameFile) 
        {
            string logging = string.Empty;
            using (_streamReader = new StreamReader(_path + @"\" + nameFile))
            {
                logging = "File - " + nameFile + " | Date of change - " + DateTime.Now.ToString() + " | Text - " + _streamReader.ReadToEnd();
            }
            WriteFile(logging);
        }

        /// <summary>
        /// Delete a file in the logs
        /// </summary>
        public void DeleteFile(string nameFile) 
        {
            _newlog = new List<string>();

            List<string> log = ReaderLogFile();

            for (int i = 0; i < log.Count; i++)
            {
                if (!log[i].Contains(nameFile))
                {
                    _newlog.Add(log[i]);
                }
            }
            OverwritesFile(_newlog);
        }

        /// <summary>
        ///  Сhanges the name of the file in the logs
        /// </summary>
        public void RenameFile(string nameFile, string OldNameFile) 
        {
            _newlog = new List<string>();

            List<string> log = ReaderLogFile();

            for (int i = 0; i < log.Count; i++)
            {
                if (log[i].Contains(OldNameFile))
                {
                    _newlog.Add(log[i].Replace(OldNameFile, nameFile));
                }
                else 
                {
                    _newlog.Add(log[i]);
                }
            }
            OverwritesFile(_newlog);
        }
    }
}
