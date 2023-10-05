using GoldenPaths.Domain.Dtos;
using GoldenPaths.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Domain.Interfaces.Services
{
    public interface IDemandService
    {
        Task CreateDemand(AddDemandDto demand);
        Task<IEnumerable<Demand>> GetAll();
    }
}
