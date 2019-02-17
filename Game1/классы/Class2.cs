using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game1.классы
{
    class Class2
    {
        private Texture2D texture;
        private Vector2 position;
        public Class2()
        {
            texture = null;
            position = new Vector2(0, 0);
        }
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("mainbackground");
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
