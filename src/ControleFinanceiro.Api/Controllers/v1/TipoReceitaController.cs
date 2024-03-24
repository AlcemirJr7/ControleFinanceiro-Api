using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.DTOs.Response;
using ControleFinanceiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TipoReceitaController : AbstractApiController
    {
        private readonly ITipoReceitaService _tipoReceitaService;
        public TipoReceitaController(ITipoReceitaService tipoReceitaService)
        {
            _tipoReceitaService = tipoReceitaService;
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(TipoReceitaDTO), StatusCodes.Status200OK)]
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var result = await _tipoReceitaService.GetByIdAsync(id);

                if (result is null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<TipoReceitaDTO>), StatusCodes.Status201Created)]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _tipoReceitaService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(TipoReceitaDTO), StatusCodes.Status200OK)]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] TipoReceitaDTO tipoReceita)
        {
            try
            {
                var result = await _tipoReceitaService.CreateAsync(tipoReceita);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(TipoReceitaDTO), StatusCodes.Status200OK)]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] TipoReceitaDTO tipoReceita)
        {
            try
            {
                var result = await _tipoReceitaService.UpdateAsync(tipoReceita);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(TipoReceitaDTO), StatusCodes.Status200OK)]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _tipoReceitaService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }
    }
}
