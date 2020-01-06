namespace VisualCryptography
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mergedPartsButton = new System.Windows.Forms.Button();
            this.originalImageButton = new System.Windows.Forms.Button();
            this.actualPartLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partsCountLabel = new System.Windows.Forms.Label();
            this.previousPartButton = new System.Windows.Forms.Button();
            this.nextPartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whitePixelRadio = new System.Windows.Forms.RadioButton();
            this.transparentPixelRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Location = new System.Drawing.Point(12, 18);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(38, 13);
            this.imagePathLabel.TabIndex = 0;
            this.imagePathLabel.Text = "Obraz:";
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(56, 15);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.ReadOnly = true;
            this.imagePathTextBox.Size = new System.Drawing.Size(492, 20);
            this.imagePathTextBox.TabIndex = 1;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(563, 15);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(40, 20);
            this.selectImageButton.TabIndex = 2;
            this.selectImageButton.Text = "...";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(484, 557);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 51);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(591, 426);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // mergedPartsButton
            // 
            this.mergedPartsButton.Enabled = false;
            this.mergedPartsButton.Location = new System.Drawing.Point(500, 494);
            this.mergedPartsButton.Name = "mergedPartsButton";
            this.mergedPartsButton.Size = new System.Drawing.Size(104, 28);
            this.mergedPartsButton.TabIndex = 6;
            this.mergedPartsButton.Text = "Złączone udziały";
            this.mergedPartsButton.UseVisualStyleBackColor = true;
            this.mergedPartsButton.Click += new System.EventHandler(this.mergedPartsButton_Click);
            // 
            // originalImageButton
            // 
            this.originalImageButton.Enabled = false;
            this.originalImageButton.Location = new System.Drawing.Point(12, 494);
            this.originalImageButton.Name = "originalImageButton";
            this.originalImageButton.Size = new System.Drawing.Size(99, 28);
            this.originalImageButton.TabIndex = 7;
            this.originalImageButton.Text = "Oryginalny obraz";
            this.originalImageButton.UseVisualStyleBackColor = true;
            this.originalImageButton.Click += new System.EventHandler(this.originalImageButton_Click);
            // 
            // actualPartLabel
            // 
            this.actualPartLabel.AutoSize = true;
            this.actualPartLabel.Location = new System.Drawing.Point(285, 502);
            this.actualPartLabel.Name = "actualPartLabel";
            this.actualPartLabel.Size = new System.Drawing.Size(10, 13);
            this.actualPartLabel.TabIndex = 8;
            this.actualPartLabel.Text = "-";
            this.actualPartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // partsCountLabel
            // 
            this.partsCountLabel.AutoSize = true;
            this.partsCountLabel.Location = new System.Drawing.Point(319, 502);
            this.partsCountLabel.Name = "partsCountLabel";
            this.partsCountLabel.Size = new System.Drawing.Size(10, 13);
            this.partsCountLabel.TabIndex = 10;
            this.partsCountLabel.Text = "-";
            // 
            // previousPartButton
            // 
            this.previousPartButton.Enabled = false;
            this.previousPartButton.Location = new System.Drawing.Point(222, 494);
            this.previousPartButton.Name = "previousPartButton";
            this.previousPartButton.Size = new System.Drawing.Size(43, 28);
            this.previousPartButton.TabIndex = 11;
            this.previousPartButton.Text = "<<";
            this.previousPartButton.UseVisualStyleBackColor = true;
            this.previousPartButton.Click += new System.EventHandler(this.previousPartButton_Click);
            // 
            // nextPartButton
            // 
            this.nextPartButton.Enabled = false;
            this.nextPartButton.Location = new System.Drawing.Point(351, 494);
            this.nextPartButton.Name = "nextPartButton";
            this.nextPartButton.Size = new System.Drawing.Size(43, 28);
            this.nextPartButton.TabIndex = 12;
            this.nextPartButton.Text = ">>";
            this.nextPartButton.UseVisualStyleBackColor = true;
            this.nextPartButton.Click += new System.EventHandler(this.nextPartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveFileCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.transparentPixelRadio);
            this.groupBox1.Controls.Add(this.whitePixelRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia";
            // 
            // whitePixelRadio
            // 
            this.whitePixelRadio.AutoSize = true;
            this.whitePixelRadio.Checked = true;
            this.whitePixelRadio.Location = new System.Drawing.Point(132, 26);
            this.whitePixelRadio.Name = "whitePixelRadio";
            this.whitePixelRadio.Size = new System.Drawing.Size(48, 17);
            this.whitePixelRadio.TabIndex = 0;
            this.whitePixelRadio.TabStop = true;
            this.whitePixelRadio.Text = "biały";
            this.whitePixelRadio.UseVisualStyleBackColor = true;
            // 
            // transparentPixelRadio
            // 
            this.transparentPixelRadio.AutoSize = true;
            this.transparentPixelRadio.Location = new System.Drawing.Point(186, 26);
            this.transparentPixelRadio.Name = "transparentPixelRadio";
            this.transparentPixelRadio.Size = new System.Drawing.Size(88, 17);
            this.transparentPixelRadio.TabIndex = 1;
            this.transparentPixelRadio.Text = "przezroczysty";
            this.transparentPixelRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kolor jasnego piksela:";
            // 
            // saveFileCheckBox
            // 
            this.saveFileCheckBox.AutoSize = true;
            this.saveFileCheckBox.Location = new System.Drawing.Point(339, 27);
            this.saveFileCheckBox.Name = "saveFileCheckBox";
            this.saveFileCheckBox.Size = new System.Drawing.Size(78, 17);
            this.saveFileCheckBox.TabIndex = 3;
            this.saveFileCheckBox.Text = "Zapisz pliki";
            this.saveFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextPartButton);
            this.Controls.Add(this.previousPartButton);
            this.Controls.Add(this.partsCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualPartLabel);
            this.Controls.Add(this.originalImageButton);
            this.Controls.Add(this.mergedPartsButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.imagePathLabel);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Kryptografia wizualna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button mergedPartsButton;
        private System.Windows.Forms.Button originalImageButton;
        private System.Windows.Forms.Label actualPartLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label partsCountLabel;
        private System.Windows.Forms.Button previousPartButton;
        private System.Windows.Forms.Button nextPartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox saveFileCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton transparentPixelRadio;
        private System.Windows.Forms.RadioButton whitePixelRadio;
    }
}

