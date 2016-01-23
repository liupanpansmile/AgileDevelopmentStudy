/*
 * composite pattern: 用一种一对一的方式表达了一对多的行为
 */

namespace CompositePattern
{
    class Program
    {
        public static void Draw(IShape shape)
        {
            shape.Draw();
        }
        public static void TestShape()
        {
            var circle = new Circle();
            var square = new Square();
            var compositeShape = new CompositeShape();
            compositeShape.Add(circle,square);
            Draw(compositeShape);
        }
        static void Main(string[] args)
        {
            TestShape();
        }
    }
}
