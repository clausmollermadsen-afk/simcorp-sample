using SimCorp.Sample.Entities;
using SimCorp.Sample.Solution.Factory;
using SimCorp.Sample.Solution.Pattern;
using SimCorp.Sample.Solution.Strategy;

namespace SimCorp.Sample.Solution
{
    internal class Program
    {
        private static void Main()
        {

            // We could use an IoC container here
            IList<ITriangleTypeStrategy> strategies =
            [
                new EquilateralStrategy(),
                new IsoscelesStrategy(),
                new ScaleneStrategy(),
            ];

            var strategyPattern = new StrategyPattern(strategies);

            IList<ITriangleDetector> triangleDetectors =
                [
                    new PatternMatching(),
                    strategyPattern,
                    new FactoryPattern(new TriangleFactory(strategyPattern))
                    ];


            while (true)
            {

                Console.WriteLine("Enter 3 numbers");
                if (!double.TryParse(Console.ReadLine(), out var sideA))
                {
                    Console.WriteLine("Entered values was not a double");
                }

                if (!double.TryParse(Console.ReadLine(), out var sideB))
                {
                    Console.WriteLine("Entered values was not a double");
                }

                if (!double.TryParse(Console.ReadLine(), out var sideC))
                {
                    Console.WriteLine("Entered values was not a double");
                }

                if (TriangleSides.TryCreate(sideA, sideB, sideC, out var triangleSides, out var errorMessage))
                {
                    foreach (var triangleDectector in triangleDetectors)
                    {
                        Console.WriteLine(triangleDectector.FindTriangleType(triangleSides));
                    }
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}
