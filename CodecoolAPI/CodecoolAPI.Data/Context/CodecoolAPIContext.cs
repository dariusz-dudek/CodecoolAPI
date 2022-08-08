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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>(a =>
            {
                a.HasKey(a => a.AuthorId);
                a.HasIndex(a => a.Username).IsUnique();
            });

            builder.Entity<Material>(m =>
            {
                m.HasKey(m => m.MaterialId);
            });

            builder.Entity<MaterialType>(mt =>
            {
                mt.HasKey(mt => mt.MaterialTypeId);
                mt.HasIndex(mt => mt.Name).IsUnique();
            });

            builder.Entity<Review>(r =>
            {
                r.HasKey(r => r.ReviewId);
                r.HasOne(r => r.Material).WithMany(m => m.Rewievs).OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
