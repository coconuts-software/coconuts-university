using System;

namespace PatronStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivo = "miarchivo";

            var compresor = new Compresor(new CompresorZip());
            Console.WriteLine(compresor.Comprimir(archivo));


            compresor = new Compresor(new Compresor7z());
            Console.WriteLine(compresor.Comprimir(archivo));
        }
    }
}
