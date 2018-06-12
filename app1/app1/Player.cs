using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace app1.Desktop {
	
	public class Player : Sprite
    {
		int health { get; set; }
		double XVel, YVel;

		public Player(Texture2D texture, Vector2 position) : base(texture, position)
		{
			health = 100;
		}

        public void moveLeft()
		{
			XVel -= .5;
		}

        public void moveRight()
		{
			XVel += .5;
		}

        public void moveUp()
		{
			YVel -= .5;
		}

        public void moveDown()
		{
			YVel += .5;
		}

        public void Update()
		{
			SetPosition(new Vector2((float)(GetPosition().X + XVel), (float)(GetPosition().Y + YVel)));
		}

    }

}
