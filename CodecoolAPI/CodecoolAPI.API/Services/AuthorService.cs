namespace CodecoolAPI.API.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly IMaterialRepository _materialRepository;
        private readonly IReviewRepository _reviewRepository;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper, IMaterialRepository materialRepository, IReviewRepository reviewRepository)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
            _materialRepository = materialRepository;
            _reviewRepository = reviewRepository;
        }

        public Task<int> CreateNewAsync(AuthorPostDTO value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuthorDTO>> GetAllAsync(PaginationDTO paginationDTO)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
