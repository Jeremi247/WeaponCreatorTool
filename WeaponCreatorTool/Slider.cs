using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponCreatorTool
{
    class Slider
    {
        protected Boolean isHeld = false;
        private Rectangle border;
        private Rectangle littleBlock;
        private Rectangle backgroundLine;
        private Color littleBlockColor;
        private Color backgroundLineColor;
        private float minValue;
        private float maxValue;
        private String name;
        public float CurrentValue;

        public Slider(Rectangle _border, float _minValue, float _maxValue, Color _littleBlockColor, Color _backgroundLineColor, String _name)
        {
            name = _name;
            border = _border;
            minValue = _minValue;
            maxValue = _maxValue;
            littleBlockColor = _littleBlockColor;
            backgroundLineColor = _backgroundLineColor;

            CreateLittleBlock();
            CreateBackgroundLine();
        }

        public void Move()
        {
            Rectangle mouse = InputController.GetMouseRectangle();

            if (InputController.IsLeftMouseButtonHeld && (isHeld || mouse.Intersects(border)))
            {
                isHeld = true;
                littleBlock.Location = new Point(mouse.Location.X, littleBlock.Location.Y);
                if(littleBlock.Location.X + littleBlock.Size.X/2 < border.Location.X)
                {
                    littleBlock.Location = new Point(border.Location.X - littleBlock.Size.X / 2, littleBlock.Location.Y);
                }
                else if (littleBlock.Location.X + littleBlock.Size.X / 2 > border.Location.X + border.Size.X)
                {
                    littleBlock.Location = new Point(border.Location.X + border.Size.X - littleBlock.Size.X / 2, littleBlock.Location.Y);
                }

                UpdateValue();
            }
            else
            {
                isHeld = false;
            }
        }

        private void UpdateValue()
        {
            float deltaValue = maxValue - minValue;
            int littleBlockPos = littleBlock.Location.X + littleBlock.Size.X / 2;
            CurrentValue = ((float)(littleBlockPos - border.Location.X) / (float)border.Size.X) * deltaValue + minValue;
        }

        private void CreateLittleBlock()
        {
            Vector2 size = border.Size.ToVector2();
            size.X = size.X/25;

            Vector2 position = border.Location.ToVector2();
            position.X = position.X - size.X / 2;

            littleBlock = new Rectangle(position.ToPoint(), size.ToPoint());
        }

        private void CreateBackgroundLine()
        {
            Vector2 size = border.Size.ToVector2();
            size.Y = 2;

            Vector2 position = border.Location.ToVector2();
            position.Y = position.Y + border.Size.Y/2 - size.Y / 2;

            backgroundLine = new Rectangle(position.ToPoint(), size.ToPoint());
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(GameProperties.DefaultTexture, position: backgroundLine.Location.ToVector2(), color: backgroundLineColor, scale: new Vector2(backgroundLine.Width, backgroundLine.Height));
            spriteBatch.Draw(GameProperties.DefaultTexture, position: littleBlock.Location.ToVector2(), color: littleBlockColor, scale: new Vector2(littleBlock.Width, littleBlock.Height));

            spriteBatch.DrawString(GameProperties.DefaultFont, name + ": " + CurrentValue, GetNamePosition(), Color.White);
        }
        private Vector2 GetNamePosition()
        {
            Vector2 stringSize = GameProperties.DefaultFont.MeasureString(name);
            float X = border.Location.X + border.Size.X + 5;
            float Y = border.Location.Y + border.Size.Y/2 - stringSize.Y/2;
            return new Vector2(X, Y);
        }
    }
}
