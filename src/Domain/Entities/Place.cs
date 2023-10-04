namespace GoldenPaths.Domain.Entities
{
    public class Place
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public Guid AddressId { get; set; }
        public Address? Address { get; set; }

        public Demand? Demand { get; set; }

    }
}
