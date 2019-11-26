using FIPSTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.TestResults
{
    public class SeriesTestResult : ITestResult
    {
        public bool IsPassed { get { return AreAllPassed(); } }        
        public Serie[] Ones { get; set; }
        public Serie[] Zeros { get; set; }

        public SeriesTestResult()
        {
            Ones = new Serie[6];
            Ones[0] = new Serie(1, 2315, 2685);
            Ones[1] = new Serie(2, 1114, 1386);
            Ones[2] = new Serie(3, 527, 723);
            Ones[3] = new Serie(4, 240, 384);
            Ones[4] = new Serie(5, 103, 209);
            Ones[5] = new Serie(6, 103, 209);

            Zeros = new Serie[6];
            Zeros[0] = new Serie(1, 2315, 2685);
            Zeros[1] = new Serie(2, 1114, 1386);
            Zeros[2] = new Serie(3, 527, 723);
            Zeros[3] = new Serie(4, 240, 384);
            Zeros[4] = new Serie(5, 103, 209);
            Zeros[5] = new Serie(6, 103, 209);
        }

        private bool AreAllPassed()
        {
            foreach(Serie s in Ones)
            {
                if (!s.IsPassed) return false;
            }
            foreach (Serie s in Zeros)
            {
                if (!s.IsPassed) return false;
            }

            return true;
        }

        public string ToStringOnes()
        {
            return $"{Ones[0].ToString()}\n" +
                $"{Ones[1].ToString()}\n" +
                $"{Ones[2].ToString()}\n" +
                $"{Ones[3].ToString()}\n" +
                $"{Ones[4].ToString()}\n" +
                $"{Ones[5].ToString()}";
        }

        public string ToStringZeros()
        {
            return $"{Zeros[0].ToString()}\n" +
                $"{Zeros[1].ToString()}\n" +
                $"{Zeros[2].ToString()}\n" +
                $"{Zeros[3].ToString()}\n" +
                $"{Zeros[4].ToString()}\n" +
                $"{Zeros[5].ToString()}";
        }
    }
}
