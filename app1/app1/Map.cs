using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace app1.Desktop
{
    public class Map
    {
		List<Block> blocks;

        public Map(Texture2D tex, string fname)
        {
			blocks = new List<Block>();
			try {
				using (StreamReader streamReader = new StreamReader(fname))
				{
					int x = 1;
					int y = 1;

					do
					{
						string line = streamReader.ReadLine();

						foreach (var e in line)
						{
							int tile = (int)e;
							if (tile == 1)
								blocks.Add(new Block(tex, new Vector2(x * 64, y * 64)));
							x++;
						}

						y++;
					} while (!streamReader.EndOfStream);
					streamReader.Close();
				}
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
        }

		public void Draw(SpriteBatch spriteBatch)
		{
			foreach (Block b in blocks)
				b.Draw(spriteBatch);
		}
    }
}
