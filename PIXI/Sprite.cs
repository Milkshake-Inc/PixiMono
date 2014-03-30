using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIXI
{
    public class Sprite : DisplayObjectContainer
    {
        public Texture texture;

        public Sprite(Texture texture)
        {
            this.texture = texture;
        }
    }
}
