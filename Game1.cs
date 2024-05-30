﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Rotation_Tutorial
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D shipTexture;
        float shipAngle;
        Vector2 shipPosition;
        Rectangle shipRect;
        Vector2 shipDirection; //new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));

        MouseState mouseState;

        Texture2D rectTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            shipAngle = 0;
            shipPosition = new Vector2(100, 100);
            shipRect = new Rectangle(shipPosition.ToPoint(), new Point(50, 50));
            shipDirection = Vector2.Zero;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectTexture = Content.Load<Texture2D>("Images/rectangle");
            shipTexture = Content.Load<Texture2D>("Images/enterprise");
        }

        protected override void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            ship

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(shipTexture, shipRect, null, Color.White, shipAngle, new Vector2(shipTexture.Width / 2, shipTexture.Height / 2), SpriteEffects.None, 1f);

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}