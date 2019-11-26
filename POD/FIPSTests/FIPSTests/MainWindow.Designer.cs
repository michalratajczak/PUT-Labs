namespace FIPSTests
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.binaryFileTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.asciiFileTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.pokerTest = new System.Windows.Forms.CheckBox();
            this.longSeriesTest = new System.Windows.Forms.CheckBox();
            this.seriesTest = new System.Windows.Forms.CheckBox();
            this.singleBitTest = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binaryFileTypeRadioButton);
            this.groupBox1.Controls.Add(this.asciiFileTypeRadioButton);
            this.groupBox1.Controls.Add(this.selectFileButton);
            this.groupBox1.Controls.Add(this.pathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plik testowy";
            // 
            // binaryFileTypeRadioButton
            // 
            this.binaryFileTypeRadioButton.AutoSize = true;
            this.binaryFileTypeRadioButton.Location = new System.Drawing.Point(182, 51);
            this.binaryFileTypeRadioButton.Name = "binaryFileTypeRadioButton";
            this.binaryFileTypeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.binaryFileTypeRadioButton.TabIndex = 3;
            this.binaryFileTypeRadioButton.TabStop = true;
            this.binaryFileTypeRadioButton.Text = "Plik binarny";
            this.binaryFileTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // asciiFileTypeRadioButton
            // 
            this.asciiFileTypeRadioButton.AutoSize = true;
            this.asciiFileTypeRadioButton.Checked = true;
            this.asciiFileTypeRadioButton.Location = new System.Drawing.Point(20, 51);
            this.asciiFileTypeRadioButton.Name = "asciiFileTypeRadioButton";
            this.asciiFileTypeRadioButton.Size = new System.Drawing.Size(123, 17);
            this.asciiFileTypeRadioButton.TabIndex = 2;
            this.asciiFileTypeRadioButton.TabStop = true;
            this.asciiFileTypeRadioButton.Text = "Plik tekstowy (ASCII)";
            this.asciiFileTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(327, 20);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(89, 28);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Wybierz plik";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(20, 25);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(289, 20);
            this.pathTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectAllButton);
            this.groupBox2.Controls.Add(this.pokerTest);
            this.groupBox2.Controls.Add(this.longSeriesTest);
            this.groupBox2.Controls.Add(this.seriesTest);
            this.groupBox2.Controls.Add(this.singleBitTest);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testy";
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(327, 23);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(84, 37);
            this.selectAllButton.TabIndex = 4;
            this.selectAllButton.Text = "Zaznacz wszystkie";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // pokerTest
            // 
            this.pokerTest.AutoSize = true;
            this.pokerTest.Location = new System.Drawing.Point(20, 131);
            this.pokerTest.Name = "pokerTest";
            this.pokerTest.Size = new System.Drawing.Size(96, 17);
            this.pokerTest.TabIndex = 3;
            this.pokerTest.Text = "Test pokerowy";
            this.pokerTest.UseVisualStyleBackColor = true;
            // 
            // longSeriesTest
            // 
            this.longSeriesTest.AutoSize = true;
            this.longSeriesTest.Location = new System.Drawing.Point(20, 99);
            this.longSeriesTest.Name = "longSeriesTest";
            this.longSeriesTest.Size = new System.Drawing.Size(103, 17);
            this.longSeriesTest.TabIndex = 2;
            this.longSeriesTest.Text = "Test długiej serii";
            this.longSeriesTest.UseVisualStyleBackColor = true;
            // 
            // seriesTest
            // 
            this.seriesTest.AutoSize = true;
            this.seriesTest.Location = new System.Drawing.Point(20, 67);
            this.seriesTest.Name = "seriesTest";
            this.seriesTest.Size = new System.Drawing.Size(68, 17);
            this.seriesTest.TabIndex = 1;
            this.seriesTest.Text = "Test serii";
            this.seriesTest.UseVisualStyleBackColor = true;
            // 
            // singleBitTest
            // 
            this.singleBitTest.AutoSize = true;
            this.singleBitTest.Location = new System.Drawing.Point(20, 34);
            this.singleBitTest.Name = "singleBitTest";
            this.singleBitTest.Size = new System.Drawing.Size(143, 17);
            this.singleBitTest.TabIndex = 0;
            this.singleBitTest.Text = "Test pojedynczych bitów";
            this.singleBitTest.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(156, 311);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 44);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 380);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "FIPS 140-2 Tests";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton binaryFileTypeRadioButton;
        private System.Windows.Forms.RadioButton asciiFileTypeRadioButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.CheckBox pokerTest;
        private System.Windows.Forms.CheckBox longSeriesTest;
        private System.Windows.Forms.CheckBox seriesTest;
        private System.Windows.Forms.CheckBox singleBitTest;
        private System.Windows.Forms.Button startButton;
    }
}

