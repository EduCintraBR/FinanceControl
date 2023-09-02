using FinanceControl.Api.Models.Dto.Response;

namespace FinanceControl.Api.Services.IServices
{
    public interface IBaseService<TDto> where TDto : class
    {
        Task<ResponseResultDto<TDto>> ObtemPorId(int id); 
        Task<ResponseListDto<TDto>> ListarTodos(); 
        Task<ResponseResultDto<TDto>> Criar(TDto entity);
        Task<ResponseResultDto<TDto>> Alterar(TDto entity);
        Task<ResponseDto> Deletar(int id);
    }
}
