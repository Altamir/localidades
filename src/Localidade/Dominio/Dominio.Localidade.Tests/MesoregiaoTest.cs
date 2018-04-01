using System;
using System.Collections.Generic;
using Dominio.Localidade.Enum;
using Dominio.Localidade.Extensions;
using NUnit.Framework;

namespace Dominio.Localidade.Tests
{
    [TestFixture]
    public class MesoregiaoTest
    {
        [TestCase(Mesorregiao.Madeira_Guapore, ExpectedResult = Regiao.Norte)]
        [TestCase(Mesorregiao.Centro_Norte_Baiano, ExpectedResult = Regiao.Nordeste)]
        [TestCase(Mesorregiao.Metropolitana_do_Rio_de_Janeiro, ExpectedResult = Regiao.Sudeste)]
        [TestCase(Mesorregiao.Metropolitana_de_Porto_Alegre, ExpectedResult = Regiao.Sul)]
        [TestCase(Mesorregiao.Sul_Goiano, ExpectedResult = Regiao.Centro_Oeste)]
        public Regiao Obtem_regiao_dada_uma_messoregiao(Mesorregiao mesorregiao)
        {
            return mesorregiao.Regiao();
        }

        [TestCase(Mesorregiao.Madeira_Guapore, ExpectedResult = Estado.RO)]
        [TestCase(Mesorregiao.Centro_Norte_Baiano, ExpectedResult = Estado.BA)]
        [TestCase(Mesorregiao.Metropolitana_do_Rio_de_Janeiro, ExpectedResult = Estado.RJ)]
        [TestCase(Mesorregiao.Metropolitana_de_Porto_Alegre, ExpectedResult = Estado.RS)]
        [TestCase(Mesorregiao.Sul_Goiano, ExpectedResult = Estado.GO)]
        public Estado Obtem_estado_dada_uma_messoregiao(Mesorregiao mesorregiao)
        {
            return mesorregiao.Estado();
        }

    }
}
