using System;

namespace Mayor
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string linea = Console.ReadLine();
            int num1 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            int num2 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            int num3 = int.Parse(linea);

            if (num1 > num2 && num1 > num3)
            {
                Console.Write(num1);
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }

            Console.ReadKey();
        }
    }
}