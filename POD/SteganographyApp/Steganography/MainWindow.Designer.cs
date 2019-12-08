namespace Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.offsetY = new System.Windows.Forms.TextBox();
            this.offsetX = new System.Windows.Forms.TextBox();
            this.directionHorizontal = new System.Windows.Forms.RadioButton();
            this.directionVertical = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectDataFileButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.inputDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileInputRadio = new System.Windows.Forms.RadioButton();
            this.textInputRadio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.outputDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileOutputRadio = new System.Windows.Forms.RadioButton();
            this.textOutputRadio = new System.Windows.Forms.RadioButton();
            this.startExtractButton = new System.Windows.Forms.Button();
            this.startHidingButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.algorithmDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offsetY);
            this.groupBox1.Controls.Add(this.offsetX);
            this.groupBox1.Controls.Add(this.directionHorizontal);
            this.groupBox1.Controls.Add(this.directionVertical);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // offsetY
            // 
            resources.ApplyResources(this.offsetY, "offsetY");
            this.offsetY.Name = "offsetY";
            // 
            // offsetX
            // 
            resources.ApplyResources(this.offsetX, "offsetX");
            this.offsetX.Name = "offsetX";
            // 
            // directionHorizontal
            // 
            resources.ApplyResources(this.directionHorizontal, "directionHorizontal");
            this.directionHorizontal.Name = "directionHorizontal";
            this.directionHorizontal.UseVisualStyleBackColor = true;
            // 
            // directionVertical
            // 
            resources.ApplyResources(this.directionVertical, "directionVertical");
            this.directionVertical.Checked = true;
            this.directionVertical.Name = "directionVertical";
            this.directionVertical.TabStop = true;
            this.directionVertical.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // imagePath
            // 
            resources.ApplyResources(this.imagePath, "imagePath");
            this.imagePath.Name = "imagePath";
            this.imagePath.ReadOnly = true;
            // 
            // selectImageButton
            // 
            resources.ApplyResources(this.selectImageButton, "selectImageButton");
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectDataFileButton);
            this.groupBox3.Controls.Add(this.filePath);
            this.groupBox3.Controls.Add(this.inputDataRichTextBox);
            this.groupBox3.Controls.Add(this.fileInputRadio);
            this.groupBox3.Controls.Add(this.textInputRadio);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // selectDataFileButton
            // 
            resources.ApplyResources(this.selectDataFileButton, "selectDataFileButton");
            this.selectDataFileButton.Name = "selectDataFileButton";
            this.selectDataFileButton.UseVisualStyleBackColor = true;
            this.selectDataFileButton.Click += new System.EventHandler(this.selectDataFileButton_Click);
            // 
            // filePath
            // 
            resources.ApplyResources(this.filePath, "filePath");
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            // 
            // inputDataRichTextBox
            // 
            resources.ApplyResources(this.inputDataRichTextBox, "inputDataRichTextBox");
            this.inputDataRichTextBox.Name = "inputDataRichTextBox";
            // 
            // fileInputRadio
            // 
            resources.ApplyResources(this.fileInputRadio, "fileInputRadio");
            this.fileInputRadio.Name = "fileInputRadio";
            this.fileInputRadio.UseVisualStyleBackColor = true;
            this.fileInputRadio.CheckedChanged += new System.EventHandler(this.fileInputRadio_CheckedChanged);
            // 
            // textInputRadio
            // 
            resources.ApplyResources(this.textInputRadio, "textInputRadio");
            this.textInputRadio.Checked = true;
            this.textInputRadio.Name = "textInputRadio";
            this.textInputRadio.TabStop = true;
            this.textInputRadio.UseVisualStyleBackColor = true;
            this.textInputRadio.CheckedChanged += new System.EventHandler(this.textInputRadio_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imagePath);
            this.groupBox4.Controls.Add(this.selectImageButton);
            this.groupBox4.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.algorithmDescriptionLabel);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.algorithmComboBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.startExtractButton);
            this.tabPage1.Controls.Add(this.startHidingButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.outputDataRichTextBox);
            this.groupBox5.Controls.Add(this.fileOutputRadio);
            this.groupBox5.Controls.Add(this.textOutputRadio);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // outputDataRichTextBox
            // 
            resources.ApplyResources(this.outputDataRichTextBox, "outputDataRichTextBox");
            this.outputDataRichTextBox.Name = "outputDataRichTextBox";
            // 
            // fileOutputRadio
            // 
            resources.ApplyResources(this.fileOutputRadio, "fileOutputRadio");
            this.fileOutputRadio.Name = "fileOutputRadio";
            this.fileOutputRadio.UseVisualStyleBackColor = true;
            this.fileOutputRadio.CheckedChanged += new System.EventHandler(this.fileOutputRadio_CheckedChanged);
            // 
            // textOutputRadio
            // 
            resources.ApplyResources(this.textOutputRadio, "textOutputRadio");
            this.textOutputRadio.Checked = true;
            this.textOutputRadio.Name = "textOutputRadio";
            this.textOutputRadio.TabStop = true;
            this.textOutputRadio.UseVisualStyleBackColor = true;
            this.textOutputRadio.CheckedChanged += new System.EventHandler(this.textOutputRadio_CheckedChanged);
            // 
            // startExtractButton
            // 
            resources.ApplyResources(this.startExtractButton, "startExtractButton");
            this.startExtractButton.Name = "startExtractButton";
            this.startExtractButton.UseVisualStyleBackColor = true;
            this.startExtractButton.Click += new System.EventHandler(this.startExtractButton_Click);
            // 
            // startHidingButton
            // 
            resources.ApplyResources(this.startHidingButton, "startHidingButton");
            this.startHidingButton.Name = "startHidingButton";
            this.startHidingButton.UseVisualStyleBackColor = true;
            this.startHidingButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Items.AddRange(new object[] {
            resources.GetString("algorithmComboBox.Items")});
            resources.ApplyResources(this.algorithmComboBox, "algorithmComboBox");
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // algorithmDescriptionLabel
            // 
            resources.ApplyResources(this.algorithmDescriptionLabel, "algorithmDescriptionLabel");
            this.algorithmDescriptionLabel.Name = "algorithmDescriptionLabel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox offsetY;
        private System.Windows.Forms.TextBox offsetX;
        private System.Windows.Forms.RadioButton directionHorizontal;
        private System.Windows.Forms.RadioButton directionVertical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button selectDataFileButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.RichTextBox inputDataRichTextBox;
        private System.Windows.Forms.RadioButton fileInputRadio;
        private System.Windows.Forms.RadioButton textInputRadio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button startHidingButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button startExtractButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox outputDataRichTextBox;
        private System.Windows.Forms.RadioButton fileOutputRadio;
        private System.Windows.Forms.RadioButton textOutputRadio;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label algorithmDescriptionLabel;
        private System.Windows.Forms.Label label7;
    }
}

