using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Dynamic;

namespace GKDLab3
{

    public static class TxtFileHandler 
    {
        public static void CreateAndOpenNewTxtFile(string fileName)
        {
            File.Create(fileName).Dispose();

            Process.Start(fileName);
        }

        public static void CreateAndWriteContent(string fileName, string content)
        {
            File.Create(fileName).Dispose();
            using (StreamWriter file =  new StreamWriter(fileName))
            {
                
                file.WriteLine(content);

            }
            Process.Start(fileName);
        }

        public static string ReadContentFromFile(string fileName)
        {
            using(StreamReader file = new StreamReader(fileName))
            {
                return file.ReadToEnd().TrimStart().TrimEnd();
            }
        }

     
        public static void LogEvents(string eventLog)
        {
            string logFilePath = @".\log.txt";
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
            }
            using (StreamWriter file = new StreamWriter(logFilePath, append: true))
            {

                file.WriteLine(eventLog);

            }
        }
    }
}
