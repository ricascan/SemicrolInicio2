using SemicrolInicio2.Clases;
using System;
using System.IO;

namespace SemicrolInicio2
{
    class Program4
    {

        public delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {
            Func<int, int, int> funcion = (a, b) => a*b;
            OperarPorPantalla(2, 3, funcion);
            OperarPorPantalla(2, 3, (a, b) => a/b);
            Console.ReadLine();
        }

        public static void OperarPorPantalla(int a, int b, Func<int, int, int> tipoOperacion)
        {
            Console.WriteLine("***********");
            Console.WriteLine(tipoOperacion(a, b));
            Console.WriteLine("***********");
        }
        public static int Sumar(int a, int b) => a + b;
        public static int Restar(int a, int b) => a - b;
    }
}
