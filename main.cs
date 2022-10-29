using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pth = "I:/MyTest.csv";
            string delimiter = ", ";

            if (!File.Exists(pth))
            {
                string createText = "Katalog" + delimiter + "Plik" + delimiter + "Wlasciwosci" + delimiter + Environment.NewLine;
                File.WriteAllText(pth, createText);
            }

            kek("I:/");

            void kek(string path)
            {
                string[] folders = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                string appendText = path;

                if (files.Length != 0)
                {
                    foreach (string file in files)
                    {
                        FileInfo oFileInfo = new FileInfo(file);
                        DateTime dtCreationTime = oFileInfo.CreationTime;
                        appendText += Environment.NewLine + delimiter
                            + "Name: " + oFileInfo.Name + delimiter
                            + "Date: " + dtCreationTime.ToString()
                            + " Extension: " + oFileInfo.Extension
                            + " total Size (B): " + (oFileInfo.Length).ToString();
                    }
                }
                appendText += Environment.NewLine;
                File.AppendAllText(pth, appendText);
                foreach (string folder in folders)
                {
                    kek(folder);   
                }
            }
        }
    }
}