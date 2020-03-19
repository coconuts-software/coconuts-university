using System;
using Refactoring;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var mamifero = new Pajaro();
            Console.WriteLine(mamifero.ObtenerPiel());
        }
    }
}
