using Autofac;
using System;
using System.Linq;

namespace STPlatform.Application
{
    public class ApplicationModule : Module

    {
        public ApplicationModule()
        {
        }
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
