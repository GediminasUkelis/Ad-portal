using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUserService
    {
        Task RegisterAsync(User user);
        Task<User> LoginAsync(LoginData data);
        Task<User> FindSingleUserAsync(string username);
        Task<User> FindSingleUserById(Guid Id);
    }
}
