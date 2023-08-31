using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class CartaoService : ICartaoService
    {
        private readonly FCDbContext _db;
        private readonly IMapper _mapper;

        public CartaoService(FCDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CartaoDto> Alterar(CartaoDto entity)
        {
            var cartaoToUpdate = _mapper.Map<Cartao>(entity);

            _db.Cartoes.Update(cartaoToUpdate);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<CartaoDto> Criar(CartaoDto entity)
        {
            var cartaoToInsert = _mapper.Map<Cartao>(entity);

            await _db.Cartoes.AddAsync(cartaoToInsert);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task Deletar(int id)
        {
            var cartao = await _db.Cartoes.FirstAsync(x => x.Id == id);
            if (cartao is null) 
            {
                throw new ArgumentException("Não foi possível excluir este cartão, id inexistente no banco de dados.");
            }

            _db.Cartoes.Remove(cartao);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<CartaoDto>> ListarTodos()
        {
            var listaCartoes = await _db.Cartoes.ToListAsync();
            return _mapper.Map<IEnumerable<CartaoDto>>(listaCartoes);
        }

        public async Task<CartaoDto> ObtemPorId(int id)
        {
            var cartao = await _db.Cartoes.FirstAsync(x => x.Id == id);
            return _mapper.Map<CartaoDto>(cartao);
        }
    }
}
