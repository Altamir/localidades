﻿using System;
using Dominio.Localidades.PlusCode;
using NUnit.Framework;

namespace PlusCode.Tests
{
    [TestFixture]
    public class PLusCodeTest
    {
        [Test]
        public void TentaCriarCodi_retornaInvalido()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder("XQ5R + G7");
            Assert.IsFalse(result.HasValue);
        }

        [Test]
        public void TentaCriarCodi_retorna_valido()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder("48XCXQCC+WG");
            Assert.IsTrue(result.HasValue);
            Assert.AreEqual("-51,22875", result.Value.Latitude);
            Assert.AreEqual("-30,02775", result.Value.Logitude);
        }

        [Test]
        public void TentaCriarCodi_retorna_validoasd()
        {
            IPlusCodeBuilder plusCodeBuilder = new PlusCodeBuilder();
            var result = plusCodeBuilder.Builder(-51.2287, -30.0277);
            Assert.IsTrue(result.HasValue);
            Assert.AreEqual("48XCXQCC+WG", result.Value.Code);
          
        }
    }
}
