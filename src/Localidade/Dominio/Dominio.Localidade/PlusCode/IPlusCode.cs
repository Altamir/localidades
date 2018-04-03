namespace Dominio.Localidades.PlusCode
{
    public interface IPlusCode
    {
        string Code { get;  }
        string Latitude { get; }
        string Logitude { get; }
        int CodeLengt { get; }
    }
}
