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
        Rectangle destinationRectangle = new Rectangle();

        int gravity = 9;


        public void Initialise(SpriteSheet spriteSheet)
        {

            _startPosition = new Point(100, GameSettings.WINDOWHEIGHT - spriteSheet._spriteSize * 5);
            destinationRectangle = new Rectangle(_startPosition.X, _startPosition.Y, spriteSheet._spriteSize, spriteSheet._spriteSize);

        }
       

        public void DrawPlayer(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {                     
           

            spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[62], destinationRectangle);

        }

        public void Update(GameTime time)
        {
            Gravity();
            Collision(_platform);
        }

        public void Gravity()
        {
            destinationRectangle.Y += gravity;
            
        }

        public void Collision(Platform platform)
        {

            int index = destinationRectangle.X/GameSettings.WINDOWWIDTH;

            for(int i = 0; i<platform.floorTiles.Count;)


            if (destinationRectangle.Intersects(platform.floorTiles[index]))
            {
                gravity = 0;
            }

        }




    }
}
