namespace Dominio.Localidade.Interfaces
{
    public interface ILocalidadeRepositorio
    {
        #region [ sets ]
        Localidade Salvar(Localidade localidade);
        Localidade Alterar(Localidade localidade);
        #endregion

        #region [ gets ]
        Localidade Obter(string Code);
        Localidade Obter(int id);
        #endregion
    }
}
