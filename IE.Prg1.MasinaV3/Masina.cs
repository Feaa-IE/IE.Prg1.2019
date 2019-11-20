using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.MasinaV3.TipuriComplexe
{
    public struct Masina
    {
        public string Marca;
        public string Culoare;
        public decimal Pret;
        public DateTime DataFab;
        public bool Euro6;

        public override string ToString()
        {
            string mesajEuro6;
            if (Euro6)
            {
                mesajEuro6 = " are euro 6";
            }
            else
            {
                mesajEuro6 = " nu are euro 6";
            }
            string mesaj = "Masina " + Marca + " de culoare " + Culoare + " fabricata la data " + DataFab + mesajEuro6 + " costa " + Pret;
            return mesaj;

        }
    }
}
