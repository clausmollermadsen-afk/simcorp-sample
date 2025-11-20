namespace SimCorp.Sample.Entities.Tests
{
    public class ScaleneTriangleTest
    {

        [Test]
        public void CreateScaleneTriangleWithSuccess()
        {
            if (TriangleSides.TryCreate(1, 2, 3, out var sides, out var _))
            {
                var triangle = new ScaleneTriangle(sides);
                using (Assert.EnterMultipleScope())
                {
                    Assert.That(triangle, Is.Not.Null);
                    Assert.That(triangle.TriangleType, Is.EqualTo(TriangleType.Scalene));
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
            if (TriangleSides.TryCreate(1, 1, 1, out var sides, out var _))
            {
                Assert.Throws<ArgumentException>(() => new ScaleneTriangle(sides));
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
