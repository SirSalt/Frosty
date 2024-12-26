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

        SpriteSheet _spriteSheet = new SpriteSheet();
        Point _startPosition;
        Rectangle destinationRectangle;

        float gravity = -9.81f;



        public void Update(GameTime time)
        {
            Gravity();
        }





        public void DrawPlayer(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {

            _startPosition = new Point(100, GameSettings.WINDOWHEIGHT - spriteSheet._spriteSize * 2);
            destinationRectangle = new Rectangle(_startPosition.X, _startPosition.Y, spriteSheet._spriteSize, spriteSheet._spriteSize);

            spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[62], destinationRectangle);

        }


        public void Gravity()
        {
            destinationRectangle.Y += (int)gravity;
        }




    }
}
