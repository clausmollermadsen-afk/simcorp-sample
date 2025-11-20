namespace SimCorp.Sample.Entities.Tests
{
    public class IsoscelesTest
    {

        [Test]
        public void CreateIsoscelesTriangleWithSuccess()
        {
            if (TriangleSides.TryCreate(1, 1, 3, out var sides, out var _))
            {
                var triangle = new IsoscelesTriangle(sides);
                using (Assert.EnterMultipleScope())
                {
                    Assert.That(triangle, Is.Not.Null);
                    Assert.That(triangle.TriangleType, Is.EqualTo(TriangleType.Isosceles));
                    Assert.That(triangle.Side, Is.EqualTo(sides));
                }
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void CreateIsoscelesTriangleWithFaillure()
        {
            if (TriangleSides.TryCreate(1, 1, 1, out var sides, out var _))
            {
                Assert.Throws<ArgumentException>(() => new IsoscelesTriangle(sides));
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
