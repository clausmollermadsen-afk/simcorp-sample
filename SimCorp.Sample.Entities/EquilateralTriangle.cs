namespace SimCorp.Sample.Entities
{
    /// <summary>
    /// Implementation of <see cref="TriangleBase"/> for a Equilateral Triangle, <see cref="TriangleType.Equilateral"/>/>
    /// </summary>
    /// <param name="TriangleType">The triangle type, <see cref="TriangleType"/></param>
    /// <param name="Sides'">The triangle sides <see cref="TriangleSides"/></param>
    public record EquilateralTriangle(TriangleType TriangleType, TriangleSides Sides) : TriangleBase(TriangleType, Sides)
    {
        /// <summary>
        /// Creates an instance of <see cref="EquilateralTriangle"/>
        /// </summary>
        /// <param name="side">The triangle sides <see cref="TriangleSides"/></param>
        public EquilateralTriangle(TriangleSides side) : this(TriangleType.Equilateral, side)
        {
        }
    }
}
