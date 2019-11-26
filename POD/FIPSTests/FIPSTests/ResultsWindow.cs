using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIPSTests
{
    public partial class ResultsWindow : Form
    {
        public Results Results { get; private set; }
        private string _fileName;

        public ResultsWindow(Results results, string fileName)
        {
            InitializeComponent();
            Results = results;
            _fileName = fileName;

            UpdateResult();
        }

        private void UpdateResult()
        {
            if(Results.SingleBitTest != null)
            {
                singleBitTestLabel.Text = Results.SingleBitTest.ToString();
                singleBitTestSuccess.Text = "Sukces: " + (Results.SingleBitTest.IsPassed ? "Tak" : "Nie");
            }

            if(Results.SeriesTest != null)
            {
                seriesTestOnesLabel.Text = Results.SeriesTest.ToStringOnes();
                seriesTestZerosLabel.Text = Results.SeriesTest.ToStringZeros();
                seriesTestSuccess.Text = "Sukces: " + (Results.SeriesTest.IsPassed ? "Tak" : "Nie");
            }

            if(Results.LongSeriesTest != null)
            {
                longSeriesTestLabel.Text = Results.LongSeriesTest.ToString();
                longSeriesTestSuccess.Text = "Sukces: " + (Results.LongSeriesTest.IsPassed ? "Tak" : "Nie");
            }

            if(Results.PokerTest != null)
            {
                pokerTestLabel.Text = Results.PokerTest.ToString();
                pokerTestSuccess.Text = "Sukces: " + (Results.PokerTest.IsPassed ? "Tak" : "Nie");
            }
        }

        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(dialog.FileName, Results.GenerateResultsRaport(_fileName));
                Process.Start(dialog.FileName);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
