using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.TestResults
{
    public class Serie
    {
        public int Length { get; private set; }
        public int Counter { get; set; }
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }
        public bool IsPassed { get { return (Counter >= Minimum && Counter <= Maximum); } }

        public Serie(int length, int min, int max)
        {
            Length = length;
            Minimum = min;
            Maximum = max;
            Counter = 0;
        }

        public override string ToString()
        {
            return $"[{Length}]  {Counter}   ({Minimum} - {Maximum})";
        }
    }
}
