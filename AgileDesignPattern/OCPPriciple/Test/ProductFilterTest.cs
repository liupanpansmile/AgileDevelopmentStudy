using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OCPPriciple.Test
{
    [TestFixture]
    class ProductFilterTest
    {
        private readonly IList<IProduct> _productList = new List<IProduct>();
        private readonly IFilter filter = new ProductFilter();
            
        [TestFixtureSetUp]
        public void StartUp()
        {
            CreateFakeProduct();
        }

        [Test]
        public void TestColorFilter()
        {
            Color color = Color.Red;

            var colorSpecification = new ColorSpecification(color);
            IList<IProduct> filterList = filter.Filter(_productList, colorSpecification);
            foreach (var product in filterList)
            {
                Assert.AreEqual(product.Color, color);
            }
        }

        [Test]
        public void TestSizeFilter()
        {
            Size size = Size.Middle;

            var sizeSpecification = new SizeSpecification(size);
            IList<IProduct> filterList = filter.Filter(_productList, sizeSpecification);
            foreach (var product in filterList)
            {
                Assert.AreEqual(product.Size, size);
            }
        }

        [Test]
        public void TestOrFilter()
        {
            Size size = Size.Large;
            Color color = Color.Red;
            var spec1 = new SizeSpecification(size);
            var spec2 = new ColorSpecification(color);
            var orSizeSpecification = new OrSpecification(spec1, spec2);

            IList<IProduct> filterList = filter.Filter(_productList, orSizeSpecification);
            foreach (var product in filterList)
            {
                bool matched = (product.Color == color) || (product.Size == size);
                Assert.IsTrue(matched);
            }
        }
        
        [Test]
        public void TestColorAndSizeFilter()
        {
            Size size = Size.Large;
            Color color = Color.Red;
            var spec1 = new SizeSpecification(size);
            var spec2 = new ColorSpecification(color);
            var andSizeSpecification = new AndSpecification(spec1, spec2);

            IList<IProduct> filterList = filter.Filter(_productList, andSizeSpecification);
            foreach (var product in filterList)
            {
                bool matched = (product.Color == color) && (product.Size == size);
                Assert.IsTrue(matched);
            }
        }

        void CreateFakeProduct()
        {
            _productList.Add(new FakeProduct() {Name="Apple", Color=Color.Red, Size=Size.Small});
            _productList.Add(new FakeProduct() { Name = "Orange", Color = Color.Green, Size = Size.Small });
            _productList.Add(new FakeProduct() { Name = "Pear", Color = Color.Green, Size = Size.Middle });
            _productList.Add(new FakeProduct() { Name = "Branana", Color = Color.Yellow, Size = Size.Large });
            _productList.Add(new FakeProduct() { Name = "Lemon", Color = Color.Green, Size = Size.Middle });
            _productList.Add(new FakeProduct() { Name = "WaterMelon", Color = Color.Red, Size = Size.Large });
        }

        class FakeProduct : IProduct
        {
            public string Name { get; set; }
            public Color Color { get; set; }
            public Size Size { get; set; }

        }
    }
}
