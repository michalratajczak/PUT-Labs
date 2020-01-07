using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCryptography
{
    public static class Crypto
    {
        private static async Task<List<Bitmap>> CreateEmptyBitmaps(int width, int height, int listLength, int scaleMultiplier = 2)
        {
            List<Bitmap> parts = new List<Bitmap>(listLength);
            Random random = new Random();

            for (int i = 0; i < listLength; i++)
            {
                parts.Add(new Bitmap(width * scaleMultiplier, height * scaleMultiplier));
            }

            return parts;
        }

        public static async Task<List<Bitmap>> DivideIntoTwoPartsAsync(Bitmap image, Color lightPixel)
        {
            List<Bitmap> parts = await CreateEmptyBitmaps(image.Width, image.Height, 2, 2);
            Random random = new Random();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var color = image.GetPixel(x, y);

                    if (color.ToArgb() == Color.Black.ToArgb())
                    {
                        if (random.Next(0, 100) < 50)
                        {
                            parts[0].SetPixel(x * 2, y * 2, Color.Black);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[0].SetPixel((x * 2) + 1, y * 2, lightPixel);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, lightPixel);

                            parts[1].SetPixel(x * 2, y * 2, lightPixel);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, lightPixel);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);
                        }
                        else
                        {
                            parts[1].SetPixel(x * 2, y * 2, Color.Black);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, y * 2, lightPixel);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, lightPixel);

                            parts[0].SetPixel(x * 2, y * 2, lightPixel);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, lightPixel);
                            parts[0].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);
                        }
                    }
                    else
                    {
                        if (random.Next(0, 100) < 50)
                        {
                            parts[0].SetPixel(x * 2, y * 2, Color.Black);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[0].SetPixel((x * 2) + 1, y * 2, lightPixel);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, lightPixel);

                            parts[1].SetPixel(x * 2, y * 2, Color.Black);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, y * 2, lightPixel);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, lightPixel);
                        }
                        else
                        {
                            parts[0].SetPixel(x * 2, y * 2, lightPixel);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, lightPixel);
                            parts[0].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);

                            parts[1].SetPixel(x * 2, y * 2, lightPixel);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, lightPixel);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);
                        }
                    }
                }
            }

            return parts;
        }

        public static async Task<List<Bitmap>> DivideImageAsync(Bitmap image, Color lightPixel, int numberOfParts = 2)
        {
            List<Bitmap> parts = await CreateEmptyBitmaps(image.Width, image.Height, numberOfParts, numberOfParts);
            Random random = new Random();
            int width = image.Width;
            
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var color = image.GetPixel(x, y);                    
                    bool isLightPixel = !(color.ToArgb() == Color.Black.ToArgb());

                    SetPixelsAsChessboard(ref parts, lightPixel, Color.Black, x, y, numberOfParts, isLightPixel, random);
                    switch(random.Next(1, 3))
                    {
                        case 1:
                            SetPixelsHorizontaly(ref parts, lightPixel, Color.Black, x, y, numberOfParts, isLightPixel, random);
                            break;
                        case 2:
                            SetPixelsVerticaly(ref parts, lightPixel, Color.Black, x, y, numberOfParts, isLightPixel, random);
                            break;
                        case 3:
                            SetPixelsAsChessboard(ref parts, lightPixel, Color.Black, x, y, numberOfParts, isLightPixel, random);
                            break;
                    }
                }
            }

            return parts;
        }

        private static void SetPixelsVerticaly(ref List<Bitmap> bitmaps, Color lightColor, Color darkColor, int x, int y, int scaleMultiplier, bool isLightPixel, Random random)
        {
            var rng = random.Next(0, 100);

            for (int index = 0; index < bitmaps.Count; index++)
            {
                for (int i = 0; i < scaleMultiplier; i++)
                {
                    for (int j = 0; j < scaleMultiplier; j++)
                    {
                        bitmaps[index].SetPixel(
                            (x * scaleMultiplier) + j,
                            (y * scaleMultiplier) + i,
                            rng < 50 ?
                            ((isLightPixel ? j : j + (index % 2)) % 2 == 0 ? lightColor : darkColor) :
                            ((isLightPixel ? j : j + (index % 2)) % 2 == 1 ? lightColor : darkColor));
                    }
                }
            }            
        }

        private static void SetPixelsAsChessboard(ref List<Bitmap> bitmaps, Color lightColor, Color darkColor, int x, int y, int scaleMultiplier, bool isLightPixel, Random random)
        {
            var rng = random.Next(0, 100);

            for (int index = 0; index < bitmaps.Count; index++)
            {
                for (int i = 0; i < scaleMultiplier; i++)
                {
                    for (int j = 0; j < scaleMultiplier; j++)
                    {
                        bitmaps[index].SetPixel(
                            (x * scaleMultiplier) + i,
                            (y * scaleMultiplier) + j,
                            rng < 50 ?
                            ((isLightPixel ? (j + i) : (j + i) + (index % 2)) % 2 == 0 ? lightColor : darkColor) :
                            ((isLightPixel ? (j + i) : (j + i) + (index % 2)) % 2 == 1 ? lightColor : darkColor));
                    }
                }
            }
        }

        private static void SetPixelsHorizontaly(ref List<Bitmap> bitmaps, Color lightColor, Color darkColor, int x, int y, int scaleMultiplier, bool isLightPixel, Random random)
        {
            var rng = random.Next(0, 100);

            for (int index = 0; index < bitmaps.Count; index++)
            {
                for (int i = 0; i < scaleMultiplier; i++)
                {
                    for (int j = 0; j < scaleMultiplier; j++)
                    {
                        bitmaps[index].SetPixel(
                            (x * scaleMultiplier) + i,
                            (y * scaleMultiplier) + j,
                            rng < 50 ?
                            ((isLightPixel ? j : j + (index % 2)) % 2 == 0 ? lightColor : darkColor) :
                            ((isLightPixel ? j : j + (index % 2)) % 2 == 1 ? lightColor : darkColor));
                    }
                }
            }
        }


        public static async Task<Bitmap> MergePartsAsync(List<Bitmap> parts, int width, int height, Color lightPixel)
        {
            Bitmap merged = new Bitmap(width, height);

            for(int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<Color> pixels = new List<Color>(parts.Count);
                    
                    foreach(var part in parts)
                    {
                        pixels.Add(part.GetPixel(x, y));
                    }

                    if(pixels.All(p => p.ToArgb() == lightPixel.ToArgb()))
                    {
                        merged.SetPixel(x, y, lightPixel);
                    }
                    else
                    {
                        merged.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return merged;
        }
    }
}
