using System;
namespace PatronBuilder
{
    public class AyudanteVerdura : IBuilder
    {
        private Empanada empanada = new Empanada();

        public AyudanteVerdura()
        {
        }

        public void HacerMasa()
        {
            empanada.HacerMasa(new Masa());
        }

        public void HacerRepulgue()
        {
            empanada.HacerRepulgue(new RepulgueVerdura());
        }

        public void PonerRelleno()
        {
            empanada.PonerRelleno(new RellenoVerdura());
        }

        public Empanada ObtenerEmpanada()
        {
            return empanada;
        }
    }
}
