using SimCorp.Sample.Entities;

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
        {
            return sides.SideA == sides.SideB && sides.SideB == sides.SideC;
        }
    }
}
