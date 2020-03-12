using System;
namespace PatronMetodoFabrica
{
    public class GerenteMarketing : GerenteRRHH
    {
        protected override IEntrevistador CrearEntrevistador()
        {
            return new EmpleadoMarketing();
        }
    }
}
