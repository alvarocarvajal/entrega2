using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador2 = 0, contador3 = 0, contador1 = 1;
            float resultado = 0;

            Console.WriteLine("                               ");
            Console.WriteLine(" =============================");
            Console.WriteLine(" Programa Calculador De Numero ");
            Console.WriteLine(" =============================");
            Console.WriteLine("                               ");
            Console.WriteLine("                               ");

            Console.Write(" Digite Cuantos Numeros Desea ingresar: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("                                   ");
            Console.WriteLine("                                   ");

            for (contador1 = 1; contador1 <= numero; contador1++)
            {

                Console.WriteLine("                                  ");
                Console.WriteLine("                                  ");
                Console.Write(" Digite El Numero " + contador1 + " : ");
                resultado = float.Parse(Console.ReadLine());


                Console.WriteLine(" El Numero " + contador1 + " Es: " + resultado);

                if (resultado >= 1000)
                {
                    contador2 = contador2 + 1;
                }

                else
                {
                    contador3 = contador3 + 1;
                }
            }

            Console.WriteLine("                              ");
            Console.WriteLine("                              ");
            Console.WriteLine("                              ");
            Console.WriteLine(" =============================");
            Console.WriteLine(" De Los " + (contador1 - 1) + " Numeros Que Ingreso: ");
            Console.WriteLine(" =============================");
            Console.WriteLine("                                              ");
            Console.WriteLine(" Las Numeros Mayores de 1000 son: " + contador2);
            Console.WriteLine("                                              ");
            Console.WriteLine(" Las Numeros Menores de 1000 son: " + contador3);
            Console.WriteLine("                                              ");


            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
