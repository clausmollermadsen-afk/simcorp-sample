using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Entities
{

    /// <summary>
    /// Implementation of <see cref="TriangleBase"/> for a Isosceles Triangle, <see cref="TriangleType.Isosceles"/>/>
    /// </summary>
    /// <param name="TriangleType">The triangle type, <see cref="TriangleType"/></param>
    /// <param name="Side'">The triangle sides <see cref="TriangleSides"/></param>
    public record IsoscelesTriangle(TriangleType TriangleType, TriangleSides Side) : TriangleBase(TriangleType, Side)
    {
        /// <summary>
        /// Creates an instance of <see cref="IsoscelesTriangle"/>
        /// </summary>
        /// <param name="side">The triangle sides <see cref="TriangleSides"/></param>
        public IsoscelesTriangle(TriangleSides side) : this(TriangleType.Isosceles, side)
        {
            if (!side.IsIsosceles())
            {
                throw new ArgumentException("Triangle is not Isosceles");
            }
        }
    }
}
