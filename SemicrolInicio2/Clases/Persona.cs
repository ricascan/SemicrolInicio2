using System;
using System.Collections.Generic;
using System.Text;

namespace SemicrolInicio2.Clases
{
    class Persona
    {
        public String Nombre { get; set; }
        private int _edad;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public int Edad
        
        {
            get
            {
                return _edad;
            }
            set
            {
                if(value < 0 || value > 120)
                {
                    throw new Exception("La edad tiene que estar comprendida entre 0 y 120");
                }
                else
                {
                    _edad = value;
                }
            }

        }
    }
}
