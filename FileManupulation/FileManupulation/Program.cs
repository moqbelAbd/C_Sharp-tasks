using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileManupulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("data.txt");
            string line;
            while ( (line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            reader.Close();

            Console.WriteLine();

            string[] lines = File.ReadAllLines("data.txt");

            foreach (var liner in lines)
            {
                try
                {
                    Console.WriteLine(liner);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            File.AppendAllText("data.txt", "\n" + lines[0]);

            foreach (var row in lines)
            {
                File.WriteAllText("data2.txt", "\n" + row);

            }
        }
    }
}
