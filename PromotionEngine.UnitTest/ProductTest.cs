using FluentAssertions;
using NUnit.Framework;

namespace PromotionEngine.UnitTest
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void When_Ctor_Called_Does_Not_Throw_Error()
        {
            var sut = new Product("A");

            sut.Should().NotBeNull();
        }

        [Test]
        public void When_Proper_Type_Passed_Expect_Actual_Type()
        {
            var sut = new Product("A");

            var expected = new Product("A");

            sut.Should().Equals(expected);

            Assert.Multiple(() =>
            {
                Assert.That(sut.Id, Is.EqualTo(expected.Id));
                Assert.That(sut.Price, Is.EqualTo(expected.Price));
            });
        }

        [Test]
        public void When_Wrong_Type_Passed_Return_Type_Should_Not_Be_Equal_Type()
        {
            var sut = new Product("B");

            var expected = new Product("A");

            sut.Should().NotBeEquivalentTo(expected);
        }

        [TestCase("A")]
        [TestCase("B")]
        [TestCase("C")]
        [TestCase("D")]
        public void When_Wrong_Type_Passed_expect_actual_type11(string type)
        {
            var sut = new Product(type);

            var expected = new Product(type);

            sut.Should().Equals(expected);
        }
    }
}
