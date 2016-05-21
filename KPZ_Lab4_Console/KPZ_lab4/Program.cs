using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4
{
    class Program
    {
        const string TextName = "test.dat";
        static void Main(string[] args)
        {
            Console.WriteLine("Input string (print 'q' to exit):");
            string s = Console.ReadLine();
            while (s != "q")
            {
                File.WriteAllText(TextName, s);
                Token t;
                Scanner scanner = new Scanner(TextName);
                while ((t = scanner.Scan()).kind != 0)
                {
                    Console.WriteLine("\tToken:{0}, Lexeme {1}", t.kind, t.val);
                }
                scanner = new Scanner(TextName);
                Parser parser = new Parser(scanner);
                parser.Parse();
                Console.WriteLine(parser.errors.count + " errors detected");
                Console.WriteLine("Input string (print 'q' to exit):");
                s = Console.ReadLine();
            }
        }
    }
}
