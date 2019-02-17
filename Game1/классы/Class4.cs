using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;



namespace Game1.классы
{
    class Class4
    {
        Random random = new Random();
        Vector2 position;
        Texture2D texture;
        public Class4()
        {
            position = new Vector2(0, random.Next(800));
            texture = null;
        }
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("mine");
        }
        public void Update(GameTime gameTime, ContentManager content)
        {
            position.Y = position.Y + 4;
            if (position.Y == 800)
            {
                position.Y = 0;
            }


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);



        }
    }
}
