using BusinessLayer.Interface.LogInServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO.LogInDto;
using Model.Entity.Responce;
using Model.Exception;

namespace FunDooApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly ILogInService service;
        public LogInController(ILogInService service) { 
            this.service = service;
        }
        [HttpPost("login")]
        public async Task<ActionResult<ApiResponce<String>>> login(LogInDto logInDto)
        {
            try
            {
                var result = await service.LogIn(logInDto);
                if (result == null)
                {
                    return BadRequest(new ApiResponce<String>
                    {
                        Success = false,
                        Message = "Invalid Credentials",
                        Data = null
                    });
                }
                return Ok(new ApiResponce<String>
                {
                    Success = true,
                    Message = "login Successfull",
                    Data = result
                });
            }
            catch (UserNotFoundException ex)
            {
                return Conflict(new ApiResponce<String>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }

    }
}
