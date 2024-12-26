using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    internal class Platform
    {

<<<<<<< Updated upstream
=======
        SpriteSheet _spriteSheet = new SpriteSheet();
        public Rectangle destinationrectangle;
        int spriteSize;
>>>>>>> Stashed changes

        List<Rectangle> floorTiles = new List<Rectangle>();




<<<<<<< Updated upstream
=======
        //make base Ground
        public void BaseGround(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {

            spriteSize = _spriteSheet._spriteSize;


            destinationrectangle = new Rectangle(0,GameSettings.WINDOWHEIGHT-spriteSize,spriteSize,spriteSize);


            for (int i = 0; i <= GameSettings.WINDOWWIDTH / spriteSize; i++)
            {
               
                spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3], destinationrectangle);
                floorTiles.Add(destinationrectangle);
                destinationrectangle.X += spriteSheet._spriteSize;

            }



            //spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3]);


        }
>>>>>>> Stashed changes


    }
}
