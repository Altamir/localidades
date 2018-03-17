using System;
using Dominio.Localidades.PlusCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlusCode.Tests
{
    [TestClass]
    public class PLusCodeTest
    {
        [TestMethod]
        public void TentaCriarCodi_retornaInvalido()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder("XQ5R + G7");
            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void TentaCriarCodi_retorna_valido()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder("48XCXQCC+WG");
            Assert.IsTrue(result.HasValue);
            Assert.AreEqual("-51,22875", result.Value.Latitude);
            Assert.AreEqual("-30,02775", result.Value.Logitude);
        }

        [TestMethod]
        public void TentaCriarCodi_retorna_validoasd()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder(-51.2287, -30.0277);
            Assert.IsTrue(result.HasValue);
            Assert.AreEqual("48XCXQCC+WG", result.Value.Code);
          
        }
    }
}
