using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPPricipleByForcingToChanging
{
    
    /*
     * Shape 基类
     */
    public abstract class Shape 
    {
        public abstract  void Draw();
    }

    class ShapeComparision :IComparer<Shape>
    {
        public int Compare(Shape thisShape,Shape otherShape)
        {
            bool isDone = false;
            int thisShapeIndex = -1;
            int otherShapeIndex = -1;
            for (int i = 0; !isDone;++i )
            {
                string name = EntryTable.Table[i];
                if(name != "0")
                {
                    if(name == thisShape.GetType().Name)
                    {
                        thisShapeIndex = i;
                    }
                    else if (name == otherShape.GetType().Name)
                    {
                        otherShapeIndex = i;
                    }
                    else
                    {
                        isDone = true;
                    }
                }
                else
                {
                    isDone = true;
                }
            }
            return (thisShapeIndex - otherShapeIndex);
        }
    }
}
