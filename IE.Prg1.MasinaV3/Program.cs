using IE.Prg1.MasinaV3.TipuriComplexe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.MasinaV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti datele masinii");

            Masina masina = new Masina();

            Console.WriteLine("Marca:");
            masina.Marca = Console.ReadLine();

            Console.WriteLine("Pret:");
            masina.Pret = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Culoare:");
            masina.Culoare = Console.ReadLine();

            Console.WriteLine("Data fabricatie:");
            masina.DataFab = DateTime.Parse(Console.ReadLine());

            masina.Euro6 = true;
                      
            Console.WriteLine(masina);
            const float coef = 0.05f;
            for (int i = 1; i < 7; i++)
            {
                masina.Pret = masina.Pret - masina.Pret * (decimal)coef;
                if (i == 3)
                {
                    Console.WriteLine("Revopsire in culoarea:");
                    masina.Culoare = Console.ReadLine();
                }
                if (i == 5)
                {
                    masina.Euro6 = false;                   
                }

                if (i == 2 || i == 4 || i == 6)
                {
                    Console.WriteLine("Dupa " + i + " ani:");
                    Console.WriteLine(masina);
                }
            }

            Console.ReadKey();

        }
    }
}
