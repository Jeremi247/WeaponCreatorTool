using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class GuiController
    {
        public static List<Slider> Sliders = new List<Slider>();

        public static void Init()
        {
            Sliders.Add(new Slider(new Rectangle(new Point(10, 10), new Point(200, 20)), 0, 40, Color.Gray, Color.DimGray, "Bullet size"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 40), new Point(200, 20)), 0, 2000, Color.Gray, Color.DimGray, "Bullets speed"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 70), new Point(200, 20)), 0, 100, Color.Gray, Color.DimGray, "Bullets spread"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 100), new Point(200, 20)), 0, 2, Color.Gray, Color.DimGray, "Fading time"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 130), new Point(200, 20)), 0, 30, Color.Gray, Color.DimGray, "Bullets amount"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 160), new Point(200, 20)), 0, 2000, Color.Gray, Color.DimGray, "Time between shots(in ms)"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 190), new Point(200, 20)), 0, 20000, Color.Gray, Color.DimGray, "Weapon time length(in ms)"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 220), new Point(200, 20)), 0, 10000, Color.Gray, Color.DimGray, "Weapon drop chance"));

            Sliders.Add(new Slider(new Rectangle(new Point(10, 280), new Point(200, 20)), 0, 255, Color.Gray, Color.Red, "RED"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 310), new Point(200, 20)), 0, 255, Color.Gray, Color.Green, "GREEN"));
            Sliders.Add(new Slider(new Rectangle(new Point(10, 340), new Point(200, 20)), 0, 255, Color.Gray, Color.Blue, "BLUE"));
            //Weapon(Vector2 _bulletSize, float _bulletSpeed, Color _bulletColor, float _bulletsSpread, int _bulletsInOneShot, float _fireRate, float _weaponTime, float weaponValue, String _weaponName)
        }
    }
}
