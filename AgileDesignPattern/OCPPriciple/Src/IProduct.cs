namespace OCPPriciple
{
    public interface IProduct 
    {
        string Name { get; set; }
        Color Color { get; set; } 
        Size Size { get; set; }

    }

    public enum Color
    {
        Red,
        Green,
        Yellow
    }

    public enum Size
    {
        Small,
        Middle,
        Large
    }
}
