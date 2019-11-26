using FIPSTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.TestResults
{
    public class LongSeriesTestResult : ITestResult
    {
        public bool IsPassed { get { return LongestSerie <= Maximum; } }
        public int Maximum { get; private set; }
        public int LongestSerie { get; set; }

        public LongSeriesTestResult()
        {
            Maximum = 25;
            LongestSerie = 0;
        }

        public override string ToString()
        {
            return $"{LongestSerie}   (< {Maximum + 1})";
        }
    }
}
