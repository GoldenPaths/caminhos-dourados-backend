using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Domain.Dtos
{
    public record AddDemandDto
    {
        public string? Description { get; set; }
        public DateTime DemandDateTime { get; set; } = DateTime.Now;

        public string DemandType { get; set; } = null!;
    }


}
