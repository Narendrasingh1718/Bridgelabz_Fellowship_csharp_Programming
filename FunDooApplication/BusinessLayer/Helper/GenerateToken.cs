using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.Entity.User;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLayer.Helper
{
    public class GenerateToken
    {
        private readonly IConfiguration configuration;
        public GenerateToken(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public String GenerateJwtToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])); // geting the secret key from configuration
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);// specifying the algorithm to use for signing the token
            var claims = new[]
            {
                new Claim("email", user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) 
            };
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
