using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.NotaFinala
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pragAbsolvire = 5;

            Console.WriteLine("Nota test bb 1:");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota test bb 2:");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota test practic:");
            float notaTestPractic = Convert.ToSingle(Console.ReadLine());

            float notaFinala = nota1 * 0.3f + nota2 * 0.3f + notaTestPractic * 0.4f;
            if (notaFinala >= pragAbsolvire && notaTestPractic >= pragAbsolvire)
            {
                Console.WriteLine("Admis cu " + (notaFinala - pragAbsolvire) + " mai mult fata de minim");
            }
            else
            {
                Console.WriteLine("Respins");
            }
            Console.ReadKey();
        }
    }
}
