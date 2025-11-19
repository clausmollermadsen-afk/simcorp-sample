using SimCorp.Sample.Entities;

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
                TriangleSides when sides.SideA == sides.SideB && sides.SideB == sides.SideC => TriangleType.Equilateral,
                TriangleSides when sides.SideA == sides.SideB || sides.SideB == sides.SideC || sides.SideA == sides.SideC => TriangleType.Isosceles,
                TriangleSides when sides.SideA != sides.SideB && sides.SideB != sides.SideC && sides.SideA != sides.SideC => TriangleType.Scalene,
                _ => throw new ArgumentException("No TriangleTypes could be dectected")
            };
        }
    }
}
