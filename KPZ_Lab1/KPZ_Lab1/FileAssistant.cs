using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab1
{
    class FileAssistant
    {
        public string FilePath { get; set; }

        public FileAssistant(string path)
        {
            FilePath = path;
        }

        public void ChangePath(string path)
        {
            FilePath = path;
        }

        public string GetText()
        {
            string input = "";
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    input = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return input;
        }

        public void WriteText(string text)
        {
            File.WriteAllText(FilePath, text);
        }

    }
}