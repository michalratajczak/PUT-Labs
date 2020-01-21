using GraymapLibrary.Filters;
using GraymapLibrary.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraymapLibrary.Operations
{
    public static class Filtering
    {
        public static Graymap ApplyFilter(Graymap graymap, Filter filter)
        {
            Graymap map = new Graymap(graymap.Width, graymap.Height, graymap.MaxValue);

            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Data[y][x] = CalculatePixel(x, y, graymap, filter);
                }
            }

            return map;
        }

        public static Graymap ApplyFilterParallel(Graymap graymap, Filter filter)
        {
            Graymap map = new Graymap(graymap.Width, graymap.Height, graymap.MaxValue);

            Parallel.For(0, map.Height, y =>
            {
                for (int x = 0; x < map.Width; x++)
                {
                    map.Data[y][x] = CalculatePixel(x, y, graymap, filter);
                }
            });

            return map;
        }

        private static int CalculatePixel(int x, int y, Graymap source, Filter filter)
        {
            int pixel = 0;
            int filterX = 0;
            int filterY = 0;
            int denominator = 0;

            for (int j = y - filter.RadiusY; j < y + filter.RadiusY; j++)
            {
                for (int i = x - filter.RadiusX; i < x + filter.RadiusX; i++)
                {
                    if (i >= 0 && i < source.Width && j >= 0 && j < source.Height)
                    {
                        pixel += source.Data[j][i] * filter.Mask[filterY][filterX];
                        denominator += filter.Mask[filterY][filterX];
                    }

                    filterX++;
                }

                filterY++;
                filterX = 0;
            }

            return denominator == 0 ? pixel : (pixel / denominator);
        }
    }
}
