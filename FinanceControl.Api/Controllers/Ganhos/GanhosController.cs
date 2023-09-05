using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Ganhos
{
    [Route("api/ganhos")]
    [ApiController]
    public class GanhosController : ControllerBase
    {
        private readonly IGanhosService _ganhosService;

        public GanhosController(IGanhosService ganhosService)
        {
            _ganhosService = ganhosService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_ganhosService);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return await ControllerUtil.Get(id, _ganhosService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GanhosDto dto)
        {
            return await ControllerUtil.Post(dto, _ganhosService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(GanhosDto dto)
        {
            return await ControllerUtil.Put(dto, _ganhosService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _ganhosService);
        }
    }
}
