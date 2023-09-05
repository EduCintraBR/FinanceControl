using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;

namespace FinanceControl.Api.Services
{
    public class CustosService : BaseService<CustosDto, Custos>, ICustosService
    {
        private readonly FCDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustosService(FCDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
