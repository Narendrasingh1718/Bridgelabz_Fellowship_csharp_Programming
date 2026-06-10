using BusinessLayer.Interface.LogInServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using RepositoryLayer.Interface.LogInIntarface;
using Model.Entity;
using Model.DTO.LogInDto;
using Microsoft.Extensions.Logging;
using Model.Exception;

namespace BusinessLayer.Implementation.LogInService
{
    public class LogInServiceImpl : ILogInService
    {
        private readonly ILogInRepo  register;
        private readonly ILogger<LogInServiceImpl>   logger;
        private readonly Helper.Password passsword;
        private readonly Helper.GenerateToken generateToken;

        public LogInServiceImpl(ILogInRepo register, ILogger<LogInServiceImpl> logger,Helper.Password passsword, Helper.GenerateToken generateToken )
        {
            this.register = register;
            this.logger = logger;
            this.passsword = passsword;
            this.generateToken = generateToken;
        }

        public async Task<String> LogIn(LogInDto logInDto)
        {
            var result = await register.LogIn(logInDto);
            if (result == null)
            {
                logger.LogWarning("User not Found With This credentials");
                throw new UserNotFoundException("User not Found ");
            }
            var IsValid=passsword.VerifyPassword(logInDto.Password,result.Password);
            if (!IsValid)
            {
                logger.LogWarning("Invalid password ");
                return null;
            }
            logger.LogInformation("User logged in Successfully");
            return generateToken.GenerateJwtToken(result);
        }
        
    }
}
