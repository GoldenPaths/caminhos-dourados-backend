namespace GoldenPaths.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime BirthDay { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public IEnumerable<Demand> Demands { get; set; } = Enumerable.Empty<Demand>();
    }
}
