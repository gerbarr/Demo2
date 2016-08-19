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
                    ConvertCelsiostoFarenheit();
                }

                if (opcion == "2")
                {
                    ConvertFarenheittoCelsios();
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
    }
}
                
            

