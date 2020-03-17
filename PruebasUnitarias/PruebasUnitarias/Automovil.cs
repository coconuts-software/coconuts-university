using System;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    public class Automovil
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void CargarNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new Exception("Nombre no puede ser vacío");
        }

        public static void AgregarAutomovilAListaAutomoviles(List<Automovil> automoviles, Automovil automovil)
        {
            if (string.IsNullOrEmpty(automovil.Marca))
                throw new ArgumentException("Has pasado un parametro inválido", "Marca");

            if (string.IsNullOrEmpty(automovil.Modelo))
                throw new ArgumentException("Has pasado un parametro inválido", "Modelo");

            automoviles.Add(automovil);
        }

        public static bool NecesitaRevision(int antiguedad)
        {
            if (antiguedad < 2)
            {
                return false;
            }
            return true;
        }
    }
}
