using ControleFinanceiro.Application.DTOs.Response;
using ControleFinanceiro.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ControleFinanceiro.Api.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]    
    public abstract class AbstractApiController : ControllerBase
    {
        protected IActionResult HandleControllerErrors(Exception ex)
        {
            if (ex is BadRequestException)
                return BadRequest(ex as BadRequestException);
            if (ex is UnauthorizedException)
                return Unauthorized(ex as UnauthorizedException);

            return RaiseInternalServerError(ex);
        }

        protected IActionResult HandlerResponseController(Response response)
        {
            if (response.OkResponse is null)
                return BadRequest(response.ErrorResponse);

            return Ok(response.OkResponse);
        }

        private IActionResult BadRequest(BadRequestException ex)
        {
            return BadRequest(HandlerResponseErrorCustom(ex));
        }

        private IActionResult Unauthorized(UnauthorizedException ex)
        {
            return Unauthorized(HandlerResponseErrorCustom(ex));
        }

        private IActionResult RaiseInternalServerError(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, HandlerErrorResponse(ex));
        }

        private ErrorResponse HandlerResponseErrorCustom(BaseException ex)
        {
            if (ex.Errors?.Any() ?? false)
                return new ErrorResponse(ex.Errors.ToList());

            return new ErrorResponse(ex.Message);
        }

        private ErrorResponse HandlerErrorResponse(Exception ex)
        {
            return new ErrorResponse(ex.ToString());
        }
    }
}
