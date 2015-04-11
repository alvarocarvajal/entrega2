using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
            float promedio = 0, numero = 0, suma=0;

            Console.WriteLine("                    ");
            Console.WriteLine(" ===================");
            Console.WriteLine(" Programa Do While 2 ");
            Console.WriteLine(" ===================");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");

            do
            {
                Console.Write(" Digite Un Numero: ");
                numero = float.Parse(Console.ReadLine());

                if (numero == 0)
                    break;

                contador = contador + 1;
                suma = suma + numero;

                Console.WriteLine("                                   ");
                Console.WriteLine("                                   ");


            }
            while (numero != 0);


            promedio = (suma / contador);

            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.Write(" El Promedio De Los Numero Ingresados Fue: " + promedio);
            Console.WriteLine("                                          ");
            


            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
