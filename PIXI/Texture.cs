using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace PIXI
{
    public class Texture
    {
        public Texture2D texture;

        public Texture(Texture2D texture)
        {
            this.texture = texture;
        }

        public static Texture fromImage(String path)
        {
            return new Texture(Texture2D.FromStream(MonoCanvas.Instance.GraphicsDevice, new FileStream(path, FileMode.Open)));
        }
    }
}
