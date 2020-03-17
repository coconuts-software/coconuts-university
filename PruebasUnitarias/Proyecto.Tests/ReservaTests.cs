using System;
using PruebasUnitarias;
using Xunit;

namespace Proyecto.Tests
{
    public class ReservaTests
    {
        [Fact]
        public void PuedeSerCanceladaPor_Admin_DevuelveVerdadero()
        {
            // Arrange
            var reserva = new Reserva();
            User usuario = new User { EsAdmin = true };

            // Act
            var resultado = reserva.PuedeSerCanceladaPor(usuario);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void PuedeSerCanceladaPor_MismoUsuarioReserva_DevuelveVerdadero()
        {
            // Arrange
            var usuario = new User();
            var reserva = new Reserva { HechaPor = usuario };

            // Act
            var resultado = reserva.PuedeSerCanceladaPor(usuario);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void PuedeSerCanceladaPor_DistintoUsuarioReserva_DevuelveFalso()
        {
            // Arrange
            var reserva = new Reserva { HechaPor = new User() };

            // Act
            var resultado = reserva.PuedeSerCanceladaPor(new User());

            // Assert
            Assert.False(resultado);
        }
    }
}
