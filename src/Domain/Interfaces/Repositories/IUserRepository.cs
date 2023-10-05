using GoldenPaths.Domain.Entities;

namespace GoldenPaths.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task<User?> GetUser(string email);
        Task<bool> Login(string email, string password);
    }
}