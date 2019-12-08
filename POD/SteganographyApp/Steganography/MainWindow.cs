using Steganography.Algorithms;
using Steganography.Interfaces;
using Steganography.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Steganography
{
    public partial class MainWindow : Form
    {
        public Direction Direction 
        { 
            get
            {
                if (directionHorizontal.Checked) return Direction.Horizontal;
                else return Direction.Vertical;
            }
            set
            {
                var drct = value;
                if (drct == Direction.Horizontal) directionHorizontal.Checked = true;
                else directionVertical.Checked = true;
            }
        }
        public string ImagePath
        {
            get { return imagePath.Text; }
            set { imagePath.Text = value; }
        }
        public string DataFilePath
        {
            get { return filePath.Text; }
            set { filePath.Text = value; }
        }
        public AlgorithmSettings Settings
        {
            get
            {
                int x, y;

                try
                {
                    x = Int32.Parse(offsetX.Text);
                }
                catch
                {
                    x = 0;
                }

                try
                {
                    y = Int32.Parse(offsetY.Text);
                }
                catch
                {
                    y = 0;
                }

                return new AlgorithmSettings(x, y, Direction);
            }
            set
            {
                var set = value;
                offsetX.Text = set.OffsetX.ToString();
                offsetY.Text = set.OffsetY.ToString();
                Direction = set.Direction;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            algorithmComboBox.SelectedIndex = 0;
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Wybierz obraz w którym zostanie ukryta wiadomość";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName; 
                
                try
                {
                    Settings = new AlgorithmSettings(dialog.FileName + ".json");
                }
                catch (Exception) { }
            }
        }
        private void selectDataFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Wybierz plik z wiadomością do ukrycia";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataFilePath = dialog.FileName;
            }
        }
        private void textInputRadio_CheckedChanged(object sender, EventArgs e)
        {
            inputDataRichTextBox.Enabled = textInputRadio.Checked;
            textOutputRadio.Checked = textInputRadio.Checked;
        }
        private void fileInputRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectDataFileButton.Enabled = fileInputRadio.Checked;
            fileOutputRadio.Checked = fileInputRadio.Checked;
        }
        private void textOutputRadio_CheckedChanged(object sender, EventArgs e)
        {
            textInputRadio.Checked = textOutputRadio.Checked;
        }
        private void fileOutputRadio_CheckedChanged(object sender, EventArgs e)
        {
            fileInputRadio.Checked = fileOutputRadio.Checked;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ISteganographyAlgorithm steganography = new LeastSignificantBit();
            Bitmap image;
            Bitmap newImage;

            try
            {
                image = steganography.GetBitmap(ImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj poprawną ścieżkę do obrazu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                       
            if (textInputRadio.Checked)
            {
                string message = inputDataRichTextBox.Text;

                if (String.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Podaj tekst do ukrycia w obrazie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BitmapConverter.CalculateOffset(Settings.OffsetX, Settings.OffsetY, image.Width, image.Height, Settings.Direction) + message.Length * 3
                    > image.Width * image.Height)
                {
                    MessageBox.Show("Podany tekst jest zbyt duży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newImage = steganography.HideText(message, image, Settings);
            }
            else
            {
                byte[] data;
                               
                try
                {
                    data = File.ReadAllBytes(DataFilePath);
                }
                catch (Exception)
                {
                    MessageBox.Show("Podaj poprawną ścieżkę do pliku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                

                if (BitmapConverter.CalculateOffset(Settings.OffsetX, Settings.OffsetY, image.Width, image.Height, Settings.Direction) + data.Length * 3
                    > image.Width * image.Height)
                {
                    MessageBox.Show("Podany tekst jest zbyt duży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newImage = steganography.HideBytes(data, image, Settings);
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Zapisz nowy obraz i ustawienia algorytmu.";
            dialog.Filter = "BMP Image (*.bmp)|*.bmp";
            dialog.DefaultExt = ".bmp";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                newImage.Save(dialog.FileName, ImageFormat.Bmp);
                Settings.Save(dialog.FileName + ".json");

                Process.Start(dialog.FileName);
            }            
        }

        private void startExtractButton_Click(object sender, EventArgs e)
        {
            ISteganographyAlgorithm steganography = new LeastSignificantBit();
            Bitmap image;

            try
            {
                image = steganography.GetBitmap(ImagePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj poprawną ścieżkę do obrazu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textOutputRadio.Checked)
            {
                outputDataRichTextBox.Text = steganography.ExtractText(image, Settings);
            }
            else
            {
                byte[] data = steganography.ExtractBytes(image, Settings);

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Zapisz odzyskane dane do pliku";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dialog.FileName, data);

                    Process.Start(dialog.FileName);
                }
            }            
        }

        private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(algorithmComboBox.SelectedIndex)
            {
                case 0:
                    algorithmDescriptionLabel.Text = "Algorytm LSB polega na zmianie najmniej znaczącego bitu słowa\nopisującego dany piksel."+
                        "Oznaczony w ten sposób obraz można łatwo\nsfałszować poddając go np. konwersji do innego formatu czy kompresji.";
                    break;
                default:
                    algorithmDescriptionLabel.Text = "-";
                    break;
            }
        }
    }
}
