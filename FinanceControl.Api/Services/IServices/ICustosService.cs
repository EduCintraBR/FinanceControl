using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;

namespace FinanceControl.Api.Services.IServices
{
    public interface ICustosService : IBaseService<CustosDto>
    {
        Task<ResponseListDto<CustosDto>> ObtemListaDeCustosPorIdControle(int codControle);
    }
}
