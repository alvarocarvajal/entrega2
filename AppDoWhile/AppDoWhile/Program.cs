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
            int numero = 0, suma=0;
            float promedio = 0;

            Console.WriteLine("                    ");
            Console.WriteLine(" ===================");
            Console.WriteLine(" Programa Do While 2 ");
            Console.WriteLine(" ===================");
            Console.WriteLine("                   ");
            Console.WriteLine("                   ");

            do
            {
                Console.Write(" Digite Un Numero: ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero == 0)
                    break;

                suma = suma + numero;

                Console.WriteLine("                                   ");
                Console.WriteLine("                                   ");


            }
            while (numero != 0);


            promedio = (suma / numero);

            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.Write(" La Suma De Los Numero Ingresados Fue: " + promedio);
            Console.WriteLine("                                          ");
           // Console.WriteLine("                                          ");

            if (suma == 0)
            {
                Console.WriteLine("                          ");
                Console.WriteLine("                          ");
                Console.Write(" ¡¡¡ La Suma Es Igual A 0 !!! ");
            }

            else if (suma > 0)
            {
                Console.WriteLine("                          ");
                Console.WriteLine("                          ");
                Console.Write(" ¡¡¡ La Suma Es mayor A 0 !!! ");
            }
            else
            {
                Console.WriteLine("                          ");
                Console.WriteLine("                          ");
                Console.Write(" ¡¡¡ La Suma Es Menor A 0 !!! ");
            }

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
