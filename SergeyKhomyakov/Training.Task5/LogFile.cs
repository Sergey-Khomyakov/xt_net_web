using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Training.Task5
{
    class LogFile
    {
        private string _path;
        private string _pathLog;
        private List<File> _file;
        public LogFile(string path) 
        {
            _path = path;
            _pathLog = path + @"\Log\Log.txt";
            CreatedFolder();
        }

        /// <summary>
        /// Delete a file in the logs
        /// </summary>
        public void DeleteFile(string nameFile)
        {
            _file = new List<File>();

            var log = GetFileContent();

            for (int i = 0; i < log.Count; i++)
            {
                if (log[i].NameFile != nameFile) 
                {
                    _file.Add(log[i]);
                }
            }
            OverwritesFile(_file);
        }
        /// <summary>
        ///  Сhanges the name of the file in the logs
        /// </summary>
        public void RenameFile(string nameFile, string OldNameFile)
        {
            _file = new List<File>();

            var log = GetFileContent();

            for (int i = 0; i < log.Count; i++)
            {
                if (log[i].NameFile == OldNameFile)
                {
                    log[i].NameFile = nameFile;
                    _file.Add(log[i]);
                }
                else 
                {
                    _file.Add(log[i]);
                }
            }
            OverwritesFile(_file);
        }

        /// <summary>
        /// Writes changes to the logs
        /// </summary>
        public void ChangedFile(string nameFile) 
        {
            using (var streamReader = new StreamReader(_path + @"\" + nameFile))
            {
                WriteFile(JsonConvert.SerializeObject(new File(nameFile,DateTime.Now,streamReader.ReadToEnd())));
            }
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
            using (var streamWriter = new StreamWriter(_pathLog, true))
            {
                streamWriter.WriteLine(logging);
            }
        }

        /// <summary>
        /// Changes in the logs
        /// </summary>
        private void OverwritesFile(List<File> logging)
        {
            using (var streamWriter = new StreamWriter(_pathLog))
            {
                foreach (var item in logging)
                {
                    streamWriter.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        private List<File> GetFileContent()
        {
            var fileСontents = new List<File>();

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
            return fileСontents;
        }
    }
}
