using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Interfaces
{
    public interface ISteganographySettings
    {
        public void Import(string settings);
        public string Export();
        public void Load(string fileName);
        public void Save(string fileName);
    }

    public enum Direction
    {
        Vertical,
        Horizontal
    }
}
