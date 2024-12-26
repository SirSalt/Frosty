using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public class Avatar
    {

        SpriteSheet _spriteSheet;
        Point _startPosition;


        public void DrawPlayer(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();


            _startPosition = new Point(100,GameSettings.WINDOWHEIGHT-_spriteSheet._spriteSize);

            _spriteSheet.DrawSprite(spriteBatch, _spriteSheet.sprites[0], _startPosition);

            spriteBatch.End();
        }





    }
}
