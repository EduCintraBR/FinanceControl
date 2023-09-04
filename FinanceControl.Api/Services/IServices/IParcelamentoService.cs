using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Models.Dto.Response;

namespace FinanceControl.Api.Services.IServices
{
    public interface IParcelamentoService : IBaseService<ParcelamentoDto>
    {
        Task<ResponseDto> GerarParcelas(int idParcelamento);
    }
}
