using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
	public class Ball : GameObject
    {
        public Paddle paddle;
        public Wall topWall;
        public Wall leftWall;
        public Wall rightWall;
        public Bloco bloco;
        public bool atirar;
        public bool apagar;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("fx-blow1");
            scale = 4.0f;

            position = new Vector2(25000.00f, 100.0f);
            

			collider.size = new Vector2( 55.0f, 50.0f );
        }

        public override void Update(GameTime gameTime)
        {
            float deltaT = ((float)gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f);
            position += velocity * deltaT;


            if (atirar == false && Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                atirar = true;
                velocity.Y = -1000.5f;


            }

            if (atirar == true)
            {
                atirar = false;
                position.Y -= 0.5f;
                position = new Vector2(paddle.position.X, paddle.position.Y);
            }
        }

              public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D texture = animation.GetCurrentFrame();
            if (apagar == false)


                spriteBatch.Draw(texture, position, null, color,
                    0.0f, Vector2.Zero, 5.0f, SpriteEffects.None, 0.0f);

            collider.Draw(spriteBatch, position);

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                apagar = false;
            }


        }

    }
    }

