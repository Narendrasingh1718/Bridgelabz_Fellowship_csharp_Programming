using Model.DTO.LogInDto;
using RepositoryLayer.Interface.LogInIntarface;
using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.EntityFrameworkCore;
using Model.Entity.User;

namespace RepositoryLayer.Implementation.LogInImpl
{
    public class LogInImplRepo : ILogInRepo
    {
        private readonly Context.AppDbContext context;
        public LogInImplRepo(Context.AppDbContext context)
        {
            this.context = context;
        }
        public async Task<User> LogIn(LogInDto login)
        {
            var user= await context.UserRecords.FirstOrDefaultAsync(x => x.Email.Equals(login.Email)); 
            return user;
        }
    }
}
