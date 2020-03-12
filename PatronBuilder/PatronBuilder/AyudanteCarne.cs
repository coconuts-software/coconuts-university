using System;
namespace PatronBuilder
{
    public class AyudanteCarne : IBuilder
    {
        private Empanada empanada = new Empanada();

        public AyudanteCarne()
        {
        }

        public void HacerMasa()
        {
            empanada.HacerMasa(new Masa());
        }

        public void HacerRepulgue()
        {
            empanada.HacerRepulgue(new RepulgueCarne());
        }

        public void PonerRelleno()
        {
            empanada.PonerRelleno(new RellenoCarne());
        }

        public Empanada ObtenerEmpanada()
        {
            return empanada;
        }
    }
}
