using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Excepciones_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Indique un numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.Pow(num1, 2));
                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.WriteLine("El tipo de dato debe ser un numero entero");
            }
            catch(OverflowException)
            {
                Console.WriteLine("El valor asignado es demasiado grande para el tipo de dato");
            }
            Console.ReadKey();
        }
    }
}
