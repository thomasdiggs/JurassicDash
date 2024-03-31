global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using Microsoft.Xna.Framework.Input;
global using Microsoft.Xna.Framework.Audio;
global using Microsoft.Xna.Framework.Media;
global using Microsoft.Xna.Framework.Content;
global using System;
global using System.Collections.Generic;

namespace JurassicDash
{
    public class Main : Game
    {
        private EntityManager _entityManager;

        public const int SCREEN_WIDTH = 600;
        public const int SCREEN_HEIGHT = 150;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private TRex _trex;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            _graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            _graphics.ApplyChanges();
            AssetManager._content = Content;
            _entityManager = new EntityManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            AssetManager.LoadContent();

            _trex = new TRex(AssetManager.SpriteSheetTRex, new Vector2(0, SCREEN_HEIGHT - 15));
            _entityManager.AddEntity(_trex);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            _spriteBatch.Begin();

            _trex.Draw(_spriteBatch, gameTime);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
