using GoldenPaths.Domain.Entities;
using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Infraestructure.Contexts;

namespace GoldenPaths.Infraestructure.Repositories
{
    internal class DemandRepository : BasicRepository<Demand, int>, IDemandRepository
    {
        public DemandRepository(GPContext context) : base(context)
        {
        }
    }
}
