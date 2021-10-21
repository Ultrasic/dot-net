using System;
using System.IO;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@".\Mesures.txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.Write($"{@line}");
                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    i++;
                }
            }
        }
    }
}
