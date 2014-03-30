using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIXI
{
    public class Pixi
    {
        public static MonoCanvas autoDetectRenderer(int width, int height)
        {
            return new MonoCanvas();
        }
    }
}
