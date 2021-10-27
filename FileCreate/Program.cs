using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Wishlist";
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            string fullFilePath = $@"{rootDirectory}\{fileName}.txt";
            bool directoryExist = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);
            if (directoryExist && fileExists)
            {
                Console.WriteLine($"file {fileName} already exist in {rootDirectory}.");
            }
            else if (!directoryExist)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullFilePath);
                Console.WriteLine($"File {fileName}.txt and folder has been created.");
            }
            else
            {
                File.Exists(rootDirectory);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            
        }
    }
}
