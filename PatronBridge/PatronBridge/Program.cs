using System;

namespace PatronBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITema temaOscuro = new TemaOscuro();
            IPaginaWeb home = new Home(temaOscuro);

            Console.WriteLine(home.ObtenerContenido());
        }
    }
}
