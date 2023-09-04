using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Parcelamento
{
    [Route("api/parcelamento")]
    [ApiController]
    public class ParcelamentoController : ControllerBase
    {
        private readonly IParcelamentoService _parcelamentoService;

        public ParcelamentoController(IParcelamentoService parcelamentoService)
        {
            _parcelamentoService = parcelamentoService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return await ControllerUtil.Get<ParcelamentoDto>(id, _parcelamentoService);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_parcelamentoService);
        }

        [HttpGet("gerar-parcelas/{idParcelamento:int}")]
        public async Task<IActionResult> GerarParcelas(int idParcelamento)
        {
            var resultado = await _parcelamentoService.GerarParcelas(idParcelamento);

            if (!resultado.IsSuccess)
                return new BadRequestObjectResult(resultado);

            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ParcelamentoDto dto)
        {
            return await ControllerUtil.Post(dto, _parcelamentoService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ParcelamentoDto dto)
        {
            return await ControllerUtil.Put(dto, _parcelamentoService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _parcelamentoService);
        }
    }
}
