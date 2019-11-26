using FIPSTests.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIPSTests
{
    public partial class MainWindow : Form
    {
        public string Path 
        {
            get { return pathTextBox.Text; } 
            set { pathTextBox.Text = value; } 
        }

        public ITest Test { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Path = dialog.FileName;

                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Results results = new Results();

            if(asciiFileTypeRadioButton.Checked)
            {
                var data = File.ReadAllText(Path);

                if(data.Length < 20000)
                {
                    MessageBox.Show("Długość ciągu nie może być mniejsza niż 20 000 znaków!", "", MessageBoxButtons.OK);
                    return;
                }
                else if(data.Length > 20000)
                {                    
                    if(MessageBox.Show("Długość ciągu jest większa niż 20 000 znaków." +
                        "\nCzy chcesz wykonać testy na pierwszych 20 000 znaków?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Test = new Tests(data.Substring(0,20000));
                    }
                    else return;

                }
                else
                {
                    Test = new Tests(data);
                }

            }
            else if(binaryFileTypeRadioButton.Checked)
            {
                var data = File.ReadAllBytes(Path);

                if (data.Length < 2500)
                {
                    MessageBox.Show("Długość ciągu nie może być mniejsza niż 20 000 znaków!", "", MessageBoxButtons.OK);
                    return;
                }
                else if (data.Length > 2500)
                {
                    if (MessageBox.Show("Długość ciągu jest większa niż 20 000 bitów." +
                        "\nCzy chcesz wykonać testy na pierwszych 20 000 bitów?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {                        
                        Test = new Tests(data.Take(2500).ToArray());
                    }
                    else return; 

                }
                else
                {             
                    Test = new Tests(data);
                }
                
            }

            if(singleBitTest.Checked)
            {
                results.SingleBitTest = Test.SingleBitTest();
            }
            if (seriesTest.Checked)
            {
                results.SeriesTest = Test.SeriesTest();
            }
            if (longSeriesTest.Checked)
            {
                results.LongSeriesTest = Test.LongSeriesTest();
            }
            if (pokerTest.Checked)
            {
                results.PokerTest = Test.PokerTest();
            }

            ResultsWindow resultsWindow = new ResultsWindow(results, Path);
            resultsWindow.ShowDialog();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            if(selectAllButton.Text == "Zaznacz wszystkie")
            {
                singleBitTest.Checked = true;
                pokerTest.Checked = true;
                seriesTest.Checked = true;
                longSeriesTest.Checked = true;
                selectAllButton.Text = "Odznacz wszystkie";
            }
            else
            {
                singleBitTest.Checked = false;
                pokerTest.Checked = false;
                seriesTest.Checked = false;
                longSeriesTest.Checked = false;
                selectAllButton.Text = "Zaznacz wszystkie";
            }
        }

    }
}
