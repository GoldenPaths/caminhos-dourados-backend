using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GPContext _context;

        public UnitOfWork(GPContext context)
        {
            _context = context;
        }
    }
}
