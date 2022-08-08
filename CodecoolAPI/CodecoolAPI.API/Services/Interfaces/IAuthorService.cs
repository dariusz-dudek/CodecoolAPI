namespace CodecoolAPI.API.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<int> CreateNewAsync(AuthorPostDTO value);
        Task<bool> IsExistByUsername(string username);
        Task<IEnumerable<AuthorDTO>> GetAllAsync(PaginationDTO paginationDTO);
        Task<AuthorDTO> GetByIdAsync(int id);

    }
}
