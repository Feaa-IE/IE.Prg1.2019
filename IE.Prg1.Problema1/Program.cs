using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaram variabilele
            int n;
            double a, b;
            double[] valori;

            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            b = double.Parse(Console.ReadLine());

            //presupunem ca a<b
            if (a > b)
            {
                double temp = b;
                b = a;
                a = temp;
            }

            //intializare vector 'valori'
            valori = new double[n];

            for (int i = 0; i < valori.Length; i++)
            {
                Console.WriteLine("Introduceti valoarea " + (i + 1) + ":");
                valori[i] = double.Parse(Console.ReadLine());
            }

            //calcul medie
            double suma = 0;
            int nrValori = 0;
            for (int i = 0; i < valori.Length; i++)
            {
                //if (/*a > b && */valori[i] >= a && valori[i] <= b)
                if (valori[i] >= Math.Min(a, b) && valori[i] <= Math.Max(a, b))
                {
                    suma += valori[i];
                    nrValori++;
                }
                //if (a <= b && valori[i] >= b && valori[i] <= a)
                //{
                //    suma += valori[i];
                //    nrValori++;
                //}

            }

            double media = suma / nrValori;
            Console.WriteLine("Media este" + media);


            Console.ReadKey();

        }
    }
}
