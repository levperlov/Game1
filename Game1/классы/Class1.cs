using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace Game1.классы
{
    class Class1
    {

        // Поля
        private Texture2D texture;
        private Vector2 position;

        // Конструктор
        public Class1()
        {
            texture = null;
            position = new Vector2(300, 400);
        }

        // Загрузка контента
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("player");
        }
        // Обновление игры (60 раз в 1 сек)
        public void Update(GameTime gameTime)
        {
            // Получение статуса клавиатуры
            KeyboardState keyboard = Keyboard.GetState();

            // Управление персонажем
            if (keyboard.IsKeyDown(Keys.W))
            {
                position.Y = position.Y - 5;
            }
            if (keyboard.IsKeyDown(Keys.S))
            {
                position.Y = position.Y + 5;
            }
            if (keyboard.IsKeyDown(Keys.D))
            {
                position.X = position.X + 5;
            }
            if (keyboard.IsKeyDown(Keys.A))
            {
                position.X = position.X - 5;
            }
            if (position.Y <= 0)
            {
                position.Y = 0;
            }
            if (position.X <= 0)
            {
                position.X = 0;
            }
            if (position.X >= 800 - texture.Width)
            {
                position.X = 800 - texture.Width;
            }
            if (position.Y >= 480 - texture.Height)
            {
                position.Y = 480 - texture.Height;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }

}

