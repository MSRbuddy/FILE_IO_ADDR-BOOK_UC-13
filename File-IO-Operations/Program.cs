using System;

namespace FileIOOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"C:\Users\USER\source\repos\File-IO\MyFile.txt";
            Console.WriteLine("Enter 1: To check whether the file exists or not");
            Console.WriteLine("Enter 2: To Read all lines in file by using ReadAllLines method");
            Console.WriteLine("Enter 3: To Read all lines in file by using ReadAllText method");
            Console.WriteLine("Enter 4: To copy a file from cource to destination");
            Console.WriteLine("Enter 5: To delete a file (FileText1)");
            Console.WriteLine("Enter 6: To read the file from StreamReader class");
            Console.WriteLine("Enter 7: To write the file using StreamWriter class");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FileOperations.FileExists(path);
                    break;
                case 2:
                    FileOperations.ReadAllLinesInFile();
                    break;
                case 3:
                    FileOperations.ReadAllTextInFile();
                    break;
                case 4:
                    FileOperations.CopyFile();
                    break;
                case 5:
                    FileOperations.DeleteFile();
                    break;
                case 6:
                    FileOperations.ReadFromStreamReader();
                    break;
                case 7:
                    FileOperations.WriteUsingStreamWriter();
                    break;

                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
            }
        }
    }
}