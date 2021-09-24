using System;
using System.IO;
using System.Collections.Generic;
// adicionar Json ao projeto
// dotnet add package Newtonsoft.Json 
using Newtonsoft.Json; 

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var storesDirectory = Path.Combine(currentDirectory, "stores");

            var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir")
            Directory.CreateDirectory(salesTotalDir)

            var salesFiles = FindFiles(storesDirectory);

            File.WriteAllText(Path.Combine(salesTotalDir, "total.txt"), String.Empty);
        }

        static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();
    
            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    
            foreach (var file in foundFiles)
            {
                var extention = Path.GetExtention(file);

                if (extention == ".json")
                    salesFiles.Add(file);                
            }
    
            return salesFiles;
        }
    }
}
