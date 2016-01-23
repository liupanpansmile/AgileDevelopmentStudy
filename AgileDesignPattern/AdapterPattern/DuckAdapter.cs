namespace AdapterPattern
{

    /*
     * Object Adapter
     */
    public class DuckAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public DuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; ++i)
            {
                _turkey.Fly();     
            }
        }

        public void Sing()
        {
            _turkey.Sing();
        }
    }
}