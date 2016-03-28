using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, output = "";           

            FileAssistant fileAssistant = new FileAssistant("input.txt");
            input = fileAssistant.GetText();
            input = input.Replace(" ", String.Empty);
            input = input.Replace("\n", String.Empty);
            input = input.Replace("\t", String.Empty);
            input = input.Replace("\r", String.Empty);
            Console.WriteLine("Input text: \n");
            Console.WriteLine(input + "\n\n");

            output = Translator.Translate(input);

            fileAssistant.ChangePath("output.txt");
            fileAssistant.WriteText(output);
            Console.WriteLine("Output text: \n");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
