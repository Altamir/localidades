using Dominio.Localidades.PlusCode;

namespace Dominio.Localidades.PlusCode
{
    public class PlusCode : IPlusCode
    {
        public string Code => code;
        public string Latitude => latitude;
        public string Logitude => longitude;
        public int codeLengt => codeL;
        string code, latitude, longitude;
        int codeL;

        public PlusCode(string code, string latitude, string longitude, int codeL)
        {
            this.code = code;
            this.latitude = latitude;
            this.longitude = longitude;
            this.codeL = codeL;
        }
    }
}
