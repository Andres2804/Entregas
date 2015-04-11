using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            Console.WriteLine("Digite numero en letras: ");
            num = Console.ReadLine();
            switch (num.ToUpper())
            {
                case "UNO":
                    Console.WriteLine("1");
                    break;
                case "DOS":
                    Console.WriteLine("2");
                    break;
                case "TRES":
                    Console.WriteLine("3");
                    break;
                 case "CUATRO":
                    Console.WriteLine("4");
                    break;
                 case "CINCO":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Fuera de rango");
                    break;

            }
            Console.ReadKey();
        }
    }
}
