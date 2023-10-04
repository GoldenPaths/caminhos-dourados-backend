namespace GoldenPaths.Domain.Dtos
{
    public record AddNewUserDto
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime Birthday { get; set; }
    }

    public record UserLoginCredentialsDto(string Email, string Password);

    public record UserDto(string Name, string Password, DateOnly Birthday);

}
