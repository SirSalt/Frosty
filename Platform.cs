using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public class Platform
    {

        SpriteSheet _spriteSheet = new SpriteSheet();
        public Rectangle destinationrectangle;
        int spriteSize;

        public List<Rectangle> floorTiles = new List<Rectangle>();
        public Rectangle floorCollider;

        Vector2 Velocity;



        public void PlatformInitialize()
        {
            FloorCollider();

        }


        //make base Ground
        public void BaseGround(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {

            spriteSize = _spriteSheet._spriteSize;



            destinationrectangle = new Rectangle(0, GameSettings.WINDOWHEIGHT - _spriteSheet._spriteSize, _spriteSheet._spriteSize, _spriteSheet._spriteSize);


            

            for (int i = 0; i <= GameSettings.WINDOWWIDTH / spriteSize; i++)
            {
                
                floorTiles.Add(destinationrectangle);
                spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3], destinationrectangle);
                destinationrectangle.X += spriteSheet._spriteSize;

            }

            

        }




        void FloorCollider()
        {
            floorCollider = new Rectangle(0, GameSettings.WINDOWHEIGHT - spriteSize, GameSettings.WINDOWWIDTH, spriteSize);
        }




    }
}
