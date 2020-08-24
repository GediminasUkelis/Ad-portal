using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserService : IUserService
    {
        private ApplicationDbContext context;
        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<User> FindSingleUserAsync(string username)
        {
            return await context.Users
                .Include(x=>x.Vehicles).ThenInclude(x=>x.CarDetails)
                .Include(x=>x.Vehicles).ThenInclude(x=>x.Image)
                .Include(x=>x.Vehicles).ThenInclude(x=>x.BikeDetails)
                .SingleOrDefaultAsync(x=>x.Username==username);
        }
        public async Task<User> FindSingleUserById(Guid Id)
        {
            return await context.Users
                .Include(x => x.Vehicles).ThenInclude(x => x.CarDetails)
                .Include(x => x.Vehicles).ThenInclude(x => x.Image)
                .Include(x => x.Vehicles).ThenInclude(x => x.BikeDetails)
                .SingleOrDefaultAsync(x => x.Id == Id);
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
