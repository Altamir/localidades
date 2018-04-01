using Dominio.Localidade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Localidade.Extensions
{
    public static class MesorregiaoExtension
    {
        public static Regiao Regiao(this Mesorregiao mesorregiao)
        {
            var value = (int)mesorregiao;
            var result = (Regiao)((int)value / 10000);
            return result;
        }

        public static Estado Estado(this Mesorregiao mesorregiao)
        {
            var value = (int)mesorregiao;
            var result = (Estado)((int)value / 1000);
            return result;
        }
    }
}
