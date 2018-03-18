using Dominio.Localidade.Enum;

namespace Dominio.Localidade.Extensions
{
    public static class EstadoExtension
    {

        public static string Name(this Estado estado)
        {
            switch (estado)
            {
                case Estado.RO: return "Rondônia";                   
                case Estado.AC: return "Acre";
                case Estado.AM: return "Amazonas";
                case Estado.RR:  return "Roraima";
                case Estado.PA: return "Pará";
                case Estado.AP: return "Amapá";
                case Estado.TO: return "Tocantins";                   
                case Estado.MA: return "Maranhão";
                case Estado.PI: return "Piauí";                  
                case Estado.CE: return "Ceará";
                case Estado.RN: return "Rio Grande do Norte";
                case Estado.PB: return "Paraíba";
                case Estado.PE: return "Pernambuco";
                case Estado.AL: return "Alagoas";
                case Estado.SE:  return "Sergipe";
                case Estado.BA: return "Bahia";
                case Estado.MG:  return "Minas Gerais";
                case Estado.ES:  return "Espírito Santo";
                case Estado.RJ: return "Rio de Janeiro";
                case Estado.SP: return "São Paulo";
                case Estado.PR: return "Paraná";
                case Estado.SC: return "Santa Catarina";
                case Estado.RS:return "Rio Grande do Sul";
                case Estado.MS: return "Mato Grosso do Sul";
                case Estado.MT: return "Mato Grosso";
                case Estado.GO: return "Goiás";
                case Estado.DF: return "Distrito Federal";
                default: return "Indefinido";
            }
        }

    }
}
