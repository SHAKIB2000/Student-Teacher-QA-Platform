using STPlatform.Application;
using STPlatform.Application.Features.Discussion.Services;
using STPlatform.Domain.Entities;
namespace STPlatform.Infrastructure.Features.Discussion.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        public QuestionService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddQuestion(string title, string topic, string content, DateTime postedDate, Guid studentId)
        {
            Question question = new Question();
            question.Title = title;
            question.Topic = topic;
            question.Content = content;
            question.PostedDate = postedDate;
            question.StudentId = studentId;

            _unitOfWork.Questions.Add(question);
            _unitOfWork.Save();
        }

        public void DeleteQuestion(Guid id)
        {
            _unitOfWork.Questions.Remove(id);
            _unitOfWork.Save();
        }

        public async Task<(IList<Question> records, int total, int totalDisplay)> 
            GetPagedGetQuestionsAsync(int pageIndex, int pageSize, string searchText, string orderBy)
        {
            var result = await _unitOfWork.Questions.GetTableDataAsync(x =>
            x.Title.Contains(searchText), orderBy, pageIndex, pageSize);

            return result;
        }

        public Question GetQuestion(Guid id)
        {
            return _unitOfWork.Questions.GetById(id);
        }

        public IList<Question> GetQuestions()
        {
            return _unitOfWork.Questions.GetAll();
        }
    }
}
