using FIPSTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.TestResults
{
    public class PokerTestResult : ITestResult
    {
        public bool IsPassed { get { return (Value > Minimum && Value < Maximum); } }
        public int[] Counters { get; set; }
        public float Minimum { get; private set; }
        public float Maximum { get; private set; }
        public float Value { get { return Calculate(); } }


        public PokerTestResult()
        {
            Counters = new int[16];
            Minimum = 2.16F;
            Maximum = 46.17F;

            for(int i = 0; i < 16; i++)
            {
                Counters[i] = 0;
            }
        }

        public override string ToString()
        {
            return $"x = {Value}    ({Minimum} - {Maximum})";
        }

        private float Calculate()
        {
            float x = 16F / 5000F;
            float sum = 0;

            for (int i = 0; i < 16; i++)
            {
                sum += (float)Math.Pow(Counters[i], 2);
            }

            return (x * sum) - 5000F;
        }

    }
}
