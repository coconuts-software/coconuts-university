using System;
using PruebasUnitarias.Repository;

namespace PruebasUnitarias
{
    public class Alumno
    {
        private readonly IDataRepository _baseDeDatos;

        public Alumno(IDataRepository repository)
        {
            _baseDeDatos = repository;
        }

        public string ObtenerNombrePorId(int id)
        {
            return _baseDeDatos.ObtenerNombrePorId(id);
        }
    }
}
