using Autofac;
using STPlatform.Application.Features.Discussion.Services;
using STPlatform.Infrastructure.Features.Discussion.Services;
using System;
using System.Linq;

namespace STPlatform.Infrastructure
{
    public class InfrastructureModule : Module
    {
        public InfrastructureModule()
        {
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<QuestionService>().As<IQuestionService>().InstancePerLifetimeScope();
            builder.RegisterType<AnswerService>().As<IAnswerService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
