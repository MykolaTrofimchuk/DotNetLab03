namespace EncryptionForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_for_key = new TextBox();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            filePath_label = new Label();
            start_button = new Button();
            radioButton_encrypting = new RadioButton();
            radioButton_decrypting = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_for_key
            // 
            textBox_for_key.BackColor = SystemColors.InactiveBorder;
            textBox_for_key.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_for_key.Location = new Point(41, 109);
            textBox_for_key.Name = "textBox_for_key";
            textBox_for_key.PlaceholderText = "input key";
            textBox_for_key.Size = new Size(100, 27);
            textBox_for_key.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(41, 212);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(387, 36);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.folder_open_document_icon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(41, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // filePath_label
            // 
            filePath_label.AutoSize = true;
            filePath_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            filePath_label.Location = new Point(97, 57);
            filePath_label.Name = "filePath_label";
            filePath_label.Size = new Size(0, 20);
            filePath_label.TabIndex = 3;
            // 
            // start_button
            // 
            start_button.BackColor = SystemColors.Control;
            start_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_button.Location = new Point(41, 148);
            start_button.Name = "start_button";
            start_button.Size = new Size(100, 42);
            start_button.TabIndex = 4;
            start_button.Text = "Start";
            start_button.UseVisualStyleBackColor = false;
            start_button.Click += start_button_Click;
            // 
            // radioButton_encrypting
            // 
            radioButton_encrypting.AutoSize = true;
            radioButton_encrypting.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton_encrypting.Location = new Point(147, 110);
            radioButton_encrypting.Name = "radioButton_encrypting";
            radioButton_encrypting.Size = new Size(134, 24);
            radioButton_encrypting.TabIndex = 5;
            radioButton_encrypting.TabStop = true;
            radioButton_encrypting.Text = "Зашифрувати";
            radioButton_encrypting.UseVisualStyleBackColor = true;
            // 
            // radioButton_decrypting
            // 
            radioButton_decrypting.AutoSize = true;
            radioButton_decrypting.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton_decrypting.Location = new Point(287, 110);
            radioButton_decrypting.Name = "radioButton_decrypting";
            radioButton_decrypting.Size = new Size(141, 24);
            radioButton_decrypting.TabIndex = 6;
            radioButton_decrypting.TabStop = true;
            radioButton_decrypting.Text = "Розшифрувати";
            radioButton_decrypting.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(469, 281);
            Controls.Add(radioButton_decrypting);
            Controls.Add(radioButton_encrypting);
            Controls.Add(start_button);
            Controls.Add(filePath_label);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(textBox_for_key);
            MaximumSize = new Size(485, 320);
            MinimumSize = new Size(485, 320);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crypting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_for_key;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Label filePath_label;
        private Button start_button;
        private RadioButton radioButton_encrypting;
        private RadioButton radioButton_decrypting;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}