using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class DrawController
    {   //All draw calls are performed in this controller
        public static void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            DrawActors(Actors.BloodParticles.ToList<Actor>(), spriteBatch);
            DrawActors(Actors.Bullets.ToList<Actor>(), spriteBatch);
            DrawActors(Actors.Drawable.ToList<Actor>(), spriteBatch);

            DrawGUI(spriteBatch);

            spriteBatch.End();
        }

        //Draws all actors placed in the Actor list
        private static void DrawActors(List<Actor> list, SpriteBatch spriteBatch)
        {
            foreach (Actor actor in list)
            {
                spriteBatch.Draw(actor.texture, actor.position, color: actor.color, scale: actor.scale);
            }
        }

        //Draws GUI on top of every other object
        private static void DrawGUI(SpriteBatch spriteBatch)
        {
            foreach(var slider in GuiController.Sliders)
            {
                slider.Draw(spriteBatch);
            }
        }
    }
}
