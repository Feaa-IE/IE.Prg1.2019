using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Rugby
{
    class Program
    {
        static void Main(string[] args)
        {
            const int anStart = 1987;
            int nrEditii = 0;
            for (int i = anStart; i <= DateTime.Today.Year; i += 4)
            {
                Console.WriteLine(i);
                nrEditii++;
            }
            const int totalSpectatori = 14759430;
            double medieSpectatori = totalSpectatori / nrEditii;
            
            Console.WriteLine("Media spectatori " + medieSpectatori);
            Console.ReadKey();
        }
    }
}
