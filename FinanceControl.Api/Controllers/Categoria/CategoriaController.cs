using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers.Categoria
{
    [Route("api/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return await ControllerUtil.Get<CategoriaDto>(id, _categoriaService);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await ControllerUtil.GetAll(_categoriaService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoriaDto dto)
        {
            return await ControllerUtil.Post(dto, _categoriaService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CategoriaDto dto)
        {
            return await ControllerUtil.Put(dto, _categoriaService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _categoriaService);
        }
    }
}
