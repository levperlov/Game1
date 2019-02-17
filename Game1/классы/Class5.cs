using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace Game1.классы
{
    class Class5
    {
        // Поля
        private Texture2D texture;
        private Vector2 position;
        private bool isVisible;
        private int speed;

        // Конструктор
        public Class5(Vector2 position)
        {
            texture = null;
            this.position = position; 
            isVisible = true;
            speed = 7;
        }

        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("shipAnimation");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isVisible)
            {
                spriteBatch.Draw(texture, position, Color.White);
            }
        }

        public void Update(GameTime gameTime)
        {
            position.Y += speed;

            if (position.Y >= 700)
            {
                position.Y = -texture.Height - 10;
            }
        }
        
    }
}
