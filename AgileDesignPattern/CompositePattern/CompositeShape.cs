using System.Collections.Generic;

namespace CompositePattern
{
    class CompositeShape : IShape
    {
        private List<IShape> _shapeList;

        public CompositeShape()
        {
            _shapeList = new List<IShape>();
        }

        public void Draw()
        {
            foreach (var shape in _shapeList)
            {
                shape.Draw();
            }
        }

        public void Add(IShape shape)
        {
            if (shape != null)
            {
                _shapeList.Add(shape);
            }   
        }

        public void Add(params IShape[] shapes)
        {
            if (shapes == null)
                return;
            foreach (var shape in shapes)
            {
                Add(shape);
            }
        }
        public void Remove(IShape shape)
        {
            if (_shapeList.Contains(shape))
            {
                _shapeList.Remove(shape);
            }
        }
    }
}