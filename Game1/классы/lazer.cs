using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.классы
{
    class lazer
    {
        Random random = new Random();
        Vector2 position;
        Texture2D texture;
        public lazer(int x,int y)
        {
            position.X = x;
            position.Y = y;
            texture = null;
#pragma warning disable CS0219 // Переменная назначена, но ее значение не используется
            bool isvisible = true;
#pragma warning restore CS0219 // Переменная назначена, но ее значение не используется
        }
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("laser");
        }
        public void Update(GameTime gameTime)
        {


        }

            

    }
}

