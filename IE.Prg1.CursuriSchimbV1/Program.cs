using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.CursuriSchimbV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cursuri EUR/RON");

            //preluam cursul pentru fiecare luna
            //int lunaCurenta = DateTime.Today.Month;
            int lunaCurenta = 6;
            float[] cursuri = new float[lunaCurenta];
            int i = 0;
            while (i < cursuri.Length)
            {
                Console.WriteLine("Introduceti cursul pentru luna " + (i + 1));
                cursuri[i] = float.Parse(Console.ReadLine());
                i++;
            }

            //afisam cursurile
            for (int j = 0; j < cursuri.Length-1; j++)
            {
                Console.Write(cursuri[j] + " - ");
            }
            Console.Write(cursuri[cursuri.Length-1]);
            Console.WriteLine();

            for (int j = 0; j < cursuri.Length; j++)
            {
                if (j < cursuri.Length - 1)
                {
                    Console.Write(cursuri[j] + " - ");
                }
                else
                {
                    Console.Write(cursuri[j]);
                }
            }
            Console.WriteLine();


            //aflam media min si max
            float suma = 0;
            float max = cursuri[0], min = cursuri[0];
            for (int j = 0; j < cursuri.Length; j++)
            {
                suma += cursuri[j];
                if (cursuri[j] < min)
                {
                    min = cursuri[j];
                }
                if (cursuri[j] > max)
                {
                    max = cursuri[j];
                }
            }
            float media = suma / cursuri.Length;
            Console.WriteLine("Media este: " + media);
            //determinam lunile cu cursuri egale cu media, min si max
            int[] cursuriPesteMedie = new int[0];
            int[] cursuriMin = new int[0];
            int[] cursuriMax = new int[0];

            //reutilizam variabila contor de mai sus
            i = 0;
            do
            {
                if (cursuri[i] > media)
                {
                    Array.Resize(ref cursuriPesteMedie, cursuriPesteMedie.Length + 1);
                    cursuriPesteMedie[cursuriPesteMedie.Length - 1] = i + 1;
                }
                if (cursuri[i] == min)
                {
                    Array.Resize(ref cursuriMin, cursuriMin.Length + 1);
                    cursuriMin[cursuriMin.Length - 1] = i + 1;
                }
                if (cursuri[i] == max)
                {
                    Array.Resize(ref cursuriMax, cursuriMax.Length + 1);
                    cursuriMax[cursuriMax.Length - 1] = i + 1;
                }
                i++;
            } while (i < cursuri.Length);

            //afisam cursurile medii
            Console.WriteLine("Cursuri peste medie");
            for (int j = 0; j < cursuriPesteMedie.Length; j++)
            {
                Console.Write(cursuriPesteMedie[j] + " ; ");
            }
            Console.WriteLine();
            //afisam cursurile min
            Console.WriteLine("Cursuri minime");
            for (int j = 0; j < cursuriMin.Length; j++)
            {
                Console.Write(cursuriMin[j] + " ; ");
            }
            Console.WriteLine();

            //afisam cursurile maxime
            Console.WriteLine("Cursuri maxime");
            for (int j = 0; j < cursuriMax.Length; j++)
            {
                Console.Write(cursuriMax[j] + " ; ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
