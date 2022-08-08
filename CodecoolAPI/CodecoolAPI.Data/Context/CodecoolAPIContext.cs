namespace CodecoolAPI.Data.Context
{
    public class CodecoolAPIContext : DbContext
    {
        public CodecoolAPIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
