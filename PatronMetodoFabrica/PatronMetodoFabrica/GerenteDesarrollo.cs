using System;
namespace PatronMetodoFabrica
{
    public class GerenteDesarrollo : GerenteRRHH
    {
        protected override IEntrevistador CrearEntrevistador()
        {
            return new Developer();
        }
    }
}
