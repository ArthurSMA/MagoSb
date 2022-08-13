namespace Mago.Mvc.Interfaces
{
    public interface IUsuarioRepository
    {
        Task Cadastrar(Usuario usuario);
        Task<Usuario> BuscarUsuarioPorEmail(string email);
    }
}