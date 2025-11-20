using SimCorp.Sample.Entities;
using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Solution.Strategy
{
    /// <summary>
    /// Implementation of <see cref="ITriangleTypeStrategy"/ for a <see cref="TriangleType.Isosceles"/> triangle>
    /// </summary>
    public sealed class IsoscelesStrategy : ITriangleTypeStrategy
    {
        /// <inheritdoc/>
        public TriangleType TriangleType => TriangleType.Isosceles;

        /// <inheritdoc/>
        public bool Match(TriangleSides sides)
            => sides.IsIsosceles();
    }
}
