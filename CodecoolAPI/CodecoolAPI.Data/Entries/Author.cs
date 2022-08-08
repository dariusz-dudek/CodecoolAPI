namespace CodecoolAPI.Data.Entries
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int Counter { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
