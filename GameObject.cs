using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public abstract class GameObject
    {
        public abstract SpriteSheet spriteSheet { get; set; }
        public abstract Point topLeft { get; set; }
        public abstract int size { get; set; }
        public abstract bool isActive { get; set; }
        public abstract int velocity { get; set; }
        public abstract bool isOutOfBounds { get; set; }

        public virtual void Update()
        {

        }

        public virtual void MoveGameObject()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        public virtual bool IsCollidingWith(GameObject gameObject)
        {
            bool isColliding = false;



            return isColliding;
        }








    }
}
