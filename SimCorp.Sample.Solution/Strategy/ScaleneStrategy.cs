using SimCorp.Sample.Entities;
using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Solution.Strategy
{

    /// <summary>
    /// Implementation of <see cref="ITriangleTypeStrategy"/ for a <see cref="TriangleType.Scalene"/> triangle>
    /// </summary>
    public sealed class ScaleneStrategy : ITriangleTypeStrategy
    {

        /// <inheritdoc/>
        public TriangleType TriangleType => TriangleType.Scalene;

        /// <inheritdoc/>
        public bool Match(TriangleSides sides)
            => sides.IsScalene();
    }
}
