using System;
using System.Collections.Generic;
using System.Text;

namespace GraymapLibrary.Filters
{
    public static class Generator
    {
        public static Filter GetGaussianBlur(int size)
        {
            int[][] filter = new int[size][];

            for (int y = 0; y < size; y++)
            {
                filter[y] = new int[size];

                for (int x = 0; x < size; x++)
                {
                    filter[y][x] = ((y * (size - 1 - y)) + (x * (size - 1 - x)));
                }
            }

            return new Filter(filter);
        }

        public static Filter GetBoxBlur(int size)
        {
            int[][] filter = new int[size][];

            for (int y = 0; y < size; y++)
            {
                filter[y] = new int[size];

                Array.Fill(filter[y], 1);
            }

            return new Filter(filter);
        }
    }
}
