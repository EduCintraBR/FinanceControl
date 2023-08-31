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
            try
            {
                return Ok(await _cartaoService.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _cartaoService.ObtemPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CartaoDto cartaoDto)
        {
            try
            {
                return Ok(await _cartaoService.Criar(cartaoDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(CartaoDto cartaoDto)
        {
            try
            {
                return Ok(await _cartaoService.Alterar(cartaoDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _cartaoService.Deletar(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
