using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;

namespace FinanceControl.Api.Services
{
    public class CategoriaService : BaseService<CategoriaDto, Categoria>, ICategoriaService
    {
        private readonly IMapper _mapper;
        private readonly FCDbContext _dbContext;
        public CategoriaService(FCDbContext db, IMapper mapper) : base(db, mapper)
        {
            _dbContext = db;
            _mapper = mapper;
        }
    }
}
