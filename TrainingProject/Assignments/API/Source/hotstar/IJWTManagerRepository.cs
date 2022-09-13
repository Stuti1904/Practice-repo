using hotstar.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace hotstar
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(User user, string role);
    }

    public class JWTManagerRepository : IJWTManagerRepository
    {
        private readonly IConfiguration configuration;

        private hotstar2445stutiContext context;

        public JWTManagerRepository(IConfiguration con)
        {
            configuration = con;
            context = new hotstar2445stutiContext();
        }

        public Tokens Authenticate(User user, String Role)
        {
            List<User> userlist = context.Users.Select(x => x).ToList();
            if (!userlist.Any(x => x.Phone == user.Phone && x.Password == user.Password))
            {
                return null;
            }
            else
            {
                if (string.IsNullOrEmpty(Role))
                {
                    if (!userlist.Any(x => x.Phone == user.Phone || x.Email == user.Email && x.Password == user.Password))
                    {
                        return null;
                    }
                    var tempuser = userlist.Where(x => x.Phone==user.Phone && x.Password == user.Password).First();
                    
                    var temprole = context.Roles.Where(x => x.RoleId == tempuser.RoleId).First();

                    Role = temprole.RoleName;
                }
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        
                        new Claim(ClaimTypes.Name, user.Phone),
                        new Claim(ClaimTypes.Role, Role)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return new Tokens { Token = tokenHandler.WriteToken(token), Role=Role };
            }
        }
    }
}
