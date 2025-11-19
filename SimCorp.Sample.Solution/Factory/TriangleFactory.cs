using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution.Factory
{

    /// <summary>
    /// Factory creating instances of ITriangle
    /// </summary>
    /// <param name="triangleDetector"><see cref="ITriangleDetector"/> do identify the triangle type</param>
    public class TriangleFactory(ITriangleDetector triangleDetector)
    {

        /// <summary>
        /// The <see cref="ITriangleDetector"/>
        /// </summary>
        private readonly ITriangleDetector _triangleDetector = triangleDetector;

        /// <summary>
        /// Create an instance of <see cref="ITriangle"/>
        /// </summary>
        /// <param name="sides"></param>
        /// <returns>Created instance of <see cref="ITriangle"/></returns>
        /// <exception cref="NotSupportedException">Throws <see cref="NotSupportedException"/> if triangle type could not be identified</exception>
        public ITriangle Create(TriangleSides sides)
        {
            var triangleType = _triangleDetector.FindTriangleType(sides);
            return triangleType switch
            {
                TriangleType.Equilateral => new EquilateralTriangle(sides),
                TriangleType.Isosceles => new IsoscelesTriangle(sides),
                TriangleType.Scalene => new ScaleneTriangle(sides),
                _ => throw new NotSupportedException("No TriangleTypes could be dectected"),
            };
        }
    }
}
