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
    public class Perdeu : GameObject
    {
        public Bloco bloco;
        public Paddle paddle;
        public bool perdeu;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("perdeu");
        }

        public override void Update(GameTime gameTime)
        {
            if (perdeu ==  true)
            {

            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if(perdeu)
            {
                Texture2D texture = animation.GetCurrentFrame();
                spriteBatch.Draw(texture, position, null, color,
                    0.0f, Vector2.Zero, 3.0f, SpriteEffects.None, 0.0f);
            }
           
        }
    }

}

