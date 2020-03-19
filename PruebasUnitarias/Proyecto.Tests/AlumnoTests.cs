using System;
using Moq;
using PruebasUnitarias;
using PruebasUnitarias.Repository;
using Xunit;

namespace Proyecto.Tests
{
    public class AlumnoTests
    {
        [Fact]
        public void ObtenerNombrePorId()
        {
            // Arrange
            var mock = new Mock<IDataRepository>();
            mock.Setup(p => p.ObtenerNombrePorId(1)).Returns("Pepe");
            var alumno = new Alumno(mock.Object);

            // Act
            string resultado = alumno.ObtenerNombrePorId(1);

            // Assert
            Assert.Equal("Pepe", resultado);
        }
    }
}
