using SimCorp.Sample.Entities;
using SimCorp.Sample.Solution.Factory;
using SimCorp.Sample.Solution.Pattern;
using SimCorp.Sample.Solution.Strategy;

namespace SimCorp.Sample.Solution.Tests
{
    public class TriangleDetectorTests
    {
        private List<ITriangleDetector> _triangleDetectors;

        [SetUp]
        public void Setup()
        {
            IList<ITriangleTypeStrategy> strategies =
            [
                new EquilateralStrategy(),
                new IsoscelesStrategy(),
                new ScaleneStrategy(),
            ];

            var strategyPattern = new StrategyPattern(strategies);

            this._triangleDetectors =
                [
                    new PatternMatching(),
                    strategyPattern,
                    new FactoryPattern(new TriangleFactory(strategyPattern))
                    ];
        }

        [TestCase(1.0, 1.0, 1.0, TriangleType.Equilateral)]
        [TestCase(1.0, 1.0, 2.0, TriangleType.Isosceles)]
        [TestCase(1.0, 2.0, 1.0, TriangleType.Isosceles)]
        [TestCase(2.0, 1.0, 1.0, TriangleType.Isosceles)]
        [TestCase(1.0, 2.0, 3.0, TriangleType.Scalene)]
        public void TriangleDetectorTest(double sideA, double sideB, double sideC, TriangleType triangleType)
        {
            if (TriangleSides.TryCreate(sideA, sideB, sideC, out var triangleSides, out var _))
            {
                foreach (var triangleDectector in this._triangleDetectors)
                {
                    Assert.That(triangleDectector.FindTriangleType(triangleSides), Is.EqualTo(triangleType));
                }
            }
            else
            {
                Assert.Fail("Test failed");
            }
        }
    }
}

