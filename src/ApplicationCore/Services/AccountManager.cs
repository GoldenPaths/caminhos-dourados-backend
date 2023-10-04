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
    }


}
