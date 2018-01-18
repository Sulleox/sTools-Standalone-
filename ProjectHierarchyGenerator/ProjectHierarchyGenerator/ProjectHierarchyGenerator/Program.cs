using System;
using System.IO;
using System.Windows;

namespace ProjectHierarchyGenerator
{
    class Program
    {

        private string folderPath = string.Empty;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.AskFolderPath();
        }

        void AskFolderPath()
        {
            Console.WriteLine("Write your Folder Path and press Enter");
            string folderPath = Console.ReadLine();
            if (Directory.Exists(folderPath))
            {
                CheckFolderPath();
            }
            else
            {
                Console.WriteLine("The Folder Path lead to nothing please create the folder before");
                AskFolderPath();
            }
        }

        void CheckFolderPath()
        {
            Console.WriteLine("Your Folder path is : " + folderPath);
            Console.WriteLine("Is it the good folder path Yes or No :");
            string input = Console.ReadLine();
            if (input == "Yes")
            {
                CheckFolderContent();
            }
            else if (input == "No")
            {
                AskFolderPath();
            }
            else
            {
                Console.WriteLine("Command Not Recognized");
                CheckFolderPath();
            }
        }

        void CheckFolderContent()
        {

        }
    }
}
