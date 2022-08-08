namespace CodecoolAPI.Data.DAL.Repositories
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(CodecoolAPIContext context) : base(context)
        {
        }
    }
}
