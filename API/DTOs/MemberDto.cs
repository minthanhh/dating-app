namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public string? PhotoUrl { get; set; }
        public int Age { get; set; }
        public required string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string? Gender { get; set; }
        public string? Introduction { get; set; }
        public string? LookingFor { get; set; }
        public string? Interests { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public List<PhotoDto>? Photos { get; set; }
    }
}