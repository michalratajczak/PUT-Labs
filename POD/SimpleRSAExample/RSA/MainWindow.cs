using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class MainWindow : Form
    {
        public int P
        {
            get
            {
                try
                {
                    return Int32.Parse(pTextBox.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                pTextBox.Text = $"{ value }";
            }
        }
        public int Q
        {
            get
            {
                try
                {
                    return Int32.Parse(qTextBox.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                qTextBox.Text = $"{ value }";
            }
        }
        public long N
        {
            get
            {
                try
                {
                    return Int64.Parse(nLabel.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                nLabel.Text = $"{ value }";
            }
        }
        public long Phi
        {
            get
            {
                try
                {
                    return Int64.Parse(phiLabel.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                phiLabel.Text = $"{ value }";
            }
        }
        public long E
        {
            get
            {
                try
                {
                    return Int64.Parse(eLabel.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                eLabel.Text = $"{ value }";
            }
        }
        public long D
        {
            get
            {
                try
                {
                    return Int64.Parse(dLabel.Text);
                }
                catch
                {
                    return 1;
                }
            }
            set
            {
                dLabel.Text = $"{ value }";
            }
        }

        private int[] _data;

        public MainWindow()
        {
            InitializeComponent();
        }

        public int RandomPrimeNumber(Random random, int min, int max)
        {
            int r;

            do
            {
                r = random.Next(min, max);
            }
            while (!IsPrime(r));

            return r;                      
        }

        public bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i * i <= number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsRelativelyPrime(int a, int b)
        {
            int temp;

            while(b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return a == 1 ? true : false;
        }

        public bool IsRelativelyPrime(long a, long b)
        {
            long temp;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return a == 1 ? true : false;
        }

        public int RandomRelativelyPrimeNumber(Random random, long number, int min, int max)
        {
            int r;

            do
            {
                r = random.Next(min, max);
            }
            while (!IsRelativelyPrime(number, r));

            return r;                      
        }

        public long CalculateD(long e, long phi)
        {
            for (long i = 1; i < long.MaxValue; i++)
            {
                if ((i * e) % phi == 1)
                {
                    return i;
                }
            }
            return -1;                      
        }

        public long CalculateE(long phi)
        {
            for (long i = 3; i < long.MaxValue; i++)
            {
                if (IsRelativelyPrime(i, phi))
                {
                    return i;
                }
            }
            return -1;
        }

        private void randomPrimeNumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            P = RandomPrimeNumber(random, 1000, 9999);
            Q = RandomPrimeNumber(random, 1000, 9999);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            N = P * Q;
            nTextBox.Text = $"{ N }";

            Phi = (P - 1) * (Q - 1);

            E = RandomRelativelyPrimeNumber(random, Phi, 1000, 9999);
            D = CalculateD(E, Phi);
        }

        private async void encryptButton_Click(object sender, EventArgs e)
        {
            Regex numbers = new Regex(@"^(\d+\s+)+");

            if(numbers.IsMatch(richTextBox1.Text))
            {
                _data = richTextBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(num => Int32.Parse(num)).ToArray();
            }
            else
            {
                _data = Encoding.UTF8.GetBytes(richTextBox1.Text).Select(b => (int)b).ToArray();
            }


            var encrypted = await Encrypt(_data, Int32.Parse(keyTextBox.Text), Int32.Parse(nTextBox.Text));

            if(encrypted.All(num => num <= 255))
            {
                richTextBox2.Text = Encoding.UTF8.GetString(encrypted.Select(num => (byte)num).ToArray());
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                foreach(var num in encrypted)
                {
                    builder.Append(num.ToString() + " ");
                }
                richTextBox2.Text = builder.ToString();
            }

        }


        public async Task<int[]> Encrypt(int[] data, int key, long n)
        {
            return await Task.Run(() =>
            {
                int[] encrypted = new int[data.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    BigInteger temp = new BigInteger(data[i]);
                    temp = BigInteger.ModPow(temp, key, n);
                    encrypted[i] = Int32.Parse(temp.ToString());
                }

                return encrypted;
            });
        }

        private void swapDataButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox2.Text;
            richTextBox2.Text = "";
        }
    }
}
