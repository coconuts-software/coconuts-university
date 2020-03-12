using System;
namespace PatronBridge
{
    public class Home : IPaginaWeb
    {
        protected ITema _tema;
        
        public Home(ITema tema)
        {
            _tema = tema;
        }

        public string ObtenerContenido()
        {
            return $"Pagina principal en {_tema.ObtenerColor()}";
        }
    }
}
