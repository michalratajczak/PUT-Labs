using FIPSTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.TestResults
{
    public class SingleBitTestResult : ITestResult
    {
        public bool IsPassed { get { return (Counter >= Minimum && Counter <= Maximum); } }
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }
        public int Counter { get; set; }

        public SingleBitTestResult()
        {
            Minimum = 9726;
            Maximum = 10274;
            Counter = 0;
        }

        public override string ToString()
        {
            return $"{Counter}   ({Minimum} - {Maximum})";
        }
    }
}
