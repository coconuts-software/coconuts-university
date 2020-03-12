using System;
namespace PatronMetodoFabrica
{
    public abstract class GerenteRRHH
    {
        // Factory method
        abstract protected IEntrevistador CrearEntrevistador();

        public void TomarEntrevista()
        {
            var entrevistador = this.CrearEntrevistador();
            entrevistador.HacerPreguntas();
        }
    }
}
