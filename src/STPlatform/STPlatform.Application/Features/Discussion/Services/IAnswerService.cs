using STPlatform.Domain.Entities;
using System;
using System.Linq;

namespace STPlatform.Application.Features.Discussion.Services
{
    public interface IAnswerService
    {
        void AddAnswer(string content, DateTime posted, Guid teacherId, Guid questionId);
        Answer GetAnswer(Guid id);
        public IList<Answer> GetAnswers();
        Task<(IList<Answer> records, int total, int totalDisplay)>
            GetPagedGetAnswersAsync(int pageIndex, int pageSize, string searchText, string orderBy);
    }
}
