using System;
using System.Collections.Generic;
using System.IO;

namespace Training.Task5
{
    class LogFile
    {
        private string _path;

        private List<string> _list;
        private List<string> _newlist;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;
        public LogFile(string path) 
        {
            _path = path;
            _list = new List<string>();
            CreatedFolder();
            WriteFile();
        }

        private void CreatedFolder() 
        {
            Directory.CreateDirectory(_path + @"\Log");
        }
        /// <summary>
        /// Adds changes to the logs
        /// </summary>
        private void WriteFile()
        {
            using (_streamWriter = new StreamWriter(_path + @"\Log\Log.txt", true))
            {
                foreach (var item in _list)
                {
                    _streamWriter.WriteLine(item);
                }
                _streamWriter.Close();
            }
        }

        /// <summary>
        /// Changes in the logs
        /// </summary>
        private void OverwritesFile() 
        {
            using (_streamWriter = new StreamWriter(_path + @"\Log\Log.txt"))
            {
                foreach (var item in _newlist)
                {
                    _streamWriter.WriteLine(item);
                }
                _streamWriter.Close();
            }
        }        
        private void ReaderLogFile() 
        {

            using (_streamReader = new StreamReader(_path + @"\Log\Log.txt"))
            {
                var arrayLog = _streamReader
                    .ReadToEnd()
                    .Split('\r','\n');

                foreach (var item in arrayLog)
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        _list.Add(item);
                    }
                }
                _streamReader.Close();
            }
        }

        /// <summary>
        /// Writes changes to the logs
        /// </summary>
        public void ChangedFile(string nameFile) 
        {
            using (var fileStream = new FileStream(_path + @"\" + nameFile, FileMode.OpenOrCreate, FileAccess.Read))
            using (_streamReader = new StreamReader(fileStream))
            {
                _list.Add("File - " + nameFile + " | Date of change - " + DateTime.Now.ToString() + " | Text - " + _streamReader.ReadToEnd());
                fileStream.Close();
            }   
            WriteFile();
        }

        /// <summary>
        /// Delete a file in the logs
        /// </summary>
        public void DeleteFile(string nameFile) 
        {
            _newlist = new List<string>();

            ReaderLogFile();

            for (int i = 0; i < _list.Count; i++)
            {
                if (!_list[i].Contains(nameFile))
                {
                    _newlist.Add(_list[i]);
                }
            }
            OverwritesFile();
        }

        /// <summary>
        ///  Сhanges the name of the file in the logs
        /// </summary>
        public void RenameFile(string nameFile, string OldNameFile) 
        {
            _newlist = new List<string>();

            ReaderLogFile();

            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Contains(OldNameFile))
                {
                    _newlist.Add(_list[i].Replace(OldNameFile, nameFile));
                }
                else 
                {
                    _newlist.Add(_list[i]);
                }
            }
            OverwritesFile();
        }
    }
}
