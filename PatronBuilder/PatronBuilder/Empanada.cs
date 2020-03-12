using System;
namespace PatronBuilder
{
    public class Empanada
    {
        private IRelleno _relleno;
        private IRepulgue _repulgue;
        private Masa _masa;

        public void HacerMasa(Masa masa)
        {
            _masa = masa;
            _masa.HacerMasa();
        }

        public void PonerRelleno(IRelleno relleno)
        {
            _relleno = relleno;
            Console.WriteLine("Se le puso:{0}", _relleno.TipoRelleno());
        }

        public void HacerRepulgue(IRepulgue repulgue)
        {
            _repulgue = repulgue;
            Console.WriteLine("Se le puso:{0}", _repulgue.TipoRepulgue());
        }

        public void VerEmpanada()
        {
            Console.WriteLine("La empanada está lista y tiene {0} y {1}", _relleno.TipoRelleno(), _repulgue.TipoRepulgue());
        }
    }
}
