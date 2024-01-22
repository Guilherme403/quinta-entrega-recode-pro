using AgenciaViagens.Models;

namespace AgenciaViagens.Repositorios.Interfaces
{
    public interface IDestinoRepositorio
    {
        Task<List<DestinoModel>> BuscarTodosUsuarios();
        Task<DestinoModel> BuscarPorId(int id);

    }
}
