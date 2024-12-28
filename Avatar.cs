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
        Platform _platform = new Platform();

        Point _startPosition;
        Vector2 position;

        int gravity = 9;


        public void Initialise(SpriteSheet spriteSheet)
        {

            _startPosition = new Point(100, GameSettings.WINDOWHEIGHT - spriteSheet._spriteSize * 5);
            position = new Vector2(_startPosition.X, _startPosition.Y);

        }
       

        public void DrawPlayer(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {                     
           

            spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[62], position);

        }

        public void Update(GameTime time)
        {
            Gravity();
            Collision(_platform);
        }

        public void Gravity()
        {
            position.Y += gravity;
            
        }

        public void Collision(Platform platform)
        {  
       
            /*if (destinationRectangle.Intersects(platform.floorCollider))
            {
                //gravity = 0;

                destinationRectangle.Y = 0;


            }*/


            if(position.Y >= GameSettings.WINDOWHEIGHT-(_spriteSheet._spriteSize)*2)
            {
                gravity = 0;
            }



        }




    }
}
