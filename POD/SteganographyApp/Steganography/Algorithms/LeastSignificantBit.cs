using Steganography.Interfaces;
using Steganography.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Algorithms
{
    class LeastSignificantBit : ISteganographyAlgorithm
    {

        public Bitmap GetBitmap(string fileName)
        {
            return new Bitmap(fileName);
        }

        public Bitmap HideText(string text, Bitmap image, AlgorithmSettings settings)
        {
            Color[] colors = BitmapConverter.BitmapToColorArray(image, settings.Direction);
            var cleaned = BitmapConverter.CleanColorArrayFromLSB(colors);

            int offset = CalculateOffset(settings.OffsetX, settings.OffsetY, image.Width, image.Height, settings.Direction);

            var hiden = WriteBytesInColorArray(Encoding.UTF8.GetBytes(text), cleaned, offset);                       

            return BitmapConverter.ColorArrayToBitmap(hiden, image.Width, image.Height, settings.Direction);
        }

        public string ExtractText(Bitmap image, AlgorithmSettings settings)
        {
            Color[] colors = BitmapConverter.BitmapToColorArray(image, settings.Direction);

            int offset = CalculateOffset(settings.OffsetX, settings.OffsetY, image.Width, image.Height, settings.Direction);

            var data = ReadBytesFromColorArray(colors, offset);

            return Encoding.ASCII.GetString(data);
        }

        public Bitmap HideBytes(byte[] data, Bitmap image, AlgorithmSettings settings)
        {
            Color[] colors = BitmapConverter.BitmapToColorArray(image, settings.Direction);
            var cleaned = BitmapConverter.CleanColorArrayFromLSB(colors);

            int offset = CalculateOffset(settings.OffsetX, settings.OffsetY, image.Width, image.Height, settings.Direction);

            var hiden = WriteBytesInColorArray(data, cleaned, offset);

            return BitmapConverter.ColorArrayToBitmap(hiden, image.Width, image.Height, settings.Direction);
        }

        public byte[] ExtractBytes(Bitmap image, AlgorithmSettings settings)
        {
            Color[] colors = BitmapConverter.BitmapToColorArray(image, settings.Direction);

            int offset = CalculateOffset(settings.OffsetX, settings.OffsetY, image.Width, image.Height, settings.Direction);

            return ReadBytesFromColorArray(colors, offset);            
        }

        private Color[] WriteBytesInColorArray(byte[] bytes, Color[] colors, int offset)
        {
            BitArray bits = new BitArray(bytes);

            for(int i = 0; i < bits.Length; i+=8)
            {
                colors[offset] = Color.FromArgb(
                    bits[i + 0] ? colors[offset].R + 1 : colors[offset].R,
                    bits[i + 1] ? colors[offset].G + 1 : colors[offset].G,
                    bits[i + 2] ? colors[offset].B + 1 : colors[offset].B);
                colors[offset + 1] = Color.FromArgb(
                    bits[i + 3] ? colors[offset + 1].R + 1 : colors[offset + 1].R,
                    bits[i + 4] ? colors[offset + 1].G + 1 : colors[offset + 1].G,
                    bits[i + 5] ? colors[offset + 1].B + 1 : colors[offset + 1].B);
                colors[offset + 2] = Color.FromArgb(
                    bits[i + 6] ? colors[offset + 2].R + 1 : colors[offset + 2].R,
                    bits[i + 7] ? colors[offset + 2].G + 1 : colors[offset + 2].G,
                    i == bits.Length - 8 ? colors[offset + 2].B + 1 : colors[offset + 2].B);
                offset += 3;
            }

            return colors;
        }

        private byte[] ReadBytesFromColorArray(Color[] colors, int offset)
        {
            int temp;
            List<byte> bytes = new List<byte>();

            while (offset < colors.Length - 3)
            {
                temp = 0;
                temp += (colors[offset + 0].R % 2 == 1) ? 1 : 0;
                temp += (colors[offset + 0].G % 2 == 1) ? 2 : 0;
                temp += (colors[offset + 0].B % 2 == 1) ? 4 : 0;
                temp += (colors[offset + 1].R % 2 == 1) ? 8 : 0;
                temp += (colors[offset + 1].G % 2 == 1) ? 16 : 0;
                temp += (colors[offset + 1].B % 2 == 1) ? 32 : 0;
                temp += (colors[offset + 2].R % 2 == 1) ? 64 : 0;
                temp += (colors[offset + 2].G % 2 == 1) ? 128 : 0;
                bytes.Add((byte)temp);

                if (colors[offset + 2].B % 2 == 1) break;

                offset += 3;
            }

            return bytes.ToArray();
        }

        private int CalculateOffset(int offsetX, int offsetY, int width, int height, Direction direction)
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
