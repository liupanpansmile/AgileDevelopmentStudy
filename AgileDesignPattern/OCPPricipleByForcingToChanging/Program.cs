using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPPricipleByForcingToChanging
{
    /*
     * 遵守OCP(Open Close Priciple)
     * 需求是Shape List 所有的Circle要在Square前调用,但是也要遵循OCP。
     */
    class Program
    {
        
        static void DrawAllShapes(List<Shape> shapeList)
        {
            shapeList.Sort(new ShapeComparision());

            foreach(var shape in shapeList)
            {
                shape.Draw();
            }
        }
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>(new Shape[] {new Circle(), new Square(), new Circle(), new Square()});

            DrawAllShapes(shapeList);
        }
    }
}
