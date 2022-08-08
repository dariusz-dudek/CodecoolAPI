namespace CodecoolAPI.Data.DAL.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        //Task<Material> GetMaterialByIdAsync(int materialId);
        //Task<Author> GetByIdWithMaterialsByIdAsync(int authorId);
        //Task<bool> IsExistByUsernameAsync(string username);
        //Task<IEnumerable<Author>> GetAllWithMaterialsAsync(PaginationData paginationData);
        Task<IEnumerable<Material>> GetAllMaterialsForGivenAuthorIdAndRvievPointsAbove(PaginationData paginationData, int authorId, int revievPoints);
        Task<Author> GetAuthorWithHighestCreatedMaterialCount();
    }
}
