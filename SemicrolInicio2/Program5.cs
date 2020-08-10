using SemicrolInicio2.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SemicrolInicio2
{
    class Program5
    {

        

        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>
            {
                new Persona("pepe", 30),
                new Persona("ana", 40),
                new Persona("maria", 10),
                new Persona("andres", 50)
            };

            var resultado = lista.Where((personita) => personita.Edad >= 40);

            foreach(Persona p in resultado)
            {
                Console.WriteLine(p.Nombre);
            }

            Console.ReadLine();
        }

        
    }
}
