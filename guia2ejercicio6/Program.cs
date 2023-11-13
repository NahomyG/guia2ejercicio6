using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola a todos, mi nombre es:";
            string nombre = "Gabriela Nahomy Lopez";

            foreach (char letra in texto )
            {
                Console.Write(" "+ letra + " " );
            }

            foreach (char palabras in nombre)
            {
                Console.Write( " " + palabras + " ");
            }

            Console.ReadKey();
        }
    }
}
