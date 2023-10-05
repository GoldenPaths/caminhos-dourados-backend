using GoldenPaths.Domain.Entities;
using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GoldenPaths.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GPContext _context;

        public UserRepository(GPContext context)
        {
            _context = context;
        }

        public async Task Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Login(string email, string password)
        {
            return await _context.Users.AnyAsync(x => x.Email.Equals(email.ToLowerInvariant()) && x.Password.Equals(password));
        }

        public async Task<User?> GetUser(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email.ToLowerInvariant()));
        }
    }
}
