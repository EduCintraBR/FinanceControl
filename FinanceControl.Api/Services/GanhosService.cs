using AutoMapper;
using FinanceControl.Api.Data;
using FinanceControl.Api.Models;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;

namespace FinanceControl.Api.Services
{
    public class GanhosService : BaseService<GanhosDto, Ganhos>, IGanhosService
    {
        private readonly FCDbContext _dbContext;
        private readonly IMapper _mapper;

        public GanhosService(FCDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
