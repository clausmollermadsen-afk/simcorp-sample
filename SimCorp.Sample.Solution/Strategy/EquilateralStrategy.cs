using SimCorp.Sample.Entities;
using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Solution.Strategy
{
    /// <summary>
    /// Implementation of <see cref="ITriangleTypeStrategy"/ for a <see cref="TriangleType.Equilateral"/> triangle>
    /// </summary>
    public sealed class EquilateralStrategy : ITriangleTypeStrategy
    {
        /// <inheritdoc/>
        public TriangleType TriangleType => TriangleType.Equilateral;


        /// <inheritdoc/>
        public bool Match(TriangleSides sides)
            => sides.IsEquilateral();
    }
}
