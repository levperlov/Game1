using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game1.классы
{
    class Class3
    {
        private Texture2D texture1;
        private Texture2D texture2;
        private Vector2 position1;
        private Vector2 position2;
        private int speed1;
        private int speed2;
        public Class3(int _speed)
        {
            if (_speed == 1)
            {
                speed1 = 4;
            }
            if (_speed == 0)
            {
                speed2 = 7;
            }
            texture1 = null;
            
            position1 = new Vector2(0, 0);
            position2 = new Vector2(600, 600);
        }
        public void LoadContent(ContentManager content)
        {
            texture1 = content.Load<Texture2D>("bgLayer1");
            texture2 = content.Load<Texture2D>("bgLayer2");
        }
        public void Update(GameTime gameTime,bool _1 , ContentManager content)
        {
            if (_1==true)
            {
                 position1.X = position1.X - speed1;

                if (position1.X >= 600+600 )
                {
                    position1.X = -texture1.Width;
                }
            }
            else
            {
                position2.X = position2.X + speed2;

                if (position2.X >= 0+600)
                {
                    texture2 = content.Load<Texture2D>("bgLayer2");
                    position2.X = -texture2.Width;
                }

            }
           
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture1, position1, Color.White);
            spriteBatch.Draw(texture2, position2, Color.White);
        }
    }
}
