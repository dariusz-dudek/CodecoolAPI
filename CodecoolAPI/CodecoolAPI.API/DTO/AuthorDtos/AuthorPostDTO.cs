namespace CodecoolAPI.API.DTO.AuthorDtos
{
    public class AuthorPostDTO
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        [Required]
        public string Role { get; set; } = null!;
        [Required]
        public List<int> MaterialsID { get; set; } = null!;
        [Required]
        public List<int> ReviewsID { get; set; } = null!;
    }
}
