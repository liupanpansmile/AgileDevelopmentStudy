using System;

namespace AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine(  "Wild Turkey is flying a shor distance");
        }

        public void Sing()
        {
            Console.WriteLine("Diu Diu");
        }
    }
}