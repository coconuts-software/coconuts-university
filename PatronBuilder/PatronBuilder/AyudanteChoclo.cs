using System;
namespace PatronBuilder
{
    public class AyudanteChoclo : IBuilder
    {
        private Empanada empanada = new Empanada();

        public AyudanteChoclo()
        {
        }

        public void HacerMasa()
        {
            empanada.HacerMasa(new Masa());
        }

        public void HacerRepulgue()
        {
            empanada.HacerRepulgue(new RepulgueChoclo());
        }

        public void PonerRelleno()
        {
            empanada.PonerRelleno(new RellenoChoclo());
        }

        public Empanada ObtenerEmpanada()
        {
            return empanada;
        }
    }
}
