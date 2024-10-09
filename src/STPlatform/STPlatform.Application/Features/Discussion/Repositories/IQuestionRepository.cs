using STPlatform.Domain.Entities;
using STPlatform.Domain.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace STPlatform.Application.Features.Discussion.Repositories
{
    public interface IQuestionRepository : IRepositoryBase<Question, Guid>
    {
        Task<(IList<Question> records, int total, int totalDisplay)>
            GetTableDataAsync(Expression<Func<Question, bool>> expression, string orderBy, int pageIndex, int pageSize);
    }
}
