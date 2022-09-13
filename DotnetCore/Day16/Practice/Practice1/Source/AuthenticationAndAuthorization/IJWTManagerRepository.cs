using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization
{
   public  interface IJWTManagerRepository
    {
        Tokens Authenticate(Users user);
    }

    public class JWTManagerRepository: IJWTManagerRepository
    {
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            {"user1", "password1" },
            {"user2", "password2" },
            {"user3", "password3" }
        };
        private readonly IConfiguration configuration;
        public JWTManagerRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Tokens Authenticate(Users users)
        {
            if(!UserRecords.Any(x=>x.Key==users.UserName && x.Value == users.Password))
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, users.UserName)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return new Tokens { Token = tokenHandler.WriteToken(token) };
            }
        }
    }
}
