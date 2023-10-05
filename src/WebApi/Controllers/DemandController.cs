using GoldenPaths.Domain.Dtos;
using GoldenPaths.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoldenPaths.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandController : ControllerBase
    {
        private readonly IDemandService _service;

        public DemandController(IDemandService service)
        {
            _service = service;
        }

        [HttpPost("NewDemand")]
        public async Task<IActionResult> AddNewDemand(AddDemandDto dto)
        {
            await _service.CreateDemand(dto);

            return Ok("demand created");
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetALl()
        {
            return Ok(await _service.GetAll());
        }
    }
}
