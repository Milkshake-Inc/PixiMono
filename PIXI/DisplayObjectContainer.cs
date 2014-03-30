using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIXI
{
    public class DisplayObjectContainer : DisplayObject
    {
        public List<DisplayObject> children = new List<DisplayObject>();

        public void addChild(DisplayObject child)
        {
            Console.WriteLine("aDDED");
            children.Add(child);
        }

        public void addChildAt(DisplayObject child, int index)
        {
        }

        public DisplayObject getChildAt(int index)
        {
            return null;
        }

        public void removeChildAt(int index)
        {

        }

        public void removeChild(DisplayObject child)
        {

        }
    }
}
