using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[20];
            Console.WriteLine("Valeurs à séparer");
            for(int i = 0; i < 20; i++)
            {
                numbers[i] = rand.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Appel de PairImpair");
            int[][] result = PairImpair(numbers);
            for(int i = 0; i < result.Length; i++)
            {
                if(i == 0)
                    Console.Write("Pairs : ");
                if(i == 1)
                    Console.Write("Impairs : ");
                foreach (int j in result[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] PairImpair(int[] numbers)
        {
            int nbPairs = 0;
            int nbImpairs = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    nbPairs++;
                }
                else
                {
                    nbImpairs++;
                }
            }
            int[] pairs = new int[nbPairs];
            int iPair = 0;
            int[] impairs = new int[nbImpairs];
            int iImpairs = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    pairs[iPair] = numbers[i];
                    iPair++;
                }
                else{
                    impairs[iImpairs] = numbers[i];
                    iImpairs++;
                }
            }
            return new int[][] { pairs, impairs };
        }
    }
}
