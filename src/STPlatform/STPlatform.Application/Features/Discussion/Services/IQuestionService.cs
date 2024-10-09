using STPlatform.Domain.Entities;
using System;
using System.Linq;

namespace STPlatform.Application.Features.Discussion.Services
{
    public interface IQuestionService
    {
        void AddQuestion(string title, string topic, string content, DateTime postedDate, Guid studentId);
        Question GetQuestion(Guid id);
        void DeleteQuestion(Guid id);
        public IList<Question> GetQuestions();
        Task<(IList<Question> records, int total, int totalDisplay)>
            GetPagedGetQuestionsAsync(int pageIndex, int pageSize, string searchText, string orderBy);
    }
}
