using System;
using System.Collections.Generic;
using PruebasUnitarias;
using Xunit;

namespace Proyecto.Tests
{
    public class AutomovilTests
    {
        [Fact]
        public void CargarNombre_StringVacio_DeberiaArrojarExcepcion()
        {
            // Arrange
            var automovil = new Automovil();

            // Act
            
            // Assert
            Assert.Throws<Exception>(() => automovil.CargarNombre(""));
        }

        [Fact]
        public void AgregarAutomovilAListaAutomoviles_Automovil_DeberiaFuncionar()
        {
            // Arrange
            Automovil automovil = new Automovil();
            List<Automovil> automoviles = new List<Automovil>();

            // Act
            Automovil.AgregarAutomovilAListaAutomoviles(automoviles, automovil);

            // Assert
            Assert.True(automoviles.Count == 1);
            Assert.Contains<Automovil>(automovil, automoviles);
        }

        [Theory]
        [InlineData("Ford","","Modelo")]
        [InlineData("", "Ka", "Marca")]
        public void AgregarAutomovilAListaAutomoviles_AutomovilIncompleto_DeberiaFallar(string marca, string modelo, string param)
        {
            // Arrange
            Automovil automovil = new Automovil() { Marca = marca, Modelo=modelo };
            List<Automovil> automoviles = new List<Automovil>();

            // Act

            // Assert
            Assert.Throws<ArgumentException>(param, () => Automovil.AgregarAutomovilAListaAutomoviles(automoviles, automovil));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void NecesitaRevision_AntiguedadMenorA2_DevuelveFalso(int antiguedad)
        {
            // Arrange

            // Act
            var resultado = Automovil.NecesitaRevision(antiguedad);

            // Assert
            Assert.False(resultado, $"{antiguedad} no deberia necesitar revision");
        }
    }
}
