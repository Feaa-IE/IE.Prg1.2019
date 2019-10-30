using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Prg1.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("Introduceti a");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduceti b");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduceti operatorul");
                string op = Console.ReadLine();

                double rezultat = 0;
                bool opValida = true;
                switch (op)
                {
                    case "+":
                        rezultat = a + b;
                        break;
                    case "-":
                        rezultat = a - b;
                        break;
                    case "*":
                        rezultat = a * b;
                        break;
                    case "/":
                        rezultat = a / b;
                        break;
                    default:
                        opValida = false;
                        break;
                }
                if (opValida)
                {
                    Console.WriteLine($"{a}{op}{b}={rezultat}");
                }
                else
                {
                    Console.WriteLine("Operatie invalida");
                }

                keyInfo = Console.ReadKey();
            } 
            while (keyInfo.Key == ConsoleKey.Escape);
        }
    }
}
