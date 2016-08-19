using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        private void ConvertCelsiostToFarenheit()
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
        private void ConvertFarenheitToCelsios()
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
///
      ///  }
    }
}
