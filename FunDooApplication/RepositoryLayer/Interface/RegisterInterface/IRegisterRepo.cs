using Model.DTO.RegisterDto;
using Model.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface.RegisterInterface
{
    public interface IRegisterRepo
    {
        Task<User> GetUserByEmail(RegisterDto user);
        Task<User> Register(User user);
    }
}
