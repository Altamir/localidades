using Dominio.Localidade.Enum;
using Dominio.Localidade.Extensions;
using Dominio.Localidades.PlusCode;

namespace Dominio.Localidade
{
    public class Localidade
    {
        public int LocalidadeId { get; protected set; }
        public string Nome { get; protected set; }
        public string Abreviado { get; protected set; }
        public PlusCode PlusCode { get; protected set; }

        public string Code => PlusCode?.Code ?? string.Empty;
        public string Latitude => PlusCode?.Latitude ?? string.Empty;
        public string Longitude => PlusCode?.Logitude ?? string.Empty;

        public Mesorregiao Mesorregiao { get; protected set; }
        public Regiao Regiao => Mesorregiao.Regiao();
        public Estado Estado => Mesorregiao.Estado();
        
        public bool Ativa { get; protected set; }
    }
}