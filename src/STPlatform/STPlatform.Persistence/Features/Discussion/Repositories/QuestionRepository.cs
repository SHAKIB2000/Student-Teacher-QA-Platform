using Microsoft.EntityFrameworkCore;
using STPlatform.Application.Features.Discussion.Repositories;
using STPlatform.Domain.Entities;
using System.Linq.Expressions;

namespace STPlatform.Persistence.Features.Discussion.Repositories
{
    public class QuestionRepository : Repository<Question, Guid>, IQuestionRepository
    {
        public QuestionRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
        public async Task<(IList<Question> records, int total, int totalDisplay)>
            GetTableDataAsync(Expression<Func<Question, bool>> expression, string orderBy, int pageIndex, int pageSize)
        {
            return await GetDynamicAsync(expression, orderBy, null, pageIndex, pageSize, true);
        }
    }
}
