using System;

namespace CompositePattern
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}