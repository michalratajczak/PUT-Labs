using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCryptography
{
    public partial class MainWindow : Form
    {
        public string Path
        {
            get
            {
                return imagePathTextBox.Text;
            }
            set
            {
                imagePathTextBox.Text = value;
            }
        }

        public Bitmap OriginalImage { get; set; }
        public List<Bitmap> Parts { get; set; }
        private int actualPartIndex;
        public Bitmap MergedParts { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private async void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Path = dialog.FileName;

                try
                {
                    OriginalImage = new Bitmap(Path);
                    pictureBox.Image = OriginalImage;
                    actualPartIndex = 0;

                    originalImageButton.Enabled = true;
                    startButton.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Nieprawidłowy typ pliku!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }            
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            mergedPartsButton.Enabled = false;
            previousPartButton.Enabled = false;
            nextPartButton.Enabled = false;
            partsCountLabel.Text = "-";

            Parts = await Crypto.DivideImageAsync(OriginalImage);

            partsCountLabel.Text = $"{ Parts.Count }";
            previousPartButton.Enabled = true;
            nextPartButton.Enabled = true;

            MergedParts = await Crypto.MergePartsAsync(Parts, Parts[0].Width, Parts[0].Height);

            mergedPartsButton.Enabled = true;
        }

        private void mergedPartsButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = MergedParts;
            actualPartIndex = 0;
            partsCountLabel.Text = "-";
        }

        private void originalImageButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = OriginalImage;
            actualPartIndex = 0;
            partsCountLabel.Text = "-";
        }

        private void previousPartButton_Click(object sender, EventArgs e)
        {
            if(actualPartIndex == 0)
            {
                actualPartIndex = 1;
                pictureBox.Image = Parts[actualPartIndex - 1];
                actualPartLabel.Text = $"{ actualPartIndex }";
            }
            else if(actualPartIndex > 1)
            {
                actualPartIndex--;
                pictureBox.Image = Parts[actualPartIndex - 1];
                actualPartLabel.Text = $"{ actualPartIndex }";
            }
        }

        private void nextPartButton_Click(object sender, EventArgs e)
        {
            if (actualPartIndex == 0)
            {
                actualPartIndex = 1;
                pictureBox.Image = Parts[actualPartIndex - 1];
                actualPartLabel.Text = $"{ actualPartIndex }";
            }
            else if (actualPartIndex < Parts.Count)
            {
                actualPartIndex++;
                pictureBox.Image = Parts[actualPartIndex - 1];
                actualPartLabel.Text = $"{actualPartIndex }";
            }
        }
    }
}
