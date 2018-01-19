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
            Console.Clear();
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
            Console.WriteLine("Your Folder path is : ");
            Console.WriteLine(folderPath);
            Console.WriteLine("Is it the good folder path Yes or No :");
            string input = Console.ReadLine();
            if (input == "Yes" || input == "yes")
            {
                CheckFolderContent();
            }
            else if (input == "No" || input == "no")
            {
                AskFolderPath();
            }
            else
            {
                Console.WriteLine("Type Help for more commands");
                ShowHelpMenu();
            }
        }

        void CheckFolderContent()
        {
            string[] fileList = Directory.GetFiles(folderPath);
            if (fileList.Length != 0)
            {
                Console.WriteLine("The folder must be empty - (Type Clear if you want to clear it)");
                CommandBuffer();
            }

        }

        void CommandBuffer()
        {
            string newInput = Console.ReadLine();
            switch (newInput)
            {
                //HELP
                case "Help":
                    ShowHelpMenu();
                    break;
                case "help":
                    ShowHelpMenu();
                    break;

                //RESTART
                case "Restart":
                    AskFolderPath();
                    break;
                case "restart":
                    AskFolderPath();
                    break;

                //QUIT
                case "Quit":
                    System.Environment.Exit(0);
                    break;
                case "quit":
                    System.Environment.Exit(0);
                    break;
            }
        }

        void ShowHelpMenu()
        {
            Console.WriteLine("Help - Give the commands list");
            Console.WriteLine("Restart - Restart the application.");
            Console.WriteLine("Quit - Close the application.");
            string input = Console.ReadLine();
            CommandBuffer();
        }
    }
}
