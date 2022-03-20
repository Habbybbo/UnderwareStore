
using UnderwareStore.Infrastructure.Data;
using UnderwareStore.Infrastructure.Data.Common;

namespace UnderwareStore.Infrastructure.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
