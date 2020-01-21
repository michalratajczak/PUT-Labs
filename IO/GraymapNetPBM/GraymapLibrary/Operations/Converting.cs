using GraymapLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraymapLibrary.Operations
{
    public static class Converting
    {
        public static Graymap GetGraymap(System.Drawing.Bitmap bitmap)
        {
            Graymap graymap = new Graymap(bitmap.Width, bitmap.Height, 255);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = bitmap.GetPixel(x, y);

                    graymap.Data[y][x] = (int)(0.299f * color.R + 0.587f * color.G + 0.114f * color.B);
                }
            }

            return graymap;
        }

        public static Graymap GetGraymapParallel(System.Drawing.Bitmap bitmap)
        {
            Graymap graymap = new Graymap(bitmap.Width, bitmap.Height, 255);

            Parallel.For(0, graymap.Height, y =>
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = bitmap.GetPixel(x, y);

                    graymap.Data[y][x] = (int)(0.299f * color.R + 0.587f * color.G + 0.114f * color.B);
                }
            });

            return graymap;
        }

        public static Graymap GetGraymap(string file)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(file);

            Graymap graymap = new Graymap(bitmap.Width, bitmap.Height, 255);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = bitmap.GetPixel(x, y);

                    graymap.Data[y][x] = (int)(0.299f * color.R + 0.587f * color.G + 0.114f * color.B);
                }
            }

            return graymap;
        }

        public static Graymap GetGraymapParallel(string file)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(file);

            Graymap graymap = new Graymap(bitmap.Width, bitmap.Height, 255);

            Parallel.For(0, graymap.Height, y =>
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var color = bitmap.GetPixel(x, y);

                    graymap.Data[y][x] = (int)(0.299f * color.R + 0.587f * color.G + 0.114f * color.B);
                }
            });

            return graymap;
        }
    }
}
