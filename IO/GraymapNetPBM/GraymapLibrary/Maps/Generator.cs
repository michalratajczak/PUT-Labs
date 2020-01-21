using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GraymapLibrary.Maps
{
    public static class Generator
    {
        public static Graymap VerticalStripes(int width, int height, int[] values, int stripeWidth)
        {
            Graymap map = new Graymap(width, height, values.Max());
            int[] line = new int[width];
            int valueIndex = 0;

            for (int i = 0; i < width; i++)
            {
                line[i] = values[valueIndex];

                if (i % stripeWidth == 0 && i > 0)
                {
                    valueIndex++;
                }
                if (valueIndex == values.Length)
                {
                    valueIndex = 0;
                }
            }

            for (int y = 0; y < height; y++)
            {
                map.Data[y] = line;
            }

            return map;
        }

        public static Graymap HorizontalStripes(int width, int height, int[] values, int stripeHeight)
        {
            Graymap map = new Graymap(width, height, values.Max());
            int valueIndex = 0;

            for (int y = 0; y < height; y++)
            {
                Array.Fill(map.Data[y], values[valueIndex]);

                if ((y + 1) % stripeHeight == 0 && y > 0)
                {
                    valueIndex++;
                }
                if (valueIndex == values.Length)
                {
                    valueIndex = 0;
                }
            }

            return map;
        }

        public static Graymap GenerateChessboardProtected(int size, int maxValue)
        {
            Graymap map = new Graymap(size, size, maxValue);

            int squareSize = size / 8;

            int[] dark = new int[squareSize];
            int[] light = new int[squareSize];
            Array.Fill(dark, 0);
            Array.Fill(light, maxValue);
            int[] lightFirst = new int[squareSize * 8];
            int[] darkFirst = new int[squareSize * 8];

            for (int i = 0; i < 8; i++)
            {
                Array.Copy(i % 2 == 0 ? dark : light, 0, darkFirst, i * squareSize, squareSize);
                Array.Copy(i % 2 == 0 ? light : dark, 0, lightFirst, i * squareSize, squareSize);
            }

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        Array.Copy(lightFirst, map.Data[(i * squareSize) + j], lightFirst.Length);
                    }
                }
                else
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        Array.Copy(darkFirst, map.Data[(i * squareSize) + j], darkFirst.Length);
                    }
                }
            }

            return map;
        }
    }
}
