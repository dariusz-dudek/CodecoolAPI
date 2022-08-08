using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecoolAPI.Data.DAL.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(CodecoolAPIContext context) : base(context)
        {
        }
    }
}
