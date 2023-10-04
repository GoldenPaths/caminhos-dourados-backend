namespace GoldenPaths.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string? PostalCode { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

        public Place? Place { get; set; }
    }
}
