using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.Write("Ingresa un número: ");
                int num = int.Parse(Console.ReadLine());
                int j = 0;
                while (j < num)
                {
                    int k = 0;
                    while (k < num * 2)
                    {
                        Console.Write("*");
                        k++;
                    }
                    Console.WriteLine();
                    j++;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}