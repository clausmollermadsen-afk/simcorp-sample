using SimCorp.Sample.Entities;
using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Solution.Pattern
{

    /// <summary>
    /// Implementation of <see cref="ITriangleDetector"/> using pattern matching/>
    /// </summary>
    public class PatternMatching : ITriangleDetector
    {
        public TriangleType FindTriangleType(TriangleSides sides)
        {
            return sides switch
            {
                TriangleSides when sides.IsEquilateral() => TriangleType.Equilateral,
                TriangleSides when sides.IsIsosceles() => TriangleType.Isosceles,
                TriangleSides when sides.IsScalene() => TriangleType.Scalene,
                _ => throw new ArgumentException("No TriangleTypes could be dectected")
            };
        }
    }
}
