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
        public FloorTile floorTile;
        int spriteSize;

        public List<FloorTile> floorTiles = new List<FloorTile>();
        public Rectangle floorCollider;

        Vector2 Velocity = new Vector2(10, 0);


        public void PlatformInitialize()
        {
            FloorCollider();
            floorTile.posistion = new Vector2(GameSettings.WINDOWHEIGHT - spriteSize, 0);
        }


        //make base Ground
        public void BaseGround(SpriteBatch spriteBatch, SpriteSheet spriteSheet)
        {

            spriteSize = _spriteSheet._spriteSize;



            floorTile.posistion = new Vector2(0, GameSettings.WINDOWHEIGHT - _spriteSheet._spriteSize);




            for (int i = 0; i <= GameSettings.WINDOWWIDTH / spriteSize; i++)
            {

                floorTiles.Add(floorTile);

            }

            /*foreach(FloorTile FT in floorTiles)
            {
                spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[3], FT.posistion);
                FT.posistion -= Velocity;
            }*/





        }




        void FloorCollider()
        {
            floorCollider = new Rectangle(0, GameSettings.WINDOWHEIGHT - spriteSize, GameSettings.WINDOWWIDTH, spriteSize);
        }




    }
}
