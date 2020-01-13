namespace RSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.randomPrimeNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phiLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.swapDataButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj dwie liczby pierwsze:";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(34, 42);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(127, 20);
            this.pTextBox.TabIndex = 1;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(34, 68);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(127, 20);
            this.qTextBox.TabIndex = 2;
            // 
            // randomPrimeNumber
            // 
            this.randomPrimeNumber.Location = new System.Drawing.Point(178, 45);
            this.randomPrimeNumber.Name = "randomPrimeNumber";
            this.randomPrimeNumber.Size = new System.Drawing.Size(56, 39);
            this.randomPrimeNumber.TabIndex = 3;
            this.randomPrimeNumber.Text = "Losuj";
            this.randomPrimeNumber.UseVisualStyleBackColor = true;
            this.randomPrimeNumber.Click += new System.EventHandler(this.randomPrimeNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "p:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "n = p * q =";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(79, 21);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(16, 13);
            this.nLabel.TabIndex = 7;
            this.nLabel.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "phi = (p - 1) (q - 1) =";
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Location = new System.Drawing.Point(122, 43);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(16, 13);
            this.phiLabel.TabIndex = 9;
            this.phiLabel.Text = "...";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(45, 66);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(16, 13);
            this.eLabel.TabIndex = 10;
            this.eLabel.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "e =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "d = ";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(45, 90);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(16, 13);
            this.dLabel.TabIndex = 14;
            this.dLabel.Text = "...";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(533, 45);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 38);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dLabel);
            this.groupBox1.Controls.Add(this.nLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.phiLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.eLabel);
            this.groupBox1.Location = new System.Drawing.Point(272, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 118);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(432, 62);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wiadomość:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(533, 214);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 38);
            this.encryptButton.TabIndex = 19;
            this.encryptButton.Text = "Szyfruj";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wynik:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Klucz ( _ / n):";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(84, 171);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(150, 20);
            this.keyTextBox.TabIndex = 22;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(240, 171);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(150, 20);
            this.nTextBox.TabIndex = 23;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(84, 291);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(432, 61);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
            // 
            // swapDataButton
            // 
            this.swapDataButton.Location = new System.Drawing.Point(533, 303);
            this.swapDataButton.Name = "swapDataButton";
            this.swapDataButton.Size = new System.Drawing.Size(75, 38);
            this.swapDataButton.TabIndex = 27;
            this.swapDataButton.Text = "Zamień";
            this.swapDataButton.UseVisualStyleBackColor = true;
            this.swapDataButton.Click += new System.EventHandler(this.swapDataButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 387);
            this.Controls.Add(this.swapDataButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randomPrimeNumber);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Button randomPrimeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button swapDataButton;
    }
}

