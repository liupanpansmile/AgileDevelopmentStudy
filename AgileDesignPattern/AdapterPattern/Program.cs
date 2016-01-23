namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkey = new WildTurkey();
            var duck = new DuckAdapter(turkey); 
            duck.Sing();
            duck.Fly();
        }
    }
}
