using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"../../../");
            
            Dictionary<string, Dictionary<string, double>> allFiles = new Dictionary<string, Dictionary<string, double>>();
            
            foreach (var item in filePaths)
            {
                double memoryKB = new System.IO.FileInfo(item).Length * 0.001;

                string[] items = item.Split(new Char[] { '/', '.' }, StringSplitOptions.RemoveEmptyEntries);
                string extensionPath = ($"{'.'+ items[1]}");
                string fileName = items[0];

                if(!allFiles.ContainsKey(extensionPath))
                {
                    allFiles.Add(extensionPath, new Dictionary<string, double>());
                    allFiles[extensionPath].Add(fileName, memoryKB);

                }
                else
                {
                    allFiles[extensionPath].Add(fileName, memoryKB);
                }


            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            desktopPath += "\\";
            StreamWriter writer = new StreamWriter($"{desktopPath}actualResult.txt");
            foreach (var ext in allFiles.OrderBy(x => x.Value.Count).ThenBy(x => x.Key))
            {
                writer.WriteLine(ext.Key);

                foreach (var item in ext.Value)
                {
                    writer.WriteLine($"--{item.Key}{ext.Key} - {item.Value:f3}kb");
                }

            }

            writer.Close();
        }
    }
}
