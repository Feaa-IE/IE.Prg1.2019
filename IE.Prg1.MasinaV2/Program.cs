using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.MasinaV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti datele masinii");

            Console.WriteLine("Marca:");
            string marca = Console.ReadLine();

            Console.WriteLine("Pret:");
            decimal pret;
            pret = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Culoare:");
            var culoare = Console.ReadLine();

            Console.WriteLine("Data fabricatie:");
            DateTime dataFab = DateTime.Parse(Console.ReadLine());

            bool euro6 = true;
            string mesajEuro6;
            if (euro6)
            {
                mesajEuro6 = " are euro 6";
            }
            else
            {
                mesajEuro6 = " nu are euro 6";
            }

            string mesaj = "Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + mesajEuro6 + " costa " + pret;
            Console.WriteLine(mesaj);
            const float coef = 0.05f;


            for (int i = 1; i < 7; i++)
            {
                pret = pret - pret * (decimal)coef;
                if (i == 3)
                {
                    Console.WriteLine("Revopsire in culoarea:");
                    culoare = Console.ReadLine();
                }
                if (i == 5)
                {
                    euro6 = false;
                    if (euro6)
                    {
                        mesajEuro6 = " are euro 6";
                    }
                    else
                    {
                        mesajEuro6 = " nu are euro 6";
                    }
                }

                if (i == 2 || i == 4 || i == 6)
                {

                    mesaj = "Dupa " + i + " ani: Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + mesajEuro6 + " costa " + pret;
                    Console.WriteLine(mesaj);
                }
            }

            Console.ReadKey();


        }
    }
}
