using Dominio.Localidade.Enum;

namespace Dominio.Localidade.Extensions
{
    public static class MesorregiaoExtension
    {
        public static Regiao Regiao(this Mesorregiao mesorregiao)
        {
            var value = (int)mesorregiao;
            var result = (Regiao)(value / 10000);
            return result;
        }

        public static Estado Estado(this Mesorregiao mesorregiao)
        {
            var value = (int)mesorregiao;
            var result = (Estado)(value / 1000);
            return result;
        }
    }
}
