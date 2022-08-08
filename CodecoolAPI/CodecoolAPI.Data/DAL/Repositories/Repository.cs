

namespace CodecoolAPI.Data.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CodecoolAPIContext _context;
        public CodecoolAPIContext Context { get => _context; }

        public Repository(CodecoolAPIContext context)
        {
            _context = context;
        }

        public void Create(T entity)
            => Context.Set<T>().Add(entity);

        public void Delete(T entity)
            => Context.Set<T>().Remove(entity);

        public async Task<IEnumerable<T>> GetAllAsync(PaginationData paginationData)
            => await Paginate(Context.Set<T>(), paginationData).ToListAsync();

        public async Task<int> GetCountAsync()
            => await Context.Set<T>().CountAsync();

        public async Task<bool> SaveChangesAsync()
            => await Context.SaveChangesAsync() > 0;

        public void Update(T entity)
            => Context.Set<T>().Update(entity);

        protected IQueryable<T> Paginate(IQueryable<T> queryable, PaginationData paginationData)
        {
            if (paginationData.Ascending)
            {
                queryable = queryable.OrderBy(entity => EF.Property<object>(entity, paginationData.Property));
            }
            else
            {
                queryable = queryable.OrderByDescending(entity => EF.Property<object>(entity, paginationData.Property));
            }
            return queryable
                .Skip(paginationData.PageSize * (paginationData.PageNumber - 1))
                .Take(paginationData.PageSize);
        }
    }
}
