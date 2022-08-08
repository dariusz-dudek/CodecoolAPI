using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecoolAPI.Data.DAL.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(CodecoolAPIContext context) : base(context)
        {
        }

        public Task<IEnumerable<Material>> GetAllMaterialsForGivenAuthorIdAndRvievPointsAbove(PaginationData paginationData, int authorId, int revievPoints)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorWithHighestCreatedMaterialCount()
        {
            throw new NotImplementedException();
        }
    }
}
