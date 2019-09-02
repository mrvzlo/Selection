using System;
using System.Drawing;
using System.Linq;
using Selection.Entities;

namespace Selection.Drawing
{
    public class Drawer
    {
        const int SpotPadding = 25, SpotW = 60, SpotH = 40, CreaturePadding = 10, EyeSize = 3;

        public Bitmap DrawSpots(Field field, int spotRows)
        {
            var cols = field.Spots.Count / spotRows;
            if (cols * spotRows < field.Spots.Count) cols++;
            var w = cols * (SpotPadding + SpotW) + SpotPadding;
            var h = spotRows * (SpotPadding + SpotH) + SpotPadding;
            var bitmap = new Bitmap(w, h);
            var graphics = Graphics.FromImage(bitmap);
            for (var i = 0; i < spotRows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    var spotId = cols * i + j;
                    if (spotId >= field.Spots.Count) break;
                    var x = SpotPadding + j * (SpotW + SpotPadding);
                    var y = SpotPadding + i * (SpotH + SpotPadding);
                    var rect = new Rectangle(x, y, SpotW, SpotH);
                    DrawSpot(graphics, field, spotId, rect);
                }
            }

            return bitmap;
        }

        private void DrawSpot(Graphics graphics, Field field, int id, Rectangle rect)
        {
            graphics.FillRectangle(new SolidBrush(Color.LawnGreen), rect);
            graphics.DrawRectangle(new Pen(Color.Green), rect);
            var creatures = field.Spots[id].Creatures;
            if (!creatures.Any()) return;
            var w = (rect.Width - CreaturePadding) / 2 - CreaturePadding;
            var h = rect.Height - CreaturePadding * 2;
            for (var i = 0; i < creatures.Count; i++)
            {
                var x = (creatures.Count == 1 ? (rect.Width - w) / 2 : CreaturePadding + i * (w + CreaturePadding)) + rect.X;
                var y = CreaturePadding + rect.Y;
                var creature = new Rectangle(x, y, w, h);
                var color = GetAggressionColor(creatures[i].Aggression);
                graphics.FillRectangle(new SolidBrush(color), creature);
                graphics.FillRectangle(new SolidBrush(Color.Black),
                    creature.X + EyeSize, creature.Y + EyeSize, EyeSize, EyeSize);
                graphics.FillRectangle(new SolidBrush(Color.Black),
                    creature.X + creature.Width - EyeSize * 2, creature.Y + EyeSize, EyeSize, EyeSize);
            }
        }

        private Color GetAggressionColor(double aggression)
        {
            var red = Convert.ToByte(aggression * byte.MaxValue);
            var blue = byte.MaxValue - red;
            return Color.FromArgb(red, 0, blue);
        }
    }
}
