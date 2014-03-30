using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIXI
{
    public class DisplayObject
    {
        public float alpha;
        public DisplayObjectContainer parent;

        public Point anchor;
        public Point position;
        public double rotation;
        public Point scale;
        public Stage stage;
        public bool visible;

        public DisplayObject()
        {
            anchor = new Point(0, 0);
            position = new Point(0, 0);
            rotation = 0;
            scale = new Point(1, 1);
            visible = true;
        }
    }
}
