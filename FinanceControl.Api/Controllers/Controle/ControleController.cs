using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Controle
{
    [Route("api/controle")]
    [ApiController]
    public class ControleController : ControllerBase
    {
        private readonly IControleService _controleService;

        public ControleController(IControleService controleService)
        {
            _controleService = controleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_controleService);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return await ControllerUtil.Get(id, _controleService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ControleDto dto)
        {
            return await ControllerUtil.Post(dto, _controleService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(ControleDto dto)
        {
            return await ControllerUtil.Put(dto, _controleService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _controleService);
        }
    }
}
