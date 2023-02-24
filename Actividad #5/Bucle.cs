using System;

namespace Proyec 
{
    class Proyec
    {
        static void Main(string[] args)
        {
            int resultado, numero, numero1;
            Console.WriteLine("ingrese el primer rango de numero ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo rango de numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i <= numero1; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}