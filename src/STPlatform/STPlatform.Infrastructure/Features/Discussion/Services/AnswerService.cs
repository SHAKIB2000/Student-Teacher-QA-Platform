using STPlatform.Application;
using STPlatform.Application.Features.Discussion.Services;
using STPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPlatform.Infrastructure.Features.Discussion.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        public AnswerService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddAnswer(string content, DateTime postedDate, Guid teacherId, Guid questionId)
        {
            Answer answer = new Answer();
            answer.Content = content;
            answer.PostedDate = postedDate;
            answer.TeacherId = teacherId;
            answer.QuestionId = questionId;

            _unitOfWork.Answers.Add(answer);
            _unitOfWork.Save();
        }

        public Answer GetAnswer(Guid id)
        {
            return _unitOfWork.Answers.GetById(id);
        }

        public IList<Answer> GetAnswers()
        {
            return _unitOfWork.Answers.GetAll();
        }

    }
}
