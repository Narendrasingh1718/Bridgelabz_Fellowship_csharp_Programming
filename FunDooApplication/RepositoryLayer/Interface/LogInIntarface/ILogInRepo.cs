using Model.DTO.LogInDto;
using Model.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface.LogInIntarface
{
    public  interface ILogInRepo
    {
        Task<User> LogIn(LogInDto logIndto);
    }
}
