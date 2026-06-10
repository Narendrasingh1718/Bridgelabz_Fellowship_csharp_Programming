using BusinessLayer.Interface.RegisterServiceInterface;
using Microsoft.Extensions.Logging;
using Model.DTO.RegisterDto;
using Model.Entity.User;
using Model.Exception;
using RepositoryLayer.Interface.RegisterInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementation.RegisterService
{
    public class RegisterImplService :IRegisterService
    {
        private readonly IRegisterRepo Repository; 
        private readonly Helper.Password password;
        private readonly ILogger<RegisterImplService> logger;
        public RegisterImplService(IRegisterRepo repository, Helper.Password password, ILogger<RegisterImplService> logger)
        {
            Repository = repository;
            this.password = password;
            this.logger = logger;
        }
        public async Task<User> RegisterAsync(RegisterDto register)
        {
            var ExistingUser = await Repository.GetUserByEmail(register);
            if(ExistingUser != null)
            {
                logger.LogInformation("User with email {Email} already exists.", register.Email);
                throw new UserExistsException("User with this email already exists.");
            }
            User user = new User
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                Password = password.HashPassword(register.Password),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActice = true
            };
            return await Repository.Register(user);

        }
    }

}
