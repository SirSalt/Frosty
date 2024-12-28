using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Frosty
{
    public class SpriteSheet
    {
        public Vector2 _origin;

        public Texture2D _texture;
        public int _spriteSize = 70;
        //public Rectangle _dedstinationRectangle = new Rectangle((int)_origin.X, (int)_origin.Y, _spriteSize, _spriteSize);



        public List<Point> sprites = new List<Point>();



        public void Update(GameTime gameTime)
        {
            SpriteSizeCalulator();

        }


        public int SpriteSizeCalulator()
        {
            _spriteSize = _texture.Width / 14;

            return _spriteSize;

        }

        public Point SpriteList()
        {
            //made a list for every sprite in the spritesheet.
            //13*6 -1 = 77 sprites max.

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 14; x++)
                {
                    sprites.Add(new Point(x, y));

                }
            }



            return new Point(0, 0);
        }


        public void DrawSprite(SpriteBatch spritebatch, Point sprite, Vector2 position)
        {
            //_dedstinationRectangle = new Rectangle((int)_origin.X, (int)_origin.Y, _spriteSize, _spriteSize);


            spritebatch.Draw(_texture, position, new Rectangle(0 + _spriteSize * sprite.X, 0 + _spriteSize * sprite.Y, _spriteSize, _spriteSize), Color.White);


        }



    }
}
