namespace CodecoolAPI.API.DTO.AuthorDtos
{
    public class AuthorDTO
    {
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Role { get; set; } = null!;
        public int Counter { get; set; }
        public IEnumerable<Material> Materials { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;

        public override string ToString()
        {
            string materials = Materials?.ToString() ?? string.Empty;
            string reviews = Reviews?.ToString() ?? string.Empty;
            return $"Id: [{AuthorId}]; Username: {Username}; FirstName: {FirstName}; LastName: {LastName}; Materials: {materials}; Reviews: {reviews}";
        }
    }
}
