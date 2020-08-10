using System;
using System.IO;

namespace SemicrolInicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\formacion\Desktop\prueba.txt";
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("No se ha encontrado la ruta especificada.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Que mal vamos.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido una excepción.");
            }
            /*
            finally
            {                
                Console.WriteLine("Todo terminó.");
            }
            */
            Console.ReadLine();
        }
    }
}
