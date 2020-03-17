using System;
namespace PruebasUnitarias
{
    public class Reserva
    {
        public User HechaPor { get; set; }

        public bool PuedeSerCanceladaPor(User usuario)
        {
            return usuario.EsAdmin || HechaPor == usuario;
        }
    }

    public class User
    {
        public bool EsAdmin { get; set; }
    }
}
