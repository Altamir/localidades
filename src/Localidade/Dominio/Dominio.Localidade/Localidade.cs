using Dominio.Localidade.Enum;
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

        public Regiao Regiao { get; protected set; }
        public Estado Estado { get; protected set; }


        public bool Ativa { get; protected set; }
    }
}
