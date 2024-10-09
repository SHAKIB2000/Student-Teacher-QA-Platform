using STPlatform.Application.Features.Discussion.Repositories;
using STPlatform.Domain.UnitOfWorks;
using System;
using System.Linq;

namespace STPlatform.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IQuestionRepository Questions { get; }
        IAnswerRepository Answers { get; }
    }
}
