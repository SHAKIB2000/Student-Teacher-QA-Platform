using STPlatform.Application;
using STPlatform.Application.Features.Discussion.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace STPlatform.Persistence
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IQuestionRepository Questions { get; private set; }
        public IAnswerRepository Answers { get; private set; }
        public ApplicationUnitOfWork(IApplicationDbContext dbContext, IQuestionRepository questions, IAnswerRepository answers) : base((DbContext)dbContext)
        {
            Questions = questions;
            Answers = answers;
        }
    }
}