using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace app1.Desktop
{
	public class Block : Sprite
    {
		double transparency;

		public Block(Texture2D texture, Vector2 position) : base(texture, position)
		{
			transparency = 1;
        }

		new public void Draw(SpriteBatch spriteBatch)
		{
            base.Draw(spriteBatch, transparency);
		}
    }
}
