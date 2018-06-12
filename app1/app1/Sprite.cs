using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace app1.Desktop
{
    public class Sprite
    {
		Texture2D Texture { get; set; }
		Vector2 Origin { get; set; }
		Vector2 Position;
		Vector2 DrawPos;

        public Sprite(Texture2D texture, Vector2 position)
        {
			Texture = texture;
			Origin = new Vector2(texture.Width, texture.Height);
			Position = position;
			DrawPos = new Vector2(position.X, position.Y);
        }

        public Vector2 GetPosition()
		{
			return Position;
		}

		public void SetPosition(Vector2 p)
		{
			Position = p;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture, DrawPos - Origin, null, Color.White, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0);
		}

		public void Draw(SpriteBatch spriteBatch, double transparency)
		{
			spriteBatch.Draw(Texture, DrawPos - Origin, null, Color.White * (float)transparency, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0);
        }
    }
}
