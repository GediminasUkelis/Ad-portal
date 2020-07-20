using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface IUserService
    {
        void Register(User user);
        User Login(LoginData data);
    }
}
