using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Helper
{
    public class Password
    {
        private readonly String key;
        public Password(IConfiguration config)
        {
            key = config["Security:Key"];
        }
        public String HashPassword(String password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password+key);
        }
        public bool VerifyPassword(string inputPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword + key, storedHash);
        }
    }
}
