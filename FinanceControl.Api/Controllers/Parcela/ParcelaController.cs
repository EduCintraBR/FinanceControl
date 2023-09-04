using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Parcela
{
    [Route("api/parcela")]
    [ApiController]
    public class ParcelaController : ControllerBase
    {
        private readonly IParcelaService _parcelaService;

        public ParcelaController(IParcelaService parcelaService)
        {
            _parcelaService = parcelaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_parcelaService);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return await ControllerUtil.Get(id, _parcelaService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ParcelaDto dto)
        {
            return await ControllerUtil.Post(dto, _parcelaService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ParcelaDto dto)
        {
            return await ControllerUtil.Put(dto, _parcelaService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _parcelaService);
        }
    }
}
