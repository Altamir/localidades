using Alt.Utils.Generics;

namespace Dominio.Localidades.PlusCode
{
    public interface IPlusCodeBuilder
    {
        IMaybe<IPlusCode> Builder(string code, int codeLengt = 10);
        IMaybe<IPlusCode> Builder(double longitude, double latitude, int codeLengt = 10);
    }
}
