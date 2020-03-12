using System;
namespace PatronBridge
{
    public class Contacto : IPaginaWeb
    {
        protected ITema _tema;
        
        public Contacto(ITema tema)
        {
            _tema = tema;
        }

        public string ObtenerContenido()
        {
            return $"Pagina contacto en {_tema.ObtenerColor()}";
        }
    }
}
