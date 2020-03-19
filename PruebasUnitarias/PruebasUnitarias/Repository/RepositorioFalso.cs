using System;
namespace PruebasUnitarias.Repository
{
    public class RepositorioFalso : IDataRepository
    {
        public RepositorioFalso()
        {
        }

        public string ObtenerNombrePorId(int id)
        {
            string Nombre = "";

            if (id == 1)
                Nombre = "Pepe";

            if (id == 2)
                Nombre = "Manolo";

            return Nombre;
        }
    }
}
