using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{

    class Program
    {
        /// <summary>          
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            Console.Title = "Clima";

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Seleccione una operación: ");

                Console.WriteLine("1. Farenheit to Celsios");
                Console.WriteLine("2. Celsios to Farenheit");


                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    ConvertCelsiostToFarenheit();
                }

                if (opcion == "2")
                {
                    ConvertFarenheitToCelsios();
                }


                Console.WriteLine("\nSeleccione una opción: ");
                Console.WriteLine("1. Volver al menú principal");
                Console.WriteLine("2. Salir");

                opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = false;
                }

            }
        }

        static void ConvertCelsiostToFarenheit()
        {
            Console.Clear();
            Console.WriteLine("Convertir a Farenheit");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer Valor");
            double celsios = double.Parse(Console.ReadLine());
            double farenheit = celsios * 1.8 + 32;
            Console.WriteLine("El resultado es: " + farenheit);
            ///return * 1.8 + 32;
        }
        static void ConvertFarenheitToCelsios()
        {
            Console.Clear();
            Console.WriteLine("Convertir a Farenheit");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer Valor");
            double farenheit = double.Parse(Console.ReadLine());
            double celsios = farenheit / 1.8 - 32;
            Console.WriteLine("El resultado es: " + farenheit);
            ///return * 1.8 + 32;
        }
        /// private double ConvertFarenheitToCelsios(double Farenheit) {
        ///return Farenheit / 1.8 - 32;
    }
}
                
            

