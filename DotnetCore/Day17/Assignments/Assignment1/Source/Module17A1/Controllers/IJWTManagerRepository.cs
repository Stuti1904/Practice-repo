using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Module17A1.Controllers
{
     public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users user);
    }
    public class JWTManagerRepository: IJWTManagerRepository
    {
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            {"admin1", "admin1" },
            {"admin2", "admin2" }
        };
        private readonly IConfiguration iconfiguration;
        public JWTManagerRepository (IConfiguration configuration)
        {
            this.iconfiguration = configuration;
        }
        public Tokens Authenticate(Users user)
        {
            if(!UserRecords.Any(x=>x.Key==user.UserName&& x.Value == user.Password))
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
                var tokenDescriptor= new SecurityTokenDescriptor
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName)
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

