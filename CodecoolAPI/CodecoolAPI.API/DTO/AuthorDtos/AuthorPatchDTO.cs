namespace CodecoolAPI.API.DTO.AuthorDtos
{
    public class AuthorPatchDTO
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Role { get; set; } = null!;
        public List<int> MaterialsID { get; set; } = null!;
        public List<int> ReviewsID { get; set; } = null!;
    }
}
