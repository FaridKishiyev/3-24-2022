using System;
using casding.Models;

namespace casding
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(100);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degre);
        }
    }

    
}
