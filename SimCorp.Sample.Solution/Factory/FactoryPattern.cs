using SimCorp.Sample.Entities;

namespace SimCorp.Sample.Solution.Factory
{

    /// <summary>
    /// Factory pattern implementation of <see cref="ITriangleDetector"/>
    /// </summary>
    /// <param name="triangleFactory">Factory who creates instances of <see cref="ITriangle"/> </param>
    public class FactoryPattern(TriangleFactory triangleFactory) : ITriangleDetector
    {
        private readonly TriangleFactory _triangleFactory = triangleFactory;

        public TriangleType FindTriangleType(TriangleSides sides)
        {
            return _triangleFactory.Create(sides).TriangleType;
        }
    }
}
