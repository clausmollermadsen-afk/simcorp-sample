namespace SimCorp.Sample.Entities
{
    /// <summary>
    /// Base record for a triangle
    /// </summary>
    /// <param name="TriangleType">The triangle type <see cref="TriangleType"/></param>
    /// <param name="Side">The triangle sides <see cref="TriangleSides"/></param>
    public abstract record TriangleBase(TriangleType TriangleType, TriangleSides Side) : ITriangle;
}
