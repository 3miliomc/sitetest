using SiteTest.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SiteTest.Services.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly ServicePersona _servicioPersona;
        public PrimeService_IsPrimeShould()
        {
            _servicioPersona = new ServicePersona();
        }

        [Fact]
        public void ReturnTruePersonaPorRut()
        {
            var result = _servicioPersona.ObtenerPersonaPor("16385");

            Assert.True(result.Rut == "16385993-9", $"El rut coincide correctamente");
        }
    }
}
