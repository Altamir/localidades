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
        [Test]       
        public void Obtem_regiao_do_estado()
        {
            Estado estado = Estado.CE;
            Assert.AreEqual(Regiao.Nordeste, estado.GetRegiao());
             estado = Estado.RS;
            Assert.AreEqual(Regiao.Sul, estado.GetRegiao());
             estado = Estado.DF;
            Assert.AreEqual(Regiao.Centro_Oeste, estado.GetRegiao());
        }


        [Test]
        public void Obtem_Estados_de_Uma_regiao()
        {
            List<Estado> esperado = new List<Estado>{ Estado.PR, Estado.SC,  Estado.RS };
            CollectionAssert.AreEqual(esperado, Regiao.Sul.Estados().ToList());
        }
    }
}
