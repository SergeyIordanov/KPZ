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

            Translator translator = new Translator();
            FileAssistant fileAssistant = new FileAssistant("input.txt");
            input = fileAssistant.GetText();
            input = input.Replace(" ", String.Empty);
            Console.WriteLine("Input text: \n");
            Console.WriteLine(input + "\n\n");

            output = translator.Translate(input);
            //Here translation from string input to string output

            fileAssistant.ChangePath("output.txt");
            fileAssistant.WriteText(output);
            Console.WriteLine("Output text: \n");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
