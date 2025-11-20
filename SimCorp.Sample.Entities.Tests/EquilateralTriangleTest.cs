namespace SimCorp.Sample.Entities.Tests
{
    public class EquilateralTriangleTest
    {

        [Test]
        public void CreateEquilateralTriangleWithSuccess()
        {
            if (TriangleSides.TryCreate(1, 1, 1, out var sides, out var _))
            {
                var triangle = new EquilateralTriangle(sides);
                Assert.That(triangle, Is.Not.Null);
                using (Assert.EnterMultipleScope())
                {
                    Assert.That(triangle.TriangleType, Is.EqualTo(TriangleType.Equilateral));
                    Assert.That(triangle.Side, Is.EqualTo(sides));
                }
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void CreateEquilateralTriangleWithFaillure()
        {
            if (TriangleSides.TryCreate(1, 2, 3, out var sides, out var _))
            {
                Assert.Throws<ArgumentException>(() => new EquilateralTriangle(sides));
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
