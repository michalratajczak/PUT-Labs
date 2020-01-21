using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraymapLibrary.Filters
{
  public class Filter
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int[][] Mask { get; private set; }
        public int CenterX { get; private set; }
        public int CenterY { get; private set; }
        public int RadiusX { get; private set; }
        public int RadiusY { get; private set; }


        public Filter(int[][] filter)
        {
            Height = filter.Length;
            Width = filter.All(f => f.Length == filter[0].Length) ?
                filter[0].Length :
                throw new Exception("Arrays have different length!");

            if (Height % 2 == 0 || Width % 2 == 0)
            {
                throw new Exception("Mask sizes must be odd!");
            }

            Mask = filter;
            CenterY = (Height / 2) + 1;
            CenterX = (Width / 2) + 1;
            RadiusX = Width / 2;
            RadiusY = Height / 2;
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var line in Mask)
            {
                foreach (var value in line)
                {
                    builder.Append($"{ value} ");
                }
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }

    }
}
