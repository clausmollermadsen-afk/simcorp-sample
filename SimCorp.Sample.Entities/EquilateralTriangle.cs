using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Entities
{
    /// <summary>
    /// Implementation of <see cref="TriangleBase"/> for a Equilateral Triangle, <see cref="TriangleType.Equilateral"/>/>
    /// </summary>
    /// <param name="TriangleType">The triangle type, <see cref="TriangleType"/></param>
    /// <param name="Side'">The triangle sides <see cref="TriangleSides"/></param>
    public record EquilateralTriangle(TriangleType TriangleType, TriangleSides Side) : TriangleBase(TriangleType, Side)
    {
        /// <summary>
        /// Creates an instance of <see cref="EquilateralTriangle"/>
        /// </summary>
        /// <param name="side">The triangle sides <see cref="TriangleSides"/></param>
        public EquilateralTriangle(TriangleSides side) : this(TriangleType.Equilateral, side)
        {
            if (!side.IsEquilateral())
            {
                throw new ArgumentException("Triangle is not Equilateral");
            }
        }
    }
}
