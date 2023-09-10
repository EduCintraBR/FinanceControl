using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;
using FinanceControl.Api.Services.IServices;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ResponseListDto<CustosDto>> ObtemListaDeCustosPorIdControle(int codControle)
        {
            var response = new ResponseListDto<CustosDto>();
            var custos = await _dbContext.Custos.Where(c => c.CodControle == codControle).ToListAsync();
            response.List = _mapper.Map<IEnumerable<CustosDto>>(custos);
            return response;
        }
    }
}
