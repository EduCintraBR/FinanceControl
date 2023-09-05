using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Custos
{
    [Route("api/custos")]
    [ApiController]
    public class CustosController : ControllerBase
    {
        private readonly ICustosService _custosService;

        public CustosController(ICustosService custosService)
        {
            _custosService = custosService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_custosService);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return await ControllerUtil.Get(id, _custosService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustosDto dto)
        {
            return await ControllerUtil.Post(dto, _custosService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CustosDto dto)
        {
            return await ControllerUtil.Put(dto, _custosService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _custosService);
        }
    }
}
