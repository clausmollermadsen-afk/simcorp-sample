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
    }
}
