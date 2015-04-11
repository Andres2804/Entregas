using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas,contador2=0, contador3=0;
            float nota = 0;
            Console.WriteLine("Digite numero de notas: ");
            notas = int.Parse(Console.ReadLine());
            for (int contador = 1; contador <= notas; contador++)
            {
                Console.WriteLine("Digite nota:" + contador);
                nota = float.Parse(Console.ReadLine());
               // suma = suma + nota;
          
                Console.WriteLine("la nota " + contador + " es: " + nota);

                if (nota >= 7)
                {
                    contador2 = contador2 + 1;
                }

                else
                {
                    contador3 = contador3 + 1;
                }
            }

            Console.WriteLine("Las notas mayores de 7 son: " + contador2);
            Console.WriteLine("Las notas menores de 7 son: " + contador3);
            Console.ReadKey();
        }

        
    }
}
