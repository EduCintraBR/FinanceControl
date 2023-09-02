using FinanceControl.Api.Models.Dto.Response;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Util
{
    public static class ControllerUtil
    {
        internal static async Task<IActionResult> Get<TDto>(int id, IBaseService<TDto> service) where TDto : class
        {
            var resultado = await service.ObtemPorId(id);
            if (resultado.IsSuccess)
            {
                return new OkObjectResult(resultado.Result);
            }
            else
            {
                return MontaResultInvalido(resultado);
            }
        }

        internal static async Task<IActionResult> GetAll<TDto>(IBaseService<TDto> service) where TDto : class
        {
            var resultado = await service.ListarTodos();
            if (resultado.IsSuccess)
            {
                return new OkObjectResult(resultado.List);
            }
            else
            {
                return MontaResultInvalido(resultado);
            }
        }

        internal static async Task<IActionResult> Post<TDto>(TDto entity, IBaseService<TDto> service) where TDto : class
        {
            var resultado = await service.Criar(entity);
            if (resultado.IsSuccess)
            {
                return new OkObjectResult(resultado.Result);
            }
            else
            {
                return MontaResultInvalido(resultado);
            }
        }

        internal static async Task<IActionResult> Put<TDto>(TDto entity, IBaseService<TDto> service) where TDto : class
        {
            var resultado = await service.Alterar(entity);
            if (resultado.IsSuccess)
            {
                return new OkObjectResult(resultado.Result);
            }
            else
            {
                return MontaResultInvalido(resultado);
            }
        }

        internal static async Task<IActionResult> Delete<TDto>(int id, IBaseService<TDto> service) where TDto : class
        {
            var resultado = await service.Deletar(id);
            if (resultado.IsSuccess)
            {
                return new NoContentResult();
            }
            else
            {
                return MontaResultInvalido(resultado);
            }
        }

        internal static IActionResult MontaResultInvalido(ResponseDto response)
        {
            return new BadRequestObjectResult(response.Message);
        }
    }
}
