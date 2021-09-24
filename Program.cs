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

            var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
            Directory.CreateDirectory(salesTotalDir);

            var salesFiles = FindFiles(storesDirectory);

            // chama o método para o cálculo do total de vendas
            var salesTotal = CalculateSalesTotal(salesFiles);

            File.AppendAllText(Path.Combine(salesTotalDir, "total.txt"), $"{salesTotal}{Environment.NewLine}");
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

        class SalesData
        {
            public double Total { get; set; }
        }

        public double CalculateSalesTotal(IEnumerable<String> salesFiles)
        {
            double salesTotal = 0;

                // itera sobre cada caminho em salesFiles
                foreach(var file in salesFiles)
                {
                    // lê o conteúdo do arquivo
                    String salesJson = File.ReadAllText(file);

                    // converte para Json
                    SalesData data = JsonConvert.DeserializeObject<SalesData>(salesJson);

                    // adiciona o montante encontrado no campo Total e adicio à variável salesTotal 
                    salesTotal += data.Total;
                }

            return salesTotal
        }
    }
}
