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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.startButton.Location = new System.Drawing.Point(246, 560);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 48);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 620);
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
    }
}

