namespace SimCorp.Sample.Entities
{

    /// <summary>
    /// Definition of triangle
    /// </summary>
    public interface ITriangle
    {
        /// <summary>
        /// Gets the triangle type
        /// </summary>
        TriangleType TriangleType { get; init; }

        /// <summary>
        /// Gets the length of the sides of triangle
        /// </summary>
        TriangleSides Side { get; init; }
    }
}
