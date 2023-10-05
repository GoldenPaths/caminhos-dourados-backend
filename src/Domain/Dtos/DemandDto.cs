using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Domain.Dtos
{
    public record DemandDto
    {
        public int Id { get; set; }
        public string? Descrption { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
