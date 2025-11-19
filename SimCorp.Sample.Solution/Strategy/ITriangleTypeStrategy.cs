using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution.Strategy
{
    /// <summary>
    /// Interface for strategies finding TriangleType
    /// </summary>
    public interface ITriangleTypeStrategy
    {
        /// <summary>
        /// Gets the <see cref="TriangleType"/> for the strategy
        /// </summary>
        TriangleType TriangleType { get; }
       
        /// <summary>
        /// Detects if the strategy is a match
        /// </summary>
        /// <param name="sides"><see cref="TriangleSides"/> to mathc</param>
        /// <returns>Returns true if the strategy matches the expected triangle type</returns>
        bool Match(TriangleSides sides);
    }
}