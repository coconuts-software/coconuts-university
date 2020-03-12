using System;
namespace PatronMetodoFabrica
{
    public class Developer : IEntrevistador
    {
        public void HacerPreguntas()
        {
            Console.WriteLine("Preguntar sobre patrones de diseño");
        }
    }
}
