using RepositoryLayer.Interface.RegisterInterface;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Model.DTO.RegisterDto;
using Model.Entity.User;

namespace RepositoryLayer.Implementation.RegisterImpl
{
    public class RegisterImplREpo :IRegisterRepo
    {
        private readonly Context.AppDbContext context;
        public RegisterImplREpo(Context.AppDbContext context)
        {
            this.context = context;
        }
       
        public async Task<User> GetUserByEmail(RegisterDto user)
        {
            return await context.UserRecords.FirstOrDefaultAsync(u => u.Email.Equals( user.Email));
        }
        public async Task<User> Register(User user)
        {
            await context.UserRecords.AddAsync(user);
            await context.SaveChangesAsync(); 
            return user;
        }
    }
}
