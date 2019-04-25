using System;

namespace Procesos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            
            //Excepciones
            
            int valor = 10;
            Console.WriteLine(valor/0);
            Excepción no controlada: System.DivideByZeroException: Intento de dividir por cero.
            
             */

            // PARSE

            //string valor = "a";
            //int suma = 4 + int.Parse(valor);
            //Console.WriteLine(suma);


            //string numeroGrande = "99999999999";
            //Console.WriteLine(int.Parse(numeroGrande));

            int valor = 10;
            try
            {
                Console.WriteLine(valor / 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No se puede dividir un numero sobre 0");
            }

           

            string valor0 = "a";


            try
            {
                int suma = 4 + int.Parse(valor0);
                Console.WriteLine(suma);
            }
            catch (FormatException e)
            {
                Console.WriteLine("No se puede convertir una letra a numero");
            }
            catch (Exception r) {
                Console.WriteLine("Más de una excepcion");
            }


            try
            {
                string numeroGrande = "99999999999";
                Console.WriteLine(int.Parse(numeroGrande));
            }
            catch (Exception e)
            {
                
                Console.WriteLine("El numero no es correcto para el tipo de dato");
            }


            Console.ReadLine();
        }
    }
}
