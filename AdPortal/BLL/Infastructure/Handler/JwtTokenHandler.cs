using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BLL.Infastructure.Handler
{
    public class JwtTokenHandler
    {
        private IUnitOfWork uow;
        private readonly IConfiguration configuration;
        public JwtTokenHandler(IUnitOfWork uow, IConfiguration configuration)
        {
            this.uow = uow;
            this.configuration = configuration;
        }
        public string CreateJWTToken(string username)
        {
            var key = Encoding.ASCII.GetBytes(configuration.GetSection("JWTToken:SecretKey").Value);
            var user = uow.Context.Users.FirstOrDefault(x => x.Username == username);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.Name, user.Id.ToString()),
                        new Claim(ClaimTypes.GivenName, user.Name.ToString()),
                        new Claim(ClaimTypes.Role, user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenCreate = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(tokenCreate);
            return token;
        }


    }
}

