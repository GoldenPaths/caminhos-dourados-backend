using GoldenPaths.Domain.Entities;
using GoldenPaths.Infraestructure.Contexts;

namespace GoldenPaths.Infraestructure.Repositories
{
    internal class DemandRepository : BasicRepository<Demand, int>
    {
        public DemandRepository(GPContext context) : base(context)
        {
        }
    }
}
