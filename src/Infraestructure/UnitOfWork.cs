using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure.Contexts;
using GoldenPaths.Infraestructure.Repositories;

namespace GoldenPaths.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GPContext _context;

        public UnitOfWork(GPContext context)
        {
            _context = context;
        }

        private IUserRepository? _userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                _userRepository ??= new UserRepository(_context); return _userRepository;
            }
        }
    }
}
