using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution.Strategy
{
    /// <summary>
    /// Implementation of <see cref="ITriangleDetector" using strategy pattern/>
    /// </summary>
    /// <param name="strategies">The list strategies uses <see cref="ITriangleTypeStrategy"/></param>
    public class StrategyPattern(IList<ITriangleTypeStrategy> strategies) : ITriangleDetector
    {
        /// <summary>
        /// The list of strategieis <see cref="ITriangleTypeStrategy"/>
        /// </summary>
        private readonly IList<ITriangleTypeStrategy> _strategies = strategies;

        /// <summary>
        /// Find the <see cref="TriangleType"/>
        /// </summary>
        /// <param name="side">Side to find to find <see cref="TriangleType"/> for</param>
        /// <returns>The found <see cref="TriangleType"/></returns>
        /// <exception cref="NotSupportedException">Throws <see cref="NotSupportedException"/> if <see cref="TriangleType" is not found/></exception>
        public TriangleType FindTriangleType(TriangleSides side)
        {
            var strategy = _strategies.SingleOrDefault(s => s.Match(side))
                ?? throw new NotSupportedException("Unable to detect a matching triangle strategy for the given side.");

            return strategy.TriangleType;
        }
    }
}
