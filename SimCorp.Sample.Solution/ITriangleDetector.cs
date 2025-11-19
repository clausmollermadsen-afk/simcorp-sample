using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution
{

    /// <summary>
    /// Interface defining implementations of instances who finds <see cref="TriangleType"/>
    /// </summary>

    public interface ITriangleDetector
    {

        /// <summary>
        /// Finds the <see cref="TriangleType"/>
        /// </summary>
        /// <param name="sides">Sides of the triangle</param>
        /// <returns>The TriangleType</returns>
        public TriangleType FindTriangleType(TriangleSides sides);
    }
}
