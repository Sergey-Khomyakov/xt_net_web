using System;
using System.IO;

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
        // Метод начинает отслеживать действия пользователя и фиксировать их в файл 
        public void Start() 
        {
            log = new LogFile(_path);

            using (FileSystemWatcher systemWatcher = new FileSystemWatcher(_path)) 
            {
                systemWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName ;

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
            log.RenameFile(e.Name,e.OldName);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            log.DeleteFile(e.Name);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            log.ChangedFile(e.Name);
        }

    }
}
