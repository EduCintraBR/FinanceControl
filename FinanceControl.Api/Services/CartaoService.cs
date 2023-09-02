using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Api.Services
{
    public class CartaoService : BaseService<CartaoDto, Cartao>, ICartaoService
    {
        private readonly IMapper _mapper;
        private readonly FCDbContext _db;

        public CartaoService(FCDbContext db, IMapper mapper) : base(db, mapper)
        {
            _db = db;
            _mapper = mapper;
        }
    }
}
