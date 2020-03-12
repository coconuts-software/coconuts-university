using System;
namespace PatronMetodoFabrica
{
    public class EmpleadoMarketing : IEntrevistador
    {
        public void HacerPreguntas()
        {
            Console.WriteLine("Preguntar sobre estrategias de marketing");
        }
    }
}
