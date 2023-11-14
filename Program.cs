using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_FileHandling
{
    internal class Program
    {

        const string DirectoryPath = "E:\\Mphasis\\Day7";

        static void Main()
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Append to File");
            Console.WriteLine("4. Delete File");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter file name: ");
                        string createFileName = Console.ReadLine();
                        Console.Write("Enter content: ");
                        string createFileContent = Console.ReadLine();
                        CreateFile(Path.Combine(DirectoryPath, createFileName), createFileContent);
                        Console.WriteLine("File created successfully!");
                        break;

                    case 2:
                        Console.Write("Enter file name to read: ");
                        string readFile = Console.ReadLine();
                        ReadFile(Path.Combine(DirectoryPath, readFile));
                        break;

                    case 3:
                        Console.Write("Enter file name to append: ");
                        string appendFileName = Console.ReadLine();
                        Console.Write("Enter content to append: ");
                        string appendFileContent = Console.ReadLine();
                        AppendToFile(Path.Combine(DirectoryPath, appendFileName), appendFileContent);
                        Console.WriteLine("Content appended successfully!");
                        break;

                    case 4:
                        Console.Write("Enter file name to delete: ");
                        string deleteFileName = Console.ReadLine();
                        DeleteFile(Path.Combine(DirectoryPath, deleteFileName));
                        Console.WriteLine("File deleted successfully!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.ReadLine();
        }

        static void CreateFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
        }

        static void ReadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            Console.ReadLine();
        }

        static void AppendToFile(string fileName, string content)
        {
            File.AppendAllText(fileName, content);
        }

        static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            Console.ReadKey();
        }

    }


}


