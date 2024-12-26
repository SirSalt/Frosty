using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frosty
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Important Game Classes
        SpriteSheet _spriteSheet = new SpriteSheet();
        Platform _platform = new Platform();


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = GameSettings.WINDOWWIDTH;
            _graphics.PreferredBackBufferHeight = GameSettings.WINDOWHEIGHT;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _spriteSheet.SpriteList();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            _spriteSheet._texture = Content.Load<Texture2D>("Graphics/sheet");
           

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            

            _spriteSheet.Update(gameTime);

            //reactivate when i have screens!!!!!!!!!
            //GameSettings.ActiveScreen.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            //_spriteSheet.DrawSprite(_spriteBatch, _spriteSheet.sprites[62]);

            //draw ground plane
            _platform.BaseGround(_spriteBatch, _spriteSheet);

            //reactivate when i have screens!!!!!!!!!
            //GameSettings.ActiveScreen.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
