using Dominio.Localidade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Localidade.Extensions
{
    public static class RegiaoExtension
    {
        public static Regiao GetRegiao(this Estado estado)
        {
            var value = (int)estado;
            var result = (Regiao)((int)value / 10);
            return result;
        }

        public static IList<Estado> Estados(this Regiao re)
        {
            switch (re)
            {
                case Regiao.Norte:
                    return new List<Estado> { Estado.RO, Estado.AC, Estado.AM, Estado.RR, Estado.PA, Estado.AP, Estado.TO };
                case Regiao.Nordeste:
                    return new List<Estado> { Estado.MA, Estado.PI, Estado.CE, Estado.RN, Estado.PB, Estado.PE, Estado.AL, Estado.SE, Estado.BA };
                case Regiao.Sudeste:
                    return new List<Estado> { Estado.MG, Estado.ES, Estado.RJ, Estado.SP };
                case Regiao.Sul:
                    return new List<Estado> { Estado.PR, Estado.SC, Estado.RS };
                case Regiao.Centro_Oeste:
                    return new List<Estado> { Estado.MS, Estado.MT, Estado.GO, Estado.DF };
                default:
                    return new List<Estado>();
            }
        }
    }
}
