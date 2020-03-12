using System;

namespace PatronMetodoFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var devManager = new GerenteDesarrollo();
            devManager.TomarEntrevista(); 

            var marketingManager = new GerenteMarketing();
            marketingManager.TomarEntrevista();
        }
    }
}
