using FIPSTests.TestResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests
{
    public class Results
    {
        public SingleBitTestResult SingleBitTest { get; set; }
        public SeriesTestResult SeriesTest { get; set; }
        public LongSeriesTestResult LongSeriesTest { get; set; }
        public PokerTestResult PokerTest { get; set; }

        public string[] GenerateResultsRaport(string fileName)
        {
            List<string> results = new List<string>();

            results.Add("Plik: " + fileName);
            results.Add("Data: " + DateTime.Now.ToString());
            results.Add("");

            if (SingleBitTest != null)
            {
                results.Add("========== Test pojedynczych bitów ==========");
                results.Add("Wynik:     " + SingleBitTest.Counter);
                results.Add("Minimum:   " + SingleBitTest.Minimum);
                results.Add("Maximum:   " + SingleBitTest.Maximum);
                results.Add("Sukces:    " + (SingleBitTest.IsPassed ? "TAK" : "NIE"));
                results.Add("");
            }
            if(SeriesTest != null)
            {
                results.Add("========== Test serii ==========");
                results.Add("Jedynki:");
                foreach(var serie in SeriesTest.Ones)
                {
                    results.Add("[" + serie.Length + "] " +
                        (serie.Counter < 1000 ? " " : "") + serie.Counter +
                        (serie.Minimum < 1000 ? " " : "") + "   (" + serie.Minimum + 
                        " - " + serie.Maximum + ")  " + (serie.Maximum < 1000 ? " " : "") + (serie.IsPassed ? "1" : "0"));
                }

                results.Add("\nZera:");
                foreach (var serie in SeriesTest.Zeros)
                {
                    results.Add("[" + serie.Length + "] " +
                        (serie.Counter < 1000 ? " " : "") + serie.Counter +
                        (serie.Minimum < 1000 ? " " : "") + "   (" + serie.Minimum +
                        " - " + serie.Maximum + ")  " + (serie.Maximum < 1000 ? " " : "") + (serie.IsPassed ? "1" : "0"));
                }
                results.Add("\nSukces:    " + (SeriesTest.IsPassed ? "TAK" : "NIE"));
                results.Add("");
            }
            if(LongSeriesTest != null)
            {
                results.Add("========== Test długiej serii ==========");
                results.Add("Najdłuższa seria: " + LongSeriesTest.LongestSerie);
                results.Add("Maksymalna długość serii: " + LongSeriesTest.Maximum);
                results.Add("Sukces:    " + (LongSeriesTest.IsPassed ? "TAK" : "NIE"));
                results.Add("");
            }
            if (PokerTest != null)
            {
                results.Add("========== Test pokerowy ==========");
                for (int i = 0; i < PokerTest.Counters.Length; i++)
                {
                    results.Add($"[{i.ToString("X1")}] {PokerTest.Counters[i]}");
                }
                results.Add("Wynik:     " + PokerTest.Value);
                results.Add("Minimum:   " + PokerTest.Minimum);
                results.Add("Maximum:   " + PokerTest.Maximum);
                results.Add("Sukces:    " + (PokerTest.IsPassed ? "TAK" : "NIE"));
                results.Add("");
            }

            return results.ToArray();
        }
    }
}
