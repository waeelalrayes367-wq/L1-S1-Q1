using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_S1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculate");
            Console.WriteLine("num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("pross");
            int pross = int.Parse(Console.ReadLine());
            switch (pross)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
            }

        }
    }
}
