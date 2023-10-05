namespace GoldenPaths.Domain.Entities
{
    public class Demand
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DemandDateTime { get; set; } = DateTime.Now;

        public string DemandType { get; set; } = null!;


        //public DateTime? SolutionDate { get; set; }

        //public Guid? PlaceId { get; set; }
        //public Place? Place { get; set; }

        //public Guid DemandTypeId { get; set; }
        //public DemandType? DemandType { get; set; }

        //public Guid? DemandStatusId { get; set; }
        //public DemandStatus? DemandStatus { get; set; }

        public IEnumerable<User>? Users { get; set; } = Enumerable.Empty<User>();
    }
}
