using Autofac;
using DijkstrasAlgorithm.Repositories;
using DijkstrasAlgorithm.Repositories.Interfaces;
using DijkstrasAlgorithm.Services;
using DijkstrasAlgorithm.Services.Interfaces;

namespace DijkstrasAlgorithm.Configs
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NodeRepository>().As<INodeRepository>();
            builder.RegisterType<CalculatorService>().As<ICalculatorService>();
            return builder.Build();
        }
    }

}
