using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.классы;
using System.Collections.Generic;
using System;


namespace Game1
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();
        Class3 class3_1 = new Class3(0);
        Class3 class3_2 = new Class3(1);
        Class4 class4 = new Class4();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 480;
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            class1.LoadContent(Content);
            class2.LoadContent(Content);
            class3_1.LoadContent(Content);
            class4.LoadContent(Content);
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            class1.Update(gameTime);
            class3_1.Update(gameTime,true,Content);
            class3_2.Update(gameTime, false,Content);
            class4.Update(gameTime, Content);
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            {
                class2.Draw(spriteBatch);
                class3_1.Draw(spriteBatch);
                class1.Draw(spriteBatch);
                class4.Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
