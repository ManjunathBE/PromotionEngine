using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace PromotionEngine.UnitTest
{
    [TestFixture]
    public class ProductServiceTest
    {
        private IProductService _productService;
        [SetUp]
        public void Init()
        {
            _productService = GetProductService();
        }

        private IProductService GetProductService()
        {
            return new ProductService();
        }

        [Test]
        public void When_Proper_Input_Passed_Correct_Result_Recieved()
        {
            var productsList = BuildProducts();
            var sut = _productService.GetTotalPrice(productsList);
            sut.Should().Equals(100);
        }

        [Test]
        public void When_Input_Is_Varied_Result_Should_Not_Match()
        {
            var productsList = BuildProducts();
            var sut = _productService.GetTotalPrice(productsList);
            sut.Should().NotBe(110);
        }

        [Test, TestCaseSource(nameof(ListOfProducts))]
        public void When_List_Of_Products_Passed_Correct_Result_Recieved(List<Product> products)
        {
            var sut = _productService.GetTotalPrice(products);
            sut.Should().Equals(100);
        }

        private static readonly object[] ListOfProducts =
        {
            new object[] { new List<Product>() { new Product("A"), new Product("B"), new Product("C") }},
            new object[] { new List<Product>() { new Product("A"), new Product("B"), new Product("C") }},
        };

        private List<Product> BuildProducts()
        {
            return new List<Product>() { new Product("A"), new Product("B"), new Product("C") };
        }
    }
}
