using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.DTOs.Response;
using ControleFinanceiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Api.Controllers.v1
{

    [Route("api/v1/[controller]")]
    [ApiController]    
    public class DespesaController : AbstractApiController
    {
        private readonly IDespesaService _despesaService;
        public DespesaController(IDespesaService despesaService)
        {
            _despesaService = despesaService;
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(DespesaDTO), StatusCodes.Status200OK)]
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var result = await _despesaService.GetByIdAsync(id);
                
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
        [ProducesResponseType(typeof(IEnumerable<DespesaDTO>), StatusCodes.Status200OK)]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _despesaService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(DespesaDTO), StatusCodes.Status200OK)]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] DespesaDTO despesa)
        {
            try
            {
                var result = await _despesaService.CreateAsync(despesa);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(DespesaDTO), StatusCodes.Status200OK)]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] DespesaDTO despesa)
        {
            try
            {
                var result = await _despesaService.UpdateAsync(despesa);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(DespesaDTO), StatusCodes.Status200OK)]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _despesaService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }
    }
}
