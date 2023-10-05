using GoldenPaths.Domain.Dtos;
using GoldenPaths.Domain.Entities;
using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.ApplicationCore.Services
{
    public class AccountManager : IAccountManager
    {
        private readonly IUnitOfWork _uow;

        public AccountManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Task Create(AddNewUserDto newUser)
        {
            var user = new User()
            {
                Email = newUser.Email,
                Name = newUser.Name,
                Password= newUser.Password,
                BirthDay = newUser.Birthday,
            };
            return _uow.UserRepository.Create(user);
        }

        public async Task<UserDto?> Login(UserLoginCredentialsDto login)
        {
            if(await _uow.UserRepository.Login(login.Email, login.Password))
            {
                var user = await _uow.UserRepository.GetUser(login.Email);
                return user is not null ? new UserDto(user.Name, user.Email, user.BirthDay) : null;
            }
            return null;
        }
    }
}
