using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GraymapLibrary.Maps
{
    public class Graymap
    {
        private const int _maxVal = 65536;
        private const string _magicNumber = "P2";

        public string MagicNumber => _magicNumber;
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int MaxValue { get; protected set; }
        public List<string> Comments { get; protected set; }
        public int[][] Data { get; private set; }


        public Graymap(int width, int height)
        {
            Width = width;
            Height = height;
            MaxValue = _maxVal;
            Comments = new List<string>();
            InitializeDataArray();
        }

        public Graymap(int width, int height, int maxValue)
        {
            Width = width;
            Height = height;
            MaxValue = maxValue;
            Comments = new List<string>();
            InitializeDataArray();
        }

        public Graymap(string fileName)
        {
            LoadFromFile(fileName);
        }

        private void InitializeDataArray()
        {
            Data = new int[Height][];

            for (int i = 0; i < Height; i++)
            {
                Data[i] = new int[Width];
            }
        }

        public void SetPixel(int x, int y, int value)
        {
            if (value >= 0 && value <= MaxValue)
            {
                Data[y][x] = value;
            }
            else
            {
                throw new Exception("Value is out of range!");
            }
        }

        public void SetLine(int y, int[] values)
        {
            if (values.Length != Width)
            {
                throw new Exception("Length of values array is not equal to graymap width!");
            }

            if (values.All(v => v > 0 && v <= MaxValue))
            {
                Array.Copy(values, Data[y], values.Length);
            }
            else
            {
                throw new Exception("Value is out of range!");
            }
        }

        public void SetRectangle(int fromX, int fromY, int[][] values)
        {
            if (fromY + values.Length <= Height)
            {
                if (values.All(val => fromX + val.Length <= Width && val.All(v => v >= 0 && v <= MaxValue)))
                {
                    for (int y = fromY; y < values.Length; y++)
                    {
                        Array.Copy(values[y], 0, Data[y], fromX, values[y].Length);
                    }
                }
            }
        }

        public void SetAll(int[][] values)
        {
            if (values.Length != Height)
            {
                throw new Exception("Height of values matrix is not equal to graymap height!");
            }

            if (!values.All(v => v.Length == Width))
            {
                throw new Exception("Width of values matrix is not equal to graymap width!");
            }

            Data = values;
        }

        public void FillRectangle(int fromX, int fromY, int toX, int toY, int value)
        {
            if (value < 0 && value > MaxValue)
            {
                throw new Exception("Value is out of range!");
            }

            if (fromY + toY <= Height)
            {
                if (fromX + toX <= Width)
                {
                    int[] temp = new int[toX - fromX];
                    Array.Fill(temp, value);

                    for (int y = fromY; y < toY; y++)
                    {
                        Array.Copy(temp, 0, Data, fromX, Data.Length);
                    }
                }
                else throw new Exception("Rectangle is out of data area!");
            }
            else throw new Exception("Rectangle is out of data area!");
        }

        public void FillAll(int value)
        {
            if (value >= 0 && value <= MaxValue)
            {
                for (int y = 0; y < Height; y++)
                {
                    Array.Fill(Data[y], value);
                }
            }
            else throw new Exception("Value is out of range!");
        }

        public string[] ToStringArray()
        {
            List<string> list = new List<string>();

            list.Add(MagicNumber);

            if (Comments != null)
            {
                foreach (var comment in Comments)
                {
                    list.Add($"# { comment }");
                }
            }

            list.Add($"{ Width } { Height }");
            list.Add($"{ MaxValue }");

            if (Data != null)
            {
                for (int y = 0; y < Height; y++)
                {
                    StringBuilder builder = new StringBuilder();

                    for (int x = 0; x < Width; x++)
                    {
                        builder.Append($"{ Data[y][x] } ");
                    }

                    list.Add(builder.ToString());
                }
            }

            return list.ToArray();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    builder.Append($"{ Data[y][x] } ");
                }
            }

            return builder.ToString();
        }

        public void SaveToFile(string fileName)
        {
            File.WriteAllLines(fileName, ToStringArray());
        }

        public void LoadFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            LoadPlainText(lines);
        }

        public void LoadPlainText(string[] lines)
        {
            Comments = new List<string>();

            Regex size = new Regex(@"^\d+ \d+$");
            Regex maxValue = new Regex(@"^\d+$");
            Regex comment = new Regex(@"^#");
            StringBuilder builder = new StringBuilder();

            if (lines[0] != MagicNumber)
            {
                throw new Exception("File is invalid!");
            }

            for (int i = 1; i < lines.Length; i++)
            {
                if (comment.IsMatch(lines[i]))
                {
                    Comments.Add(lines[i]);
                }
                else if (size.IsMatch(lines[i]))
                {
                    var s = lines[i].Split();
                    Width = Int32.Parse(s[0]);
                    Height = Int32.Parse(s[1]);
                }
                else if (maxValue.IsMatch(lines[i]))
                {
                    MaxValue = Int32.Parse(lines[i]);
                }
                else
                {
                    builder.Append(lines[i]);
                }
            }

            InitializeDataArray();
            var values = builder.ToString().Split();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Data[y][x] = Int32.Parse(values[(y * Width) + x]);
                }
            }
        }
    }
}
