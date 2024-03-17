using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.DTOs.Response;
using ControleFinanceiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ControleFinanceiro.Api.Controllers.v1
{
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/v1/[controller]")]
    [ApiController]    
    public class ReceitaController : AbstractApiController
    {
        private readonly IReceitaService _receitaService;
        public ReceitaController(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        [ProducesErrorResponseType(typeof(ErrorResponse))]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesErrorResponseType(typeof(ErrorResponse))]
        [ProducesResponseType(typeof(IEnumerable<ReceitaDTO>), StatusCodes.Status201Created)]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok("Teste");
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesErrorResponseType(typeof(ErrorResponse))]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status201Created)]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ReceitaDTO receita)
        {
            try
            {
                var result = await _receitaService.CreateReceitaAsync(receita);
                return CreatedAtAction(nameof(Get), result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesErrorResponseType(typeof(ErrorResponse))]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpPut("Update")]
        public async Task<IActionResult> Put([FromBody] ReceitaDTO receita)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesErrorResponseType(typeof(ErrorResponse))]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }
    }
}
