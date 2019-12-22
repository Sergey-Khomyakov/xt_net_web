using System;
using System.IO;
using System.Linq;
namespace Training.Task5
{
    class Program
    {
        static void ShowMenu() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================================");
            Console.WriteLine("= Welcome to our file system ! =");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("=         Select a mode        =");
            Console.WriteLine("=                              =");
            Console.WriteLine("========> Observations         =");
            Console.WriteLine("=                              =");
            Console.WriteLine("========> Rollback changes     =");
            Console.WriteLine("=                              =");
            Console.WriteLine("================================");
            Console.WriteLine("=            Exit              =");
            Console.WriteLine("================================");
            Console.WriteLine();
        }
        static string GetFolderPath() 
        {
            bool isPath = false;
            string path = string.Empty;            
            Console.WriteLine("Specify the path to the folder: ");        
            while (!isPath)
            {
                Console.Write("> ");
                path = Console.ReadLine();
                if (Directory.Exists(path))
                {
                    isPath = true;
                }
                else 
                {
                    Console.WriteLine("Folder not found !!");
                }
            }
            return path;
        }
        static void Main(string[] args)
        {
            ShowMenu();
            bool isFlag = false;
            string path = GetFolderPath();

            while (!isFlag)
            {
                Console.WriteLine("Choose a mode");
                Console.Write("> ");
                string str = Console.ReadLine();
                switch (str.ToUpper())
                {
                    case "1":
                    case "OBSERVATIONS":
                        Observations observations = new Observations(path);
                        observations.Start();
                        break;

                    case "2":
                    case "ROLLBACK CHANGES":
                        RollbackChanges rollbackChanges = new RollbackChanges(path);
                        rollbackChanges.Start();
                        break;

                    case "EXIT":
                        isFlag = true;
                        break;

                    default:
                        Console.WriteLine("Error 0: Not found mode");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
