using FIPSTests.TestResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests.Interfaces
{
    public interface ITest
    {
        public SingleBitTestResult SingleBitTest();
        public SeriesTestResult SeriesTest();
        public LongSeriesTestResult LongSeriesTest();
        public PokerTestResult PokerTest();
    }
}
