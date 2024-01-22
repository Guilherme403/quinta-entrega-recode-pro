using AgenciaViagens.Data;
using AgenciaViagens.Models;
using AgenciaViagens.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViagens.Repositorios
{
    public class DestinoRepositorio : IDestinoRepositorio
    {
        private readonly AgenciaViagensDBContex _dbContext;
        public DestinoRepositorio(AgenciaViagensDBContex agenciaViagensDBContex) 
        {
            _dbContext = agenciaViagensDBContex;
        }
        public async Task<DestinoModel> BuscarPorId(int id)
        {
            return await _dbContext.Destinos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<DestinoModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Destinos.ToListAsync();
        }
    }
}
