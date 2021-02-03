using System;
using System.IO;
using System.Collections.Generic;

namespace English_learner
{
    static class Storage
    {
        static readonly public string pathToMainDir = Environment.CurrentDirectory + "\\English-Learner-Saves"; // Путь к главной папке

        static public void createMainDir()
        {
            Directory.CreateDirectory(pathToMainDir);
        }

        static public void createTxtFile(string fileName)
        {
            File.WriteAllText($"{pathToMainDir}\\{fileName}.txt", null);
        }

        static public void deleteTxtFile(string fileName)
        {
            File.Delete($"{pathToMainDir}\\{fileName}.txt");
        }

        static public void addContentToTxtFile(string fileName, string content)
        {
            string OldContent = "";
            //using (StreamReader sr = new StreamReader(pathToMainDir + $"\\{fileName}.txt"))
            //{
            //    string line;
            //    // Read and display lines from the file until the end of
            //    // the file is reached.
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        OldContent += line;
            //    }
            //}
            OldContent = File.ReadAllText($"{pathToMainDir}\\{fileName}.txt");
            File.WriteAllText($"{pathToMainDir}\\{fileName}.txt", OldContent + content + "\n");
        }

        static public void addNewContentToTxtFile(string fileName, string content)
        {
            File.WriteAllText($"{pathToMainDir}\\{fileName}.txt", content);
        }

        static public List<string> getDictNamesList()
        {
                createMainDir();
                string[] pathsToFiles = Directory.GetFiles(pathToMainDir);
                List<string> fileNames = new List<string> { };
                foreach (var pathToFile in pathsToFiles)
                {
                    string fileName = Path.GetFileName(pathToFile);
                    fileNames.Add(fileName.Replace(".txt", ""));
                }
                return fileNames;
        }

        static public string getContentFromTxtFile(string fileName)
        {
            if (Dictionary.Selected != null)
                return File.ReadAllText($"{pathToMainDir}\\{fileName}.txt");
            else return "";
        }
    }
}
