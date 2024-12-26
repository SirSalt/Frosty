using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    internal class Platform
    {

        SpriteSheet _spriteSheet = new SpriteSheet();
        public Rectangle destinationrectangle;

        int spriteSize;



        //make base Ground
        public void BaseGround(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {

            spriteSize = _spriteSheet._spriteSize;


            destinationrectangle = new Rectangle(100,100,spriteSize,spriteSize);


            for (int i = 0; i < GameSettings.WINDOWWIDTH / spriteSize; i++)
            {
                destinationrectangle.X += spriteSheet._spriteSize;
                spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3], destinationrectangle);

            }



            //spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3]);


        }


    }
}
