using FinanceControl.Api.Controllers.Util;
using FinanceControl.Api.Models.Dto;
using FinanceControl.Api.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.Api.Controllers
{
    [Route("api/cartoes")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        private readonly ICartaoService _cartaoService;

        public CartaoController(ICartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await ControllerUtil.GetAll<CartaoDto>(_cartaoService);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return await ControllerUtil.Get<CartaoDto>(id, _cartaoService);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CartaoDto cartaoDto)
        {
            return await ControllerUtil.Post(cartaoDto, _cartaoService);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CartaoDto cartaoDto)
        {
            return await ControllerUtil.Put(cartaoDto, _cartaoService);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ControllerUtil.Delete(id, _cartaoService);
        }
    }
}
