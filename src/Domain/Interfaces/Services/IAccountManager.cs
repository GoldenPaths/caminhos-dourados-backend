using GoldenPaths.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Domain.Interfaces.Services
{
    public interface IAccountManager
    {
        Task Create(AddNewUserDto newUser);
        Task<UserDto?> Login(UserLoginCredentialsDto login);
    }
}
