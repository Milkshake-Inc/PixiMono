using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PIXI
{
    public class MonoCanvas : Game, IRenderer
    {
        public static MonoCanvas Instance;

        RenderTarget2D renderTarget;
        SpriteBatch spriteBatch;
        GraphicsDeviceManager graphics;

        int width;
        int height;

        public MonoCanvas()
        {
            Instance = this;
        }

        public void Boot(int width, int height)
        {
            this.width = width;
            this.height = height;

            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = width;
            graphics.PreferredBackBufferHeight = height;
            graphics.ApplyChanges();   
        }

        protected override void Initialize()
        {
            base.Initialize();

            renderTarget = new RenderTarget2D(GraphicsDevice, width, height);
            spriteBatch = new SpriteBatch(GraphicsDevice);

            
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(renderTarget, Vector2.Zero, Color.White);
            spriteBatch.End();            
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        private Color UIntToColor(int color)
        {
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return new Color(r, g, b);
        }

        

        public void Render(Stage stage)
        {
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(UIntToColor(stage.color));

            spriteBatch.Begin();

            Console.WriteLine(stage.children.Count());

            DrawDisplayObject(Vector2.Zero, stage);

            spriteBatch.End();

            GraphicsDevice.SetRenderTarget(null);
        }

        public void DrawDisplayObject(Vector2 offset, DisplayObjectContainer displayObject)
        {
            offset += new Vector2((float)displayObject.position.x, (float)displayObject.position.y);

            foreach (DisplayObjectContainer display in displayObject.children)
            {
                if (display is Sprite)
                {
                    Texture2D texture = (display as Sprite).texture.texture;

                    spriteBatch.Draw(texture, new Vector2((float)display.position.x, (float)display.position.y), new Rectangle(0, 0, texture.Width, texture.Height), Color.White, (float)display.rotation, new Vector2(texture.Width * (float)display.anchor.x, texture.Height * (float)display.anchor.y), new Vector2((float)display.scale.x, (float)display.scale.y), SpriteEffects.None, 0);
                }

                if (display is DisplayObjectContainer)
                {
                    DrawDisplayObject(offset, (display as DisplayObjectContainer));
                }
            }
        }
    }
}
