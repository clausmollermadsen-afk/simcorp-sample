using SimCorp.Sample.Entities;

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
        {
            return sides.SideA != sides.SideB && sides.SideB != sides.SideC && sides.SideA != sides.SideC;
        }
    }
}
