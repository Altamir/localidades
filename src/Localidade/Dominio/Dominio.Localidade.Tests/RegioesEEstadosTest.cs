using System.Collections.Generic;
using System.Linq;
using Dominio.Localidade.Enum;
using Dominio.Localidade.Extensions;
using NUnit.Framework;

namespace Dominio.Localidade.Tests
{
    [TestFixture]
    public class RegioesEEstadosTest
    {
        [TestCase(Estado.TO, ExpectedResult = Regiao.Norte)]
        [TestCase(Estado.CE, ExpectedResult = Regiao.Nordeste)]
        [TestCase(Estado.SP, ExpectedResult = Regiao.Sudeste)]
        [TestCase(Estado.RS, ExpectedResult = Regiao.Sul)]
        [TestCase(Estado.DF, ExpectedResult = Regiao.Centro_Oeste)]       
        public Regiao Obtem_regiao_do_estado(Estado estado)
        {
            return estado.GetRegiao();
        }


        [Test]
        public void Obtem_Estados_da_regiao_Sul()
        {
            List<Estado> esperado = new List<Estado> { Estado.PR, Estado.SC, Estado.RS };
            CollectionAssert.AreEqual(esperado, Regiao.Sul.Estados().ToList());
        }
    }
}
