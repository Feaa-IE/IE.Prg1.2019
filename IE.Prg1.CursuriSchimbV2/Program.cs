using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.CursuriSchimbV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cursuri EUR/RON");

            //preluam cursul pentru fiecare luna
            //int lunaCurenta = DateTime.Today.Month;
            int lunaCurenta = 5;
            float[,] cursuri = new float[2, lunaCurenta];
            for (int i = 0; i < cursuri.GetLength(0); i++)
            {
                for (int j = 0; j < cursuri.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Introduceti cursul EUR pentru " + (j + 1));
                    }
                    else
                    {
                        Console.WriteLine("Introduceti cursul USD pentru " + (j + 1));
                    }

                    cursuri[i, j] = float.Parse(Console.ReadLine());
                }
            }

            int[] cursuriEgale = new int[0];
            int[] cursuriDiferite = new int[0];
            float suma = 0f;
            for (int i = 0; i < cursuri.GetLength(1); i++)
            {
                suma += cursuri[0, i] - cursuri[1, i];
                if (suma == 0)
                {
                    Array.Resize(ref cursuriEgale, cursuriEgale.Length + 1);
                    cursuriEgale[cursuriEgale.Length - 1] = i + 1;
                }
                else
                {
                    Array.Resize(ref cursuriDiferite, cursuriDiferite.Length + 1);
                    cursuriDiferite[cursuriDiferite.Length - 1] = i + 1;
                }
            }
            float medie = suma / cursuri.Length;

            //afisam media cursurile egale/diferite
            Console.WriteLine("Media diferentelor este " + medie);
            //folosim functia join
            Console.WriteLine("Lunile cu cursuri egale");
            Console.WriteLine(string.Join(";",cursuriEgale));
            Console.WriteLine("Lunile cu cursuri diferite");
            Console.WriteLine(string.Join(";",cursuriDiferite));

            Console.ReadKey();


        }
    }
}
