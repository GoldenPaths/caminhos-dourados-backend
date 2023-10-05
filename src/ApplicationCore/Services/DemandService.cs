using GoldenPaths.Domain.Dtos;
using GoldenPaths.Domain.Entities;
using GoldenPaths.Domain.Interfaces.Repositories;
using GoldenPaths.Domain.Interfaces.Services;

namespace GoldenPaths.ApplicationCore.Services
{
    public class DemandService : IDemandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DemandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateDemand(AddDemandDto demandDto)
        {
            var demand = new Demand()
            {
               Description = demandDto.Description,
               DemandType = demandDto.DemandType,
               DemandDateTime = demandDto.DemandDateTime,
            };
            await _unitOfWork.DemandRepository.CreateAsync(demand);
        }

        public async Task<IEnumerable<Demand>> GetAll() =>
            await _unitOfWork.DemandRepository.GetAllAsync();
        
    }
}
