namespace SimCorp.Sample.Entities.Extensions
{
    /// <summary>
    /// Extions for <see cref="TriangleSides"/>
    /// </summary>
    public static class TriangleSidesExtensions
    {
        /// <summary>
        /// Return true if sides is isoceles
        /// </summary>
        /// <param name="sides">Sides of the triangle</param>
        /// <returns>Return true sides if isoceles</returns>
        public static bool IsIsosceles(this TriangleSides sides)
            => (sides.SideA == sides.SideB || sides.SideB == sides.SideC || sides.SideA == sides.SideC)
                && !(sides.SideA == sides.SideB && sides.SideB == sides.SideC);

        /// <summary>
        /// Return true if sides is equilateral
        /// </summary>
        /// <param name="sides">Sides of the triangle</param>
        /// <returns>Return true sides if equilateral</returns>
        public static bool IsEquilateral(this TriangleSides sides)
            => sides.SideA == sides.SideB && sides.SideB == sides.SideC;

        /// <summary>
        /// Return true if sides is scalene
        /// </summary>
        /// <param name="sides">Sides of the triangle</param>
        /// <returns>Return true sides if scalenel</returns>
        public static bool IsScalene(this TriangleSides sides)
            => sides.SideA != sides.SideB && sides.SideB != sides.SideC && sides.SideA != sides.SideC;
    }
}
