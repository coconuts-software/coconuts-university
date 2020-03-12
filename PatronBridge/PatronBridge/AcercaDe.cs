using System;
namespace PatronBridge
{
    public class AcercaDe : IPaginaWeb
    {
        protected ITema _tema;
        
        public AcercaDe(ITema tema)
        {
            _tema = tema;
        }

        public string ObtenerContenido()
        {
            return $"Pagina acerca de en {_tema.ObtenerColor()}";
        }
    }
}
