using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEach
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("                 ");
            Console.WriteLine(" ================");
            Console.WriteLine(" Programa ForEach ");
            Console.WriteLine(" ================");
            Console.WriteLine("                 ");
            Console.WriteLine("                 ");

            int numero = 0, contador=0;
            int[] vector; // Clase Array

            Console.Write(" Digite El Numero Elementos Que Va Contener El Vector: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("                 ");
            Console.WriteLine("                 ");

            vector = new int[numero]; // Instanciando objeto array

            for(int contador1=0; contador1<numero; contador1++)
            {
                Console.Write(" Ingrese Los Elementos Del Vector: ");
                vector[contador1] = int.Parse(Console.ReadLine());
            }

            foreach (int recorrido in vector)
            {
                if (recorrido > 100)
                {
                    contador = contador + 1;
                }
            }

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Los Numero Mayores A 100 Dentro Del Vector Son: " + contador);


            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine(" Elaboro <<Ing Alvaro Carvajal>> ");
            Console.Write(" Universidad Simon Bolivar - Ext. Cucuta ");
            Console.ReadKey();

        }
    }
}
