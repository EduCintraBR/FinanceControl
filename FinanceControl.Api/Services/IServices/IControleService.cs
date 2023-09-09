using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;

namespace FinanceControl.Api.Services.IServices
{
    public interface IControleService : IBaseService<ControleDto>
    {
        Task<ResponseListDto<IEnumerable<CustosDto>>> ObtemListaDeCustosPorIdControle(int codControle);
    }
}
