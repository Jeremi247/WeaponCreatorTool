using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class UpdateController
    {   //Update controller. All update calls are made here
        public static void Update(GameTime gameTime)
        {
            InputController.ManageInputs(gameTime);

            DeleteRedundant();

            MoveEntities(gameTime);

            WeaponController.Run(gameTime);

            UpdateGUI();
        }

        //Garbage collector. Clears all objects marked as removable
        private static void DeleteRedundant()
        {
            Actors.Bullets.RemoveAll(bullet => bullet.CanBeRemoved());
            Actors.BloodParticles.RemoveAll(particle => particle.CanBeRemoved());
        }

        //Moves all able to move entities
        private static void MoveEntities(GameTime gameTime)
        {
            Actors.Character.Move(gameTime);
            Actors.Character.KeepInViewport();

            foreach (var bullet in Actors.Bullets)
            {
                bullet.Move(gameTime);
                bullet.Fade(gameTime);
            }

            foreach (var particle in Actors.BloodParticles)
            {
                particle.Move(gameTime);
                particle.Fade(gameTime);
            }
        }

        private static void UpdateGUI()
        {
            foreach (var slider in GuiController.Sliders)
            {
                slider.Move();
            }
        }
    }
}
