using Steganography.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Interfaces
{
    public interface ISteganographyAlgorithm
    {
        public Bitmap GetBitmap(string fileName);
        public Bitmap HideText(string text, Bitmap image, AlgorithmSettings settings);
        public string ExtractText(Bitmap image, AlgorithmSettings settings);
        public Bitmap HideBytes(byte[] data, Bitmap image, AlgorithmSettings settings);
        public byte[] ExtractBytes(Bitmap image, AlgorithmSettings settings);
    }
}
