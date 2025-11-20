using SimCorp.Sample.Entities.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace SimCorp.Sample.Entities
{
    /// <summary>
    /// Types of triangles
    /// </summary>
    public enum TriangleType
    {
        /// <summary>
        /// Equilateral triangle where all sides have same length 
        /// </summary>
        Equilateral,

        /// <summary>
        /// Isosceles triangle where two sides have same length
        /// </summary>
        Isosceles,

        /// <summary>
        /// Scalene triangle where all sides have different length 
        /// </summary>
        Scalene
    }

    /// <summary>
    /// Hold values for the side length of a triangle. All sides allways has value > 0
    /// </summary>
    public record TriangleSides
    {
        /// <summary>
        /// Gets the length of sideA
        /// </summary>
        public double SideA { get; init; }

        /// <summary>
        /// Gets the length if SideB
        /// </summary>
        public double SideB { get; init; }

        /// <summary>
        /// Gets the length of SideC
        /// </summary>
        public double SideC { get; init; }

        /// <summary>
        /// Contructor for <see cref="TriangleSides"/>
        /// </summary>
        /// <param name="sideA">Length of side A</param>
        /// <param name="sideB">Length of side B</param>
        /// <param name="sideC">Length of side C</param>
        private TriangleSides(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }


        /// <summary>
        /// Creates an instance of <see cref="TriangleSides"/>
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="triangleSides">Assigned side values if valid</param>
        /// <param name="errorMessage">Error message side values is invalid</param>
        /// <returns>Return true side values is valid</returns>
        /// <exception cref="ArgumentException"><see cref="ArgumentException"/> is if one side has value <= 0 or is Nan</exception>
        public static bool TryCreate(double sideA, double sideB, double sideC, [NotNullWhen(true)] out TriangleSides? triangleSides, [NotNullWhen(false)] out string? errorMessage)
        {
            triangleSides = null;
            if (!EnsureGreaterThanZero(sideA, nameof(sideA), out errorMessage))
            {
                return false;
            }

            if (!EnsureGreaterThanZero(sideB, nameof(sideB), out errorMessage))
            {
                return false;
            }

            if (!sideC.EnsureGreaterThanZero(nameof(sideC), out errorMessage))
            {
                return false;
            }

            triangleSides = new TriangleSides(sideA, sideB, sideC);
            return true;
        }
    }
}
