using Model.DTO.RegisterDto;
using Model.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface.RegisterServiceInterface
{
    public interface IRegisterService
    {
        Task<User> RegisterAsync(RegisterDto register);
    }
}
