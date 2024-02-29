using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el Primer numero ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el Segundo numero ");
            int num2 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("El resultado de la suma es " + (num1 + num2 ));
            Console.ReadKey();
        }
    }
}
