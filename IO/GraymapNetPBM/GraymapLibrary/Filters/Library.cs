using System;
using System.Collections.Generic;
using System.Text;

namespace GraymapLibrary.Filters
{
    public static class Library
    {
        public static Filter BoxBlur => new Filter(
            new int[][]
            {
                new int[]{1, 1, 1},
                new int[]{1, 1, 1},
                new int[]{1, 1, 1}
            });

        public static Filter GaussianBlur4 => new Filter(
            new int[][]
            {
                new int[]{1, 2, 1},
                new int[]{2, 4, 2},
                new int[]{1, 2, 1}
            });

        public static Filter GaussianBlur16 => new Filter(
            new int[][]
            {
                new int[]{0, 1,  2, 1, 0},
                new int[]{1, 4,  8, 4, 1},
                new int[]{2, 8, 16, 8, 2},
                new int[]{1, 4,  8, 4, 1},
                new int[]{0, 1,  2, 1, 0}
            });

        public static Filter GaussianBlur36 => new Filter(
            new int[][]
            {
                new int[]{1,  4,  6,  4, 1},
                new int[]{4, 16, 24, 16, 4},
                new int[]{6, 24, 36, 24, 6},
                new int[]{4, 16, 24, 16, 4},
                new int[]{1,  4,  6,  4, 1}
            });

        public static Filter GaussianBlur64 => new Filter(
            new int[][]
            {
                new int[]{1,  4,  8,  4, 1},
                new int[]{4, 16, 32, 16, 4},
                new int[]{8, 32, 64, 32, 8},
                new int[]{4, 16, 32, 16, 4},
                new int[]{1,  4,  8,  4, 1}
            });

        public static Filter Sharpen5 => new Filter(
            new int[][]
            {
                new int[]{0, -1, 0},
                new int[]{-1, 5, -1},
                new int[]{0, -1, 0}
            });

        public static Filter Sharpen9 => new Filter(
            new int[][]
            {
                new int[]{0, -1, 0},
                new int[]{-1, 9, -1},
                new int[]{0, -1, 0}
            });

        public static Filter HorizontalEdgesDetection => new Filter(
            new int[][]
            {
                new int[]{0, 0, 0},
                new int[]{-1, 1, 0},
                new int[]{0, 0, 0}
            });

        public static Filter VerticalEdgesDetection => new Filter(
            new int[][]
            {
                new int[]{0, -1, 0},
                new int[]{0, 1, 0},
                new int[]{0, 0, 0}
            });

        public static Filter EdgesDetection8 => new Filter(
            new int[][]
            {
                new int[]{-1, -1, -1},
                new int[]{-1, 8, -1},
                new int[]{-1, -1, -1}
            });

        public static Filter EdgesDetection4 => new Filter(
            new int[][]
            {
                new int[]{0, -1, 0},
                new int[]{-1, 4, -1},
                new int[]{0, -1, 0}
            });
    }
}
