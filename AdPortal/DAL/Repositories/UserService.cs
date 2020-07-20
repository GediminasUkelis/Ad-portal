using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class UserService : IUserService
    {
        private ApplicationDbContext context;
        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public User Login(LoginData data)
        {
           return context.Users.SingleOrDefault(x => x.Username == data.Username && x.Password == data.Password);
            
        }

        public void Register(User user)
        {
            
            context.Users.Add(user);
        }
    }
}
