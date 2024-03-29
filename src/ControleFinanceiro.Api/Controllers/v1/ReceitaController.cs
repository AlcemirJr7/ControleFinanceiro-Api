﻿using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.DTOs.Response;
using ControleFinanceiro.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ControleFinanceiro.Api.Controllers.v1
{
    
    [Route("api/v1/[controller]")]
    [ApiController]    
    public class ReceitaController : AbstractApiController
    {
        private readonly IReceitaService _receitaService;
        public ReceitaController(IReceitaService receitaService)
        {
            _receitaService = receitaService;
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var result = await _receitaService.GetByIdAsync(id);
                
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
        [ProducesResponseType(typeof(IEnumerable<ReceitaDTO>), StatusCodes.Status200OK)]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _receitaService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ReceitaDTO receita)
        {
            try
            {
                var result = await _receitaService.CreateAsync(receita);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] ReceitaDTO receita)
        {
            try
            {
                var result = await _receitaService.UpdateAsync(receita);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }

        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ReceitaDTO), StatusCodes.Status200OK)]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var result = await _receitaService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return HandleControllerErrors(ex);
            }
        }
    }
}
