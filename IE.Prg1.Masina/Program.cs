using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Masina
{
    class Program
    {
        static void Main(string[] args)
        {
            string marca = "Opel";
            decimal pret;
            pret = 5000;
            var culoare = "neagra";
            DateTime dataFab = new DateTime(2013, 9, 16);
            bool euro6 = true;
            const float coef = 0.05f;
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
            //pret = pret - pret * 2 * Convert.ToDecimal(coef) * pret;
            pret = pret - 2 * (decimal)coef * pret;
            Console.WriteLine("Dupa 2 ani:");
            mesaj = "Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + mesajEuro6 + " costa " + pret;
            Console.WriteLine(mesaj);
            
            Console.WriteLine("Introduceti noua culoare:");
            culoare = Console.ReadLine();
            pret = pret - 2 * (decimal)coef * pret;
            mesaj = "Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + mesajEuro6 + " costa " + pret;
            Console.WriteLine("Dupa 4 ani");
            Console.WriteLine(mesaj);

            euro6 = false;
            if (euro6)
            {
                mesajEuro6 = " are euro 6";
            }
            else
            {
                mesajEuro6 = " nu are euro 6";
            }
            pret = pret - 2 * (decimal)coef * pret;
            mesaj = "Masina " + marca + " de culoare " + culoare + " fabricata la data " + dataFab + mesajEuro6 + " costa " + pret;
            Console.WriteLine("Dupa 6 ani");
            Console.WriteLine(mesaj);


            Console.ReadKey();


        }
    }
}
