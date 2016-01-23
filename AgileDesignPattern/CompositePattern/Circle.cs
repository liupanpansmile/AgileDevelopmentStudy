using System;

namespace CompositePattern
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}