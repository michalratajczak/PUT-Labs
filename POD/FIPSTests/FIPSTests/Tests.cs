using FIPSTests.Interfaces;
using FIPSTests.TestResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIPSTests
{
    public class Tests : ITest
    {
        private readonly char[] _data;

        public Tests(string data)
        {
            _data = data.ToCharArray();
        }

        public Tests(byte[] bytes)
        {
            string x = "";
            foreach (var b in bytes)
            {
                x += Int32.Parse(Convert.ToString(b, 2)).ToString("00000000");
            }
            _data = x.ToCharArray();
        }


        public SingleBitTestResult SingleBitTest()
        {
            SingleBitTestResult result = new SingleBitTestResult();

            for(int i = 0; i < _data.Length; i++)
            {
                if (_data[i] == '1') result.Counter++;
            }

            return result;
        }

        public LongSeriesTestResult LongSeriesTest()
        {
            LongSeriesTestResult result = new LongSeriesTestResult();
            int tempSerie = 1;

            for (int i = 1; i < _data.Length; i++)
            {
                if (_data[i] == _data[i - 1])
                {
                    tempSerie++;
                }
                else
                {
                    result.LongestSerie = tempSerie > result.LongestSerie ? tempSerie : result.LongestSerie;
                    tempSerie = 1;
                }
            }

            return result;
        }

        public PokerTestResult PokerTest()
        {
            PokerTestResult result = new PokerTestResult();
            int temp = 0;

            for (int i = 0; i < _data.Length; i+=4)
            {
                if (_data[i] == '1') temp += 8;
                if (_data[i + 1] == '1') temp += 4;
                if (_data[i + 2] == '1') temp += 2;
                if (_data[i + 3] == '1') temp += 1;

                result.Counters[temp]++;
                temp = 0;
            }

            return result;
        }

        public SeriesTestResult SeriesTest()
        {
            SeriesTestResult result = new SeriesTestResult();
            int tempSerie = 1;
            char sign = _data[0];
            

            for (int i = 1; i < _data.Length; i++)
            {
                if (_data[i] == _data[i - 1] && _data[i] == sign) tempSerie++;
                else
                {
                    if(sign == '1')
                    {
                        switch (tempSerie)
                        {
                            case 1:
                                result.Ones[0].Counter++;
                                break;
                            case 2:
                                result.Ones[1].Counter++;
                                break;
                            case 3:
                                result.Ones[2].Counter++;
                                break;
                            case 4:
                                result.Ones[3].Counter++;
                                break;
                            case 5:
                                result.Ones[4].Counter++;
                                break;
                            default:
                                result.Ones[5].Counter++;
                                break;
                        }
                    }
                    else
                    {
                        switch (tempSerie)
                        {
                            case 1:
                                result.Zeros[0].Counter++;
                                break;
                            case 2:
                                result.Zeros[1].Counter++;
                                break;
                            case 3:
                                result.Zeros[2].Counter++;
                                break;
                            case 4:
                                result.Zeros[3].Counter++;
                                break;
                            case 5:
                                result.Zeros[4].Counter++;
                                break;
                            default:
                                result.Zeros[5].Counter++;
                                break;
                        }
                    }

                    sign = _data[i];
                    tempSerie = 1;
                }
            }

            return result;
        }

    }
}
