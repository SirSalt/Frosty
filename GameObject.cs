using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public abstract class GameObject
    {
        public abstract SpriteSheet spriteSheet { get; set; }
        public abstract int sprite {  get; set; }
        public abstract Vector2 topLeft { get; set; }
        public abstract Vector2 size { get; set; }
        public abstract Vector2 velocity { get; set; }
        public abstract bool isOutOfBounds { get; set; }
        public abstract bool isActive { get; set; }

        protected GameObject(SpriteSheet spriteSheet,int sprite, Vector2 topLeft, Vector2 size, Vector2 velocity, bool isOutOfBounds)
        {
            this.spriteSheet = spriteSheet;
            this.sprite = sprite;
            this.topLeft = topLeft;
            this.size = size;
            this.velocity = velocity;
            this.isOutOfBounds = isOutOfBounds;
        }

        public virtual void Update()
        {
            if(isActive)
            {
                MoveGameObject();
            }
        }

        public virtual void MoveGameObject()
        {
            if (isActive) 
            {
                spriteSheet._origin -= velocity;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if(isActive)
            {
                spriteSheet.DrawSprite(spriteBatch, spriteSheet.sprites[sprite], topLeft);
            }
        }

        public virtual bool IsCollidingWith(GameObject gameObject)
        {
            bool isColliding = false;



            return isColliding;
        }








    }
}
