using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class WeaponController
    {
        //Enum contains all possible weapon types
        private static SpriteFont font = GameProperties.DefaultFont;
        public static Weapon CurrentWeapon = new Weapon(Vector2.Zero, 0, Color.White, 0, 0, 0, 0, 0, 0, "0");

        public static float WeaponTime = 0;

        //Runs all update functions of this controller. Called in UpdateController
        public static void Run(GameTime gameTime)
        {
            float size = GuiController.Sliders[0].CurrentValue;
            float speed = GuiController.Sliders[1].CurrentValue;
            float spread = GuiController.Sliders[2].CurrentValue;
            float fadingTime = GuiController.Sliders[3].CurrentValue;
            float bulletsAmount = GuiController.Sliders[4].CurrentValue;
            float fireRate = GuiController.Sliders[5].CurrentValue;
            float weaponTime = GuiController.Sliders[6].CurrentValue;
            float value = GuiController.Sliders[7].CurrentValue;

            Vector3 color;
            color.X = GuiController.Sliders[8].CurrentValue;
            color.Y = GuiController.Sliders[9].CurrentValue;
            color.Z = GuiController.Sliders[10].CurrentValue;

            CurrentWeapon = new Weapon(new Vector2(size,size), speed, new Color(color/255), spread, (int)bulletsAmount, fireRate, weaponTime, value, fadingTime, "test");
            Actors.Character.UpdateWeaponTimer(gameTime);
        }
    }
}
