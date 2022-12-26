using Autofac;
using CleanArchitectureProject.Core.Interfaces;
using CleanArchitectureProject.Core.Services;

namespace CleanArchitectureProject.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
