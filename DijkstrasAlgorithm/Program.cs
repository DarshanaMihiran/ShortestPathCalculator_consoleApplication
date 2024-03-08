using Autofac;
using Autofac.Core;
using DijkstrasAlgorithm.Configs;
using DijkstrasAlgorithm.Models;
using DijkstrasAlgorithm.Repositories.Interfaces;
using DijkstrasAlgorithm.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var repository = scope.Resolve<INodeRepository>();
                var service = scope.Resolve<ICalculatorService>();

                Console.WriteLine("Enter from node name here");
                string fromNode = Console.ReadLine();

                Console.WriteLine("Enter to node name here");
                string toNode = Console.ReadLine();

                var shortestPathData = service.FindShortestPath(fromNode.ToUpper(), toNode.ToUpper());

                // Convert NodeNames list to a comma-separated string
                string nodeNamesString = string.Join(", ", shortestPathData.NodeNames);

                // Print the comma-separated string to the console
                Console.WriteLine("NodeNames: " + nodeNamesString);
                Console.WriteLine("Distance: " + shortestPathData.Distance);
                Console.ReadLine();
            }
        }
    }
}
