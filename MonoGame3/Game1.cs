using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D puffGreyTexture;
        Texture2D puffBrownTexture;
        Texture2D puffWhiteTexture;
        Texture2D puffOrangeTexture;
        Texture2D bouncyHouseTexture;
        Rectangle puffGreyRect;
        Rectangle puffWhiteRect;
        Rectangle puffBrownRect;
        Rectangle puffOrangeRect;
        Vector2 tribbleGreySpeed;
        Vector2 tribbleOrangeSpeed;
        Vector2 tribbleBrownSpeed;
        Vector2 tribbleWhiteSpeed;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Animation";
            puffGreyRect = new Rectangle(300, 90, 100, 100);
            puffWhiteRect = new Rectangle(200, 50, 100, 100);
            puffOrangeRect = new Rectangle(100, 10, 100, 100);
            puffBrownRect = new Rectangle(400, 130, 100, 100); 
            tribbleGreySpeed = new Vector2(2, 2);
            tribbleOrangeSpeed = new Vector2(2, 0);
            tribbleBrownSpeed = new Vector2(0, 2);
            tribbleWhiteSpeed = new Vector2(2, 1);

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            bouncyHouseTexture = Content.Load<Texture2D>("BouncyHouse");
            puffGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            puffBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            puffOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            puffWhiteTexture = Content.Load<Texture2D>("tribbleCream");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //grey
            puffGreyRect.X += (int)tribbleGreySpeed.X;
            puffGreyRect.Y += (int)tribbleGreySpeed.Y;
            if (puffGreyRect.Right > _graphics.PreferredBackBufferWidth || puffGreyRect.Left < 0)
                tribbleGreySpeed.X *= -1;
            if (puffGreyRect.Bottom > _graphics.PreferredBackBufferHeight || puffGreyRect.Top < 0)
                tribbleGreySpeed.Y *= -1;
            //Orange
            puffOrangeRect.X += (int)tribbleOrangeSpeed.X;
            puffOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (puffOrangeRect.Right > _graphics.PreferredBackBufferWidth || puffOrangeRect.Left < 0)
                tribbleOrangeSpeed.X *= -1;
            if (puffOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || puffOrangeRect.Top < 0)
                tribbleOrangeSpeed.Y *= -1;
            //Brown
            puffBrownRect.X += (int)tribbleBrownSpeed.X;
            puffBrownRect.Y += (int)tribbleBrownSpeed.Y;
            if (puffBrownRect.Right > _graphics.PreferredBackBufferWidth || puffBrownRect.Left < 0)
                tribbleBrownSpeed.X *= -1;
            if (puffBrownRect.Bottom > _graphics.PreferredBackBufferHeight || puffBrownRect.Top < 0)
                tribbleBrownSpeed.Y *= -1;
            //White
            puffWhiteRect.X += (int)tribbleWhiteSpeed.X;
            puffWhiteRect.Y += (int)tribbleWhiteSpeed.Y;
            if (puffWhiteRect.Right > _graphics.PreferredBackBufferWidth || puffWhiteRect.Left < 0)
                tribbleWhiteSpeed.X *= -1;
            if (puffWhiteRect.Bottom > _graphics.PreferredBackBufferHeight || puffWhiteRect.Top < 0)
                tribbleWhiteSpeed.Y *= -1;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(bouncyHouseTexture, new Vector2(0, 0),Color.White);
            _spriteBatch.Draw(puffGreyTexture, puffGreyRect, Color.White);
            _spriteBatch.Draw(puffWhiteTexture, puffWhiteRect, Color.White);
            _spriteBatch.Draw(puffOrangeTexture, puffOrangeRect, Color.White);
            _spriteBatch.Draw(puffBrownTexture, puffBrownRect, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}