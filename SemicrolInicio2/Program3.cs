using SemicrolInicio2.Clases;
using System;
using System.IO;

namespace SemicrolInicio2
{
    class Program3
    {

        delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {

            Operacion o = new Operacion(Sumar);
            int resultado = o(2, 2);
            Console.WriteLine(resultado);



            Console.ReadLine();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
