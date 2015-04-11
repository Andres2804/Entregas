using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App100num
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cnumeros,numero,contador2=0,contador3=0;
            Console.WriteLine("Digite cantidad de numeros: ");
            Cnumeros = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= Cnumeros; contador++)
            {
                Console.WriteLine("Digite numero:" + contador);
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine(" El numero " + contador + "es " + numero );

                if (numero >= 1000)
                {
                    contador2 = contador2 + 1;
                }

                else
                {
                    contador3 = contador3 + 1;
                }

            }

            Console.WriteLine("Los valores mayores o iguales a 1000 son: " + contador2);
            Console.ReadKey();
        }
    }
}
