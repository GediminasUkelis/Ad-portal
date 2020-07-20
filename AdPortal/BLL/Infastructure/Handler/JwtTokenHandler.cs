using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Data;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BLL.Infastructure.Handler
{
    public class JwtTokenHandler
    {
        private IUnitOfWork uow;
        public JwtTokenHandler(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public string CreateJWTToken(string username, string password)
        {
            var user = uow.Context.Users.FirstOrDefault(x => x.Username == username);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("MyKey-sdasdas2c5981ASD11cqsqWEDcsq6c5QWDQW1ds2d1321qcqc0sq0qsc23qf6q5s4df3Q234WDq2s1d");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.Name, user.Id.ToString())
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

