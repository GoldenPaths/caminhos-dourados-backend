namespace GoldenPaths.Domain.Entities
{
    public class DemandStatus
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
        public string Name { get; set; } = null!;

        public IEnumerable<Demand> Demands { get; set; } = Enumerable.Empty<Demand>();
    }
}
