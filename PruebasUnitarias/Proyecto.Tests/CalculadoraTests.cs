using System;
using PruebasUnitarias;
using Xunit;

namespace Proyecto.Tests
{
    public class CalculadoraTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Sumar_ValoresSimples_DeberiaCalcularBien(double x, double y, double esperado)
        {
            // Arrange

            // Act
            double resultado = Calculadora.Sumar(x, y);

            // Assert
            Assert.Equal(esperado, resultado);
        }


        [Fact]
        public void Dividir_PorCero_DevuelveCero()
        {
            // Arrange
            double esperado = 0;

            // Act
            double resultado = Calculadora.Dividir(5, 0);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
