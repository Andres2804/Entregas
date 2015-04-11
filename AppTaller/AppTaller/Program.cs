using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaller
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, suma, diferencia, producto, division;

            Console.WriteLine("Ingrese primer numero: ");
            num1= float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                suma=num1+num2;
                Console.WriteLine("La suma de los numeros es: " + suma);
                diferencia = num1 - num2;
                Console.WriteLine("La diferencia es: "+ diferencia);
            }
            else
            {
                producto=num1*num2;
                Console.WriteLine("El producto es: "+ producto);
                division=num1/num2;
                Console.WriteLine("La division es: "+division);


            }

            Console.ReadKey();
        }
    }
}
