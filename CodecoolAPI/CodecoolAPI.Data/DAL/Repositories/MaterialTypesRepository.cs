using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecoolAPI.Data.DAL.Repositories
{
    public class MaterialTypesRepository : Repository<MaterialType>, IMaterialTypesRepository
    {
        public MaterialTypesRepository(CodecoolAPIContext context) : base(context)
        {
        }
    }
}
