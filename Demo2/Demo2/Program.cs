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

        private double ConvertCelsiostToFarenheit(double celsios) {
            return celsios * 1.8 + 32;
        }

        private double ConvertFarenheitToCelsios(double Farenheit) {
            return Farenheit / 1.8 - 32;
        }
    }
}
