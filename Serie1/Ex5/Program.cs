using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            string s2 = "Hello World";
            string s3 = s1;



            if (Equals(s1, s2))
            {
                Console.WriteLine("s1 Equals s2 true");
            }
            else
            {
                Console.WriteLine("s1 Equals s2 false");
            }
            if (s1.CompareTo(s2) < 0)
            {
                Console.WriteLine("s1 precedes s2");
            }
            else if(s1.CompareTo(s2) == 0)
            {
                Console.WriteLine("s1 same position in the sort order as s2");
            }
            else if (s1.CompareTo(s2) > 0)
            {
                Console.WriteLine("s1 follows s2 or is null");
            }
            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("s1 ReferenceEquals s2 true");
            }
            else
            {
                Console.WriteLine("s1 ReferenceEquals s2 false");
            }



            if (Equals(s1, s3))
            {
                Console.WriteLine("s1 Equals s3 true");
            }
            else
            {
                Console.WriteLine("s1 Equals s3 false");
            }
            if (s1.CompareTo(s3) < 0)
            {
                Console.WriteLine("s1 precedes s3");
            }
            else if (s1.CompareTo(s3) == 0)
            {
                Console.WriteLine("s1 same position in the sort order as s3");
            }
            else if (s1.CompareTo(s3) > 0)
            {
                Console.WriteLine("s1 follows s3 or is null");
            }
            if (ReferenceEquals(s1, s3))
            {
                Console.WriteLine("s1 ReferenceEquals s3 true");
            }
            else
            {
                Console.WriteLine("s1 ReferenceEquals s3 false");
            }



            if (Equals(s2, s3))
            {
                Console.WriteLine("s2 Equals s3 true");
            }
            else
            {
                Console.WriteLine("s2 Equals s3 false");
            }
            if (s2.CompareTo(s3) < 0)
            {
                Console.WriteLine("s2 precedes s3");
            }
            else if (s2.CompareTo(s3) == 0)
            {
                Console.WriteLine("s2 same position in the sort order as s3");
            }
            else if (s2.CompareTo(s3) > 0)
            {
                Console.WriteLine("s2 follows s3 or is null");
            }
            if (ReferenceEquals(s2, s3))
            {
                Console.WriteLine("s2 ReferenceEquals s3 true");
            }
            else
            {
                Console.WriteLine("s2 ReferenceEquals s3 false");
            }


            s3 += "!" ;


            if (Equals(s1, s3))
            {
                Console.WriteLine("s1 Equals s3 true");
            }
            else
            {
                Console.WriteLine("s1 Equals s3 false");
            }
            if (s1.CompareTo(s3) < 0)
            {
                Console.WriteLine("s1 precedes s3");
            }
            else if (s1.CompareTo(s3) == 0)
            {
                Console.WriteLine("s1 same position in the sort order as s3");
            }
            else if (s1.CompareTo(s3) > 0)
            {
                Console.WriteLine("s1 follows s3 or is null");
            }
            if (ReferenceEquals(s1, s3))
            {
                Console.WriteLine("s1 ReferenceEquals s3 true");
            }
            else
            {
                Console.WriteLine("s1 ReferenceEquals s3 false");
            }



            if (Equals(s2, s3))
            {
                Console.WriteLine("s2 Equals s3 true");
            }
            else
            {
                Console.WriteLine("s2 Equals s3 false");
            }
            if (s2.CompareTo(s3) < 0)
            {
                Console.WriteLine("s2 precedes s3");
            }
            else if (s2.CompareTo(s3) == 0)
            {
                Console.WriteLine("s2 same position in the sort order as s3");
            }
            else if (s2.CompareTo(s3) > 0)
            {
                Console.WriteLine("s2 follows s3 or is null");
            }
            if (ReferenceEquals(s2, s3))
            {
                Console.WriteLine("s2 ReferenceEquals s3 true");
            }
            else
            {
                Console.WriteLine("s2 ReferenceEquals s3 false");
            }

            /*
             On remarque que Equals compare le contenu et réagis comme on l'attend
             Que CompareTo compare les positions du contenu et réagis comme on l'attend
             Mais que ReferenceEquals compare les référence et pourtant dit que s1 et s2 sont égaux
             Il semblerait donc que pour une string, le contenu défini la référence ?
             En cherchant sur internet je découvre que c'est la constante "Hello World" qui est référencé par les deux strings et ont donc les mêmes références
             Et dès que qu'on ajoute le ! à s3 tout réagis comme on le voudrait
             */
        }
    }
}
