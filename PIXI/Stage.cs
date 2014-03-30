using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PIXI
{
    public class Stage : DisplayObjectContainer
    {
        public int color;

        public Stage(int color)
        {
            this.color = color;
        }

        public void setBackgroundColor(int color)
        {
            this.color = color;
        }
    }
}
