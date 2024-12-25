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
        static Vector2 _origin = new Vector2(100, 100);

        public Texture2D _texture;
        static int _spriteSize;
        Rectangle _spriteBounds = new Rectangle((int)_origin.X, (int)_origin.Y, _spriteSize, _spriteSize);



        public void Update(GameTime gameTime)
        {
            SpriteSizeCalulator(_texture);
        }


        int SpriteSizeCalulator(Texture2D spriteSheet)
        {
            _spriteSize = spriteSheet.Width / 14;

            return _spriteSize;
        }


        public void DrawSprite(SpriteBatch spritebatch,int spriteLocationX, int spriteLocationY)
        {
            _spriteBounds = new Rectangle((int)_origin.X, (int)_origin.Y, _spriteSize, _spriteSize);

            

            spritebatch.Draw(_texture, _spriteBounds, new Rectangle(0 + _spriteSize * spriteLocationX, 0 + _spriteSize * spriteLocationY, _spriteSize, _spriteSize), Color.White);

           
        }



    }
}
