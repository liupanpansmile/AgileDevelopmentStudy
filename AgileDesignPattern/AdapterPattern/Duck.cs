using System;

namespace AdapterPattern
{
    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying a long distance");
        }

        public void Sing()
        {
            Console.WriteLine("Du Du");
        }
    }
}