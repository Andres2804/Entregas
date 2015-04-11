using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0, contador=0;
            int[] vector; //clase array
            Console.WriteLine("Digite numero de elementos del vector: ");
            numero = int.Parse(Console.ReadLine());
            vector = new int[numero]; //instanciando objeto array
            for (int cont = 0; cont < numero; cont++)
            {
                Console.WriteLine("Digite elemento del vector: ");
                vector[cont] = int.Parse(Console.ReadLine());
            }
            foreach(int recorrido in vector)
            {
                if (recorrido > 100)
                {
                    contador++;
                }
            }
            Console.WriteLine("Los numeros superiores a 100 son: " + contador);
            Console.ReadKey();
        }
    }
}
