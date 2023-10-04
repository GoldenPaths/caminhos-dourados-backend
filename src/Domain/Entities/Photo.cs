namespace GoldenPaths.Domain.Entities
{
    public class Photo
    {
        public Guid Id { get; set; }
        public byte[] File { get; set; } = null!;
    }
}
