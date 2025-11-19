using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution.Factory
{
    /// <summary>
    /// Implementation of <see cref="TriangleBase"/> for a Scalene Triangle, <see cref="TriangleType.Scalene"/>/>
    /// </summary>
    /// <param name="TriangleType">The triangle type, <see cref="TriangleType"/></param>
    /// <param name="sides'">The triangle sides <see cref="TriangleSides"/></param>
    public record ScaleneTriangle(TriangleType TriangleType, TriangleSides Side) : TriangleBase(TriangleType, Side)
    {

        /// <summary>
        /// Creates an instance of <see cref="ScaleneTriangle"/>
        /// </summary>
        /// <param name="side">The triangle sides <see cref="TriangleSides"/></param>
        internal ScaleneTriangle(TriangleSides side) : this(TriangleType.Scalene, side)
        {
        }
    }
}
