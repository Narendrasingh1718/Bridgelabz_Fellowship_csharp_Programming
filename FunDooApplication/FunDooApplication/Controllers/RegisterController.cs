using BusinessLayer.Interface.RegisterServiceInterface;
using Microsoft.AspNetCore.Mvc;
using Model.DTO.RegisterDto;
using Model.Entity.Responce;
using Model.Entity.User;
using Model.Exception;

namespace FunDooApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService service;

        public RegisterController(IRegisterService service)
        {
            this.service = service;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ApiResponce<User>>> Register(RegisterDto register)
        {
            try
            {
                var user = await service.RegisterAsync(register);

                return Ok(new ApiResponce<User>
                {
                    Success = true,
                    Message = "Registration successful",
                    Data = user
                });
            }
            catch (UserExistsException ex)
            {
                return Conflict(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponce<string>
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null
                });
            }
        }
    }
}