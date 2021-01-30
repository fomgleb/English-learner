using System;
using System.IO;
using System.Collections.Generic;

namespace English_learner
{
    static class Storage
    {
        static readonly public string pathToWriteDir = Environment.CurrentDirectory + "\\English-Learner-Saves\\Write"; // Путь к Write папке

        static public void createMainDir()
        {
            Directory.CreateDirectory(pathToWriteDir);
        }

        static public void createTxtFile(string fileName)
        {
            File.WriteAllText(pathToWriteDir + $"\\{fileName}.txt", null);
        }

        static public List<string> getDictList()
        {
            string[] pathsToFiles = Directory.GetFiles(pathToWriteDir);
            List<string> fileNames = new List<string> { };
            foreach (var pathToFile in pathsToFiles)
            {
                string fileName = Path.GetFileName(pathToFile);
                fileNames.Add(fileName);
            }
            return fileNames;
        }
    }
}
