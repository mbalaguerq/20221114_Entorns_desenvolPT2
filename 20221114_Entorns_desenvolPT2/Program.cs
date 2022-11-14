using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221114_Entorns_desenvolPT2
{
    internal class Program
    {
        static void Main(string[] args)

        //Utilizando Visual Studio o Eclipse realiza un programa en el que incluya como mínimo un bucle,
        //condiciones y que muestre información por pantalla.

        {
            int nValors;
            int i = 1;
            int numeros = 0;
            int suma = 0;

            Console.WriteLine("Bon dia, quants valors introduiràs?: ");
            nValors = int.Parse(Console.ReadLine());

            do
            {
                if (nValors < 0)
                {
                    Console.WriteLine("Que me estás contando!");

                    Console.WriteLine("Quants valors introduiràs?: ");
                    nValors = int.Parse(Console.ReadLine());
                }
            }
            while (nValors < 0);
                    
            if (nValors > 0)
            {

                while (i <= nValors)
                {
                    

                    Console.WriteLine("introdueix el valor N" + i);
                    numeros = int.Parse(Console.ReadLine());

                    suma += numeros;
                    i++;
                }
                Console.WriteLine("La suma dels números introduits és: " + suma);
            }

        }
    }
}
