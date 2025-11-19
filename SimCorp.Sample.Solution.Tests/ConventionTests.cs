using SimCorp.Sample.Entities;
using SimCorp.Sample.Solution.Strategy;
using System.Reflection;

namespace SimCorp.Sample.Solution.Tests
{
    internal class ConventionTests
    {

        [Test]
        public void NumberOfTriangleTypesMatchStrategies()
        {
            var interfaceType = typeof(ITriangleTypeStrategy);
            var assembly = Assembly.GetAssembly(interfaceType);
            var implementations = Assembly.GetAssembly(interfaceType)!
                .GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            Assert.That(implementations.Count(), Is.EqualTo(Enum.GetValues<TriangleType>().Length));
        }
    }
}
