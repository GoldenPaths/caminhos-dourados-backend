namespace GoldenPaths.Domain.Entities
{
    public class Demand
    {
        public int Id { get; set; }
        public string? Descrption { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime? SolutionDate { get; set; }

        public Guid PlaceId { get; set; }
        public Place? Place { get; set; }

        public Guid DemandTypeId { get; set; }
        public DemandType DemandType { get; set; } = null!;

        public Guid DemandStatusId { get; set; }
        public DemandStatus DemandStatus { get; set; } = null!;

        public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();
    }
}
