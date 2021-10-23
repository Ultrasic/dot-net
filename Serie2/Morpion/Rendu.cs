using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    class Rendu
    {
        public static void Rendre(int[,] plateau)
        {
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                for(int j = 0; j < plateau.GetLength(1); j++)
                {
                    String val = "";
                    if(plateau[i, j] == 0)
                    {
                        val = " ";
                    }else if(plateau[i, j] == 1)
                    {
                        val = "X";
                    }
                    else
                    {
                        val = "O";
                    }
                    Console.Write("   " + val);
                    if(j < plateau.GetLength(1) - 1)
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();
                if (i < plateau.GetLength(0) - 1)
                {
                    for (int j = 0; j < plateau.GetLength(1); j++)
                    {
                        Console.Write("-------");
                        if (j < plateau.GetLength(1) - 1)
                        {
                            Console.Write("+");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
