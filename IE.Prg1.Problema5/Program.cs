using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n");
            //preluam n
            int n = int.Parse(Console.ReadLine());
            //declarare vector de n
            double[] valori = new double[n];

            //populare
            for (int i = 0; i < valori.Length; i++)
            {
                valori[i] = double.Parse(Console.ReadLine());
            }

            bool ordonat = true;

            int j = 0;
            while (j < valori.Length - 1)
            {
                if (valori[j] > valori[j + 1])
                {
                    ordonat = false;
                    break;
                }
                j++;
            }

            Console.WriteLine("Sirul este " + (ordonat ? "ordonat" : "dezordonat"));
            Console.ReadKey();

        }
    }
}
