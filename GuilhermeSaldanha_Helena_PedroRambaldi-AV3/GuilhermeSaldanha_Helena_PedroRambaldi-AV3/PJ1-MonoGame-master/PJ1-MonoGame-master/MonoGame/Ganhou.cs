using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame
{
    public class Ganhou : GameObject
    {
        public Bloco bloco;
        public Paddle paddle;
        public bool ganhou;
        public int inimigosFaltando = 14;
    

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("ganhou");
           
            
        }

        public override void Update(GameTime gameTime)
        {
            if (ganhou == true)
            {

            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (ganhou)
            {
                Texture2D texture = animation.GetCurrentFrame();
                spriteBatch.Draw( texture, position, null, color,
                    0.0f, Vector2.Zero,1.5f, SpriteEffects.None, 0.0f);
                
            }

        }
    }

}
