using System;

namespace IE.Prg1.MedieNrPare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int cateNr = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                    cateNr++;
                }
            }

            //implementare fara %
            /*for (int i = 0; i < n; i += 2)
            {
                suma += i;
                cateNr++;
            }*/

            double media = suma / cateNr;
            Console.WriteLine($"Media numerelor pare este:{media}");
            //Console.WriteLine("Media numerelor pare este:" + media);
            Console.ReadKey();

        }
    }
}
