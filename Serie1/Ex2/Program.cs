using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel chiffre ?");
            string A = Console.ReadLine();
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Nombre d'itérations : " + ApproxSuccessive(Double.Parse(A), Double.Parse(A)));
            DateTime d2 = DateTime.Now;
            Console.WriteLine((d2 - d1).TotalSeconds + "s");
        }

        public static int ApproxSuccessive(double A, double X)
        {
            double Xj = (X + A / X) / 2;
            Console.WriteLine(Math.Round(Xj,3));
            if(Xj - Math.Sqrt(A) < A * 10e-9)
            {
                Console.WriteLine("Erreur résiduelle (Xj - A) : " + (Xj - Math.Sqrt(A)));
                return 1;
            }
            return ApproxSuccessive(A, Xj) + 1;
        }
    }
}
