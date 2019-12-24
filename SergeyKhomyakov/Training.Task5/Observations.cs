using System;
using System.IO;
using System.Threading;

namespace Training.Task5
{
    class Observations
    {
        private string _path;
        private LogFile log;
        public Observations(string path) 
        {
            _path = path;
        }
        /// <summary>
        /// Tracking user actions and commit them to a file
        /// </summary>
        public void Start() 
        {
            log = new LogFile(_path);

            using (var systemWatcher = new FileSystemWatcher(_path)) 
            {
                systemWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;

                systemWatcher.Filter = "*.txt";

                systemWatcher.Changed += OnChanged;
                systemWatcher.Created += OnChanged;
                systemWatcher.Deleted += OnDeleted;
                systemWatcher.Renamed += OnRenamed;

                systemWatcher.EnableRaisingEvents = true;

                Console.WriteLine("Enter the word Exit");
                Console.Write("> ");
                while (Console.ReadLine().ToUpper() != "EXIT");
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Thread.Sleep(50);
            log.RenameFile(e.Name,e.OldName);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(50);
            log.DeleteFile(e.Name);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(50);
            log.ChangedFile(e.Name);          
        }
    }
}
