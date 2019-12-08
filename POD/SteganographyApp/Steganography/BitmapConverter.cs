using Steganography.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    public static class BitmapConverter
    {
        public static Color[] CleanColorArrayFromLSB(Color[] colors)
        {
            Color[] clrs = new Color[colors.Length];
            byte R, G, B;

            for(int i = 0; i < colors.Length; i++)
            {
                R = (byte)(colors[i].R - colors[i].R % 2);
                G = (byte)(colors[i].G - colors[i].G % 2);
                B = (byte)(colors[i].B - colors[i].B % 2);

                clrs[i] = Color.FromArgb(R, G, B);
            }

            return clrs;
        }

        public static Color[] BitmapToColorArray(Bitmap image, Direction direction)
        {
            Color[] colors = new Color[image.Width * image.Height];

            if (direction == Direction.Vertical)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        colors[y * image.Width + x] = image.GetPixel(x, y);
                    }
                }
            }
            else
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        colors[x * image.Height + y] = image.GetPixel(x, y);
                    }
                }
            }

            return colors;
        }

        public static Bitmap ColorArrayToBitmap(Color[] colors, int width, int height, Direction direction)
        {
            Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            if (direction == Direction.Vertical)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        bitmap.SetPixel(x, y, colors[y * bitmap.Width + x]);
                    }
                }
            }
            else
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        bitmap.SetPixel(x, y, colors[x * bitmap.Height + y]);
                    }
                }
            }

            return bitmap;
        }

        public static int CalculateOffset(int offsetX, int offsetY, int width, int height, Direction direction)
        {
            if (direction == Direction.Vertical)
            {
                return offsetY * width + offsetX;
            }
            else
            {
                return offsetX * height + offsetY;
            }
        }
    }
}
