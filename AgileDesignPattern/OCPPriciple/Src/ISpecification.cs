namespace OCPPriciple
{
    public interface ISpecification
    {
        bool IsMatched(IProduct element);
    }

    public class ColorSpecification : ISpecification
    {
        private readonly Color _color;
        public ColorSpecification (Color color)
        {
            _color = color;
        }

        public bool IsMatched(IProduct element)
        {
            if (element == null)
                return false;

            return _color == element.Color;
        }
    }

    public class SizeSpecification : ISpecification
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsMatched(IProduct element)
        {
            if (element == null)
                return false;

            return _size == element.Size;
        }
    }

    public class OrSpecification : ISpecification
    {
        private readonly ISpecification _specification1;
        private readonly ISpecification _specification2;

        public OrSpecification(ISpecification spec1, ISpecification spec2)
        {
            _specification1 = spec1;
            _specification2 = spec2;
        }

        public bool IsMatched(IProduct element)
        {
            if (element == null)
            {
                return false;
            }

            return _specification1.IsMatched(element) || _specification2.IsMatched(element);
        }
    }

    public class AndSpecification : ISpecification
    {
        private readonly ISpecification _specification1;
        private readonly ISpecification _specification2;

        public AndSpecification(ISpecification spec1, ISpecification spec2)
        {
            _specification1 = spec1;
            _specification2 = spec2;
        }

        public bool IsMatched(IProduct element)
        {
            if (element == null)
            {
                return false;
            }

            return _specification1.IsMatched(element) && _specification2.IsMatched(element);
        }
    }

}
