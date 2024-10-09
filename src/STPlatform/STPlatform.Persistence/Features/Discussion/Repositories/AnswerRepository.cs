using Microsoft.EntityFrameworkCore;
using STPlatform.Application.Features.Discussion.Repositories;
using STPlatform.Domain.Entities;
using System.Linq.Expressions;

namespace STPlatform.Persistence.Features.Discussion.Repositories
{
    public class AnswerRepository : Repository<Answer, Guid>, IAnswerRepository
    {
        public AnswerRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
        public async Task<(IList<Answer> records, int total, int totalDisplay)>
            GetTableDataAsync(Expression<Func<Answer, bool>> expression, string orderBy, int pageIndex, int pageSize)
        {
            return await GetDynamicAsync(expression, orderBy, null, pageIndex, pageSize, true);
        }
    }
}
