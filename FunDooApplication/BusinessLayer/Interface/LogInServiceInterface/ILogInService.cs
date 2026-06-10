using Model.DTO.LogInDto;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface.LogInServiceInterface
{
    public interface ILogInService
    {
        Task<String> LogIn(LogInDto logInDto);
    }
}
