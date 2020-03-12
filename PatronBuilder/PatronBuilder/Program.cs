using System;

namespace PatronBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();

            IBuilder ayudanteCarne = new AyudanteCarne();

            chef.Dirigir(ayudanteCarne);

            Empanada empanada1 = ayudanteCarne.ObtenerEmpanada();

            empanada1.VerEmpanada();

            Console.WriteLine("--------");
        }
    }
}
