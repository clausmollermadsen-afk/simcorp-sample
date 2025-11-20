using SimCorp.Sample.Entities.Extensions;

namespace SimCorp.Sample.Entities.Tests
{
    public class TriangleSidesTest
    {

        [Test]
        public void CreateLegalAndVerifyEquals()
        {

            using (Assert.EnterMultipleScope())
            {
                Assert.That(TriangleSides.TryCreate(1, 2, 3, out var sidesA, out var _), Is.True);
                Assert.That(TriangleSides.TryCreate(1, 2, 3, out var sidesB, out var _), Is.True);
                Assert.That(TriangleSides.TryCreate(1, 2, 4, out var sidesC, out var _), Is.True);


                Assert.That(sidesA, Is.EqualTo(sidesB));
                Assert.That(sidesA, Is.Not.EqualTo(sidesC));
            }
        }

        [TestCase(0, 1, 2)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(double.NaN, 1, 2)]
        [TestCase(1, double.NaN, 1)]
        [TestCase(1, 1, double.NaN)]
        public void CreateIllegalReturnFalseAndHasErrorMessage(double sideA, double sideB, double sideC)
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That(TriangleSides.TryCreate(sideA, sideB, sideC, out var triangleSides, out var errorMessage), Is.False);
                Assert.That(errorMessage, Is.Not.Null);
            }
        }


        [TestCase(1, 2, 3, true)]
        [TestCase(1, 1, 2, false)]
        [TestCase(1, 2, 1, false)]
        [TestCase(2, 1, 1, false)]
        public void VerifyIsIsScalene(double sideA, double sideB, double sideC, bool expected)
        {
            if (TriangleSides.TryCreate(sideA, sideB, sideC, out var sides, out var _))
            {
                Assert.That(sides.IsScalene(), Is.EqualTo(expected));
            }
        }

        [TestCase(1, 1, 2, true)]
        [TestCase(1, 2, 1, true)]
        [TestCase(2, 1, 1, true)]
        [TestCase(1, 1, 1, false)]
        [TestCase(1, 2, 3, false)]
        public void VerifyIsIsosceles(double sideA, double sideB, double sideC, bool expected)
        {
            if (TriangleSides.TryCreate(sideA, sideB, sideC, out var sides, out var _))
            {
                Assert.That(sides.IsIsosceles(), Is.EqualTo(expected));
            }
        }

        [TestCase(1, 1, 2, false)]
        [TestCase(1, 2, 1, false)]
        [TestCase(2, 1, 1, false)]
        [TestCase(1, 1, 1, true)]
        [TestCase(1, 2, 3, false)]
        public void VerifyIsEquilateral(double sideA, double sideB, double sideC, bool expected)
        {
            if (TriangleSides.TryCreate(sideA, sideB, sideC, out var sides, out var _))
            {
                Assert.That(sides.IsEquilateral(), Is.EqualTo(expected));
            }
        }
    }
}
