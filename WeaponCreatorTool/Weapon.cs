using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class Weapon : Modification
    {
        public Vector2 BulletSize;
        public float BulletSpeed;
        public Color BulletColor;
        public float BulletsSpread;
        public float FadingTime;
        public int BulletsInOneShot;
        public float FireRate;
        public float WeaponTime;
        public String WeaponName;

        public Weapon(Vector2 _bulletSize, float _bulletSpeed, Color _bulletColor, float _bulletsSpread, int _bulletsInOneShot, float _fireRate, float _weaponTime, float weaponValue, float fadingTime, String _weaponName) : base(weaponValue, _bulletColor)
        {
            FadingTime = fadingTime;
            BulletSize = _bulletSize;
            BulletSpeed = _bulletSpeed;
            BulletColor = _bulletColor;
            BulletsSpread = _bulletsSpread;
            BulletsInOneShot = _bulletsInOneShot;
            FireRate = _fireRate;
            WeaponTime = _weaponTime;
            WeaponName = _weaponName;
        }
    }
}
