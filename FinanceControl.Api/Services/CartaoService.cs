using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class CartaoService : ICartaoService
    {
        private readonly FCDbContext _db;

        public CartaoService(FCDbContext db)
        {
            _db = db;
        }

        public Task<Cartao> Alterar(int id, Cartao entity)
        {
            throw new NotImplementedException();
        }

        public Task<Cartao> Criar(Cartao entity)
        {
            throw new NotImplementedException();
        }

        public Task<Cartao> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cartao>> ListarTodos()
        {
            return await _db.Cartoes.ToListAsync();
        }

        public async Task<Cartao> ObtemPorId(int id)
        {
            return await _db.Cartoes.FirstAsync(x => x.Id == id);
        }
    }
}
