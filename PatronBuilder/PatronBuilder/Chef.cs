using System;
namespace PatronBuilder
{
    public class Chef
    {
        public Chef()
        {
        }

        public void Dirigir(IBuilder ayudante)
        {
            ayudante.HacerMasa();
            ayudante.PonerRelleno();
            ayudante.HacerRepulgue();
        }
    }
}
