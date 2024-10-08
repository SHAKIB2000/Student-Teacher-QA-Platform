using Autofac;
using STPlatform.Web.Models.Auth;

namespace STPlatform.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterModel>().AsSelf();

            base.Load(builder);
        }
    }
}
