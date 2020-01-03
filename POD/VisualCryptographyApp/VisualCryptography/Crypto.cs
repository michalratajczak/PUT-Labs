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

        public static async Task<List<Bitmap>> DivideImageAsync(Bitmap image, int numberOfParts = 2)
        {
            List<Bitmap> parts = await CreateEmptyBitmaps(image.Width, image.Height, numberOfParts, 2);
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
                            parts[0].SetPixel((x * 2) + 1, y * 2, Color.White);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, Color.White);

                            parts[1].SetPixel(x * 2, y * 2, Color.White);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.White);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);
                        }
                        else
                        {
                            parts[1].SetPixel(x * 2, y * 2, Color.Black);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.White);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.White);

                            parts[0].SetPixel(x * 2, y * 2, Color.White);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, Color.White);
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
                            parts[0].SetPixel((x * 2) + 1, y * 2, Color.White);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, Color.White);

                            parts[1].SetPixel(x * 2, y * 2, Color.Black);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.White);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.White);
                        }
                        else
                        {
                            parts[0].SetPixel(x * 2, y * 2, Color.White);
                            parts[0].SetPixel(x * 2, (y * 2) + 1, Color.White);
                            parts[0].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[0].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);

                            parts[1].SetPixel(x * 2, y * 2, Color.White);
                            parts[1].SetPixel(x * 2, (y * 2) + 1, Color.White);
                            parts[1].SetPixel((x * 2) + 1, y * 2, Color.Black);
                            parts[1].SetPixel((x * 2) + 1, (y * 2) + 1, Color.Black);
                        }
                    }
                }
            }

            return parts;
        }

        public static async Task<Bitmap> MergePartsAsync(List<Bitmap> parts, int width, int height)
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

                    if(pixels.All(p => p.ToArgb() == Color.White.ToArgb()))
                    {
                        merged.SetPixel(x, y, Color.White);
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
