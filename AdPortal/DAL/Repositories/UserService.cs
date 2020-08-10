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

        public async System.Threading.Tasks.Task<User> FindSingleUserAsync(string username)
        {
            return await context.Users
                .Include(c=>c.Cars).ThenInclude(i=>i.Image)
                .Include(x=>x.Motorbikes).ThenInclude(i=>i.Image)
                .SingleOrDefaultAsync(x=>x.Username==username);
        }

        public async System.Threading.Tasks.Task<User> LoginAsync(LoginData data)
        {
           return await context.Users.SingleOrDefaultAsync(x => x.Username == data.Username && x.Password == data.Password);
        }

        public async System.Threading.Tasks.Task RegisterAsync(User user)
        {
            await context.Users.AddAsync(user);
        }
    }
}
