using System;
namespace PatronBuilder
{
    public interface IBuilder
    {
        void HacerMasa();
        void PonerRelleno();
        void HacerRepulgue();
        Empanada ObtenerEmpanada();
    }
}
