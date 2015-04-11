using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9999
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0, suma=0;
            do
            {

                Console.WriteLine("Digite numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 9999)
                {
                    break;
                }

                suma += numero;

            }

            while (numero != 9999);
            Console.WriteLine("la suma: " + suma);
            if (suma == 0)
            {
                Console.WriteLine("la suma es igual a cero");
            }

            else if (suma > 0)
            {
                Console.WriteLine("La suma es mayor a cero");
            }

            else
            {
                Console.WriteLine("La suma es menor a cero");
            }
            Console.ReadKey();
        }
    }
}
