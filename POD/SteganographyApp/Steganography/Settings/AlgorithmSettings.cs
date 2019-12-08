using Newtonsoft.Json;
using Steganography.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Settings
{
    public class AlgorithmSettings : ISteganographySettings
    {
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public Direction Direction { get; set; }

        private AlgorithmSettings() { }

        public AlgorithmSettings(int offsetX, int offsetY, Direction direction)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
            Direction = direction;
        }

        public AlgorithmSettings(string fileName)
        {
            Load(fileName);
        }

        public string Export()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void Import(string settings)
        {
            var s = JsonConvert.DeserializeObject<AlgorithmSettings>(settings);
            OffsetX = s.OffsetX;
            OffsetY = s.OffsetY;
            Direction = s.Direction;
        }

        public void Load(string fileName)
        {
            var settings = File.ReadAllText(fileName);
            Import(settings);            
        }

        public void Save(string fileName)
        {
            File.WriteAllText(fileName, Export());
        }
    }
}
