using STPlatform.Domain.Entities;
using System;
using System.Linq;

namespace STPlatform.Application.Features.Discussion.Services
{
    public interface IAnswerService
    {
        void AddAnswer(string content, DateTime postedDate, Guid teacherId, Guid questionId);
        Answer GetAnswer(Guid id);
        public IList<Answer> GetAnswers();
    }
}
