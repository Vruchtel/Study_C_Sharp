namespace Binarization
{
    partial class Binarization
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
            this.groupBoxWithPictures = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.doBinarizationButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxWithPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.fileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWithPictures
            // 
            this.groupBoxWithPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWithPictures.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxWithPictures.Controls.Add(this.splitter1);
            this.groupBoxWithPictures.Controls.Add(this.resultPictureBox);
            this.groupBoxWithPictures.Controls.Add(this.previewPictureBox);
            this.groupBoxWithPictures.Location = new System.Drawing.Point(12, 42);
            this.groupBoxWithPictures.Name = "groupBoxWithPictures";
            this.groupBoxWithPictures.Size = new System.Drawing.Size(877, 552);
            this.groupBoxWithPictures.TabIndex = 0;
            this.groupBoxWithPictures.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 533);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(452, 9);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(419, 537);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(6, 9);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(423, 537);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(6, 10);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(178, 23);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Выбрать файл";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(205, 15);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(79, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "путь да файла";
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.chooseFileButton);
            this.fileGroupBox.Controls.Add(this.fileNameLabel);
            this.fileGroupBox.Location = new System.Drawing.Point(12, 4);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(878, 41);
            this.fileGroupBox.TabIndex = 3;
            this.fileGroupBox.TabStop = false;
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.FileName = "Выбор файла";
            // 
            // doBinarizationButton
            // 
            this.doBinarizationButton.Location = new System.Drawing.Point(15, 604);
            this.doBinarizationButton.Name = "doBinarizationButton";
            this.doBinarizationButton.Size = new System.Drawing.Size(281, 23);
            this.doBinarizationButton.TabIndex = 4;
            this.doBinarizationButton.Text = "Запустить бинаризацию";
            this.doBinarizationButton.UseVisualStyleBackColor = true;
            this.doBinarizationButton.Click += new System.EventHandler(this.doBinarization_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(320, 609);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 5;
            // 
            // Binarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(902, 639);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.doBinarizationButton);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.groupBoxWithPictures);
            this.Name = "Binarization";
            this.Text = "Binarizaton";
            this.groupBoxWithPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWithPictures;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button doBinarizationButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

