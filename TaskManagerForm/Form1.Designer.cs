namespace TaskManagerForm
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
            startCalc_button = new Button();
            dataGridView1 = new DataGridView();
            NameProcces = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Memory = new DataGridViewTextBoxColumn();
            startTime = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Treads = new DataGridViewTextBoxColumn();
            startWord_button = new Button();
            startSteam_button = new Button();
            startChrome_button = new Button();
            startExplorer_button = new Button();
            killProc_button = new Button();
            downPriority_button = new Button();
            upPriority_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startCalc_button
            // 
            startCalc_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startCalc_button.Location = new Point(27, 45);
            startCalc_button.Name = "startCalc_button";
            startCalc_button.Size = new Size(114, 41);
            startCalc_button.TabIndex = 0;
            startCalc_button.Text = "Калькулятор";
            startCalc_button.UseVisualStyleBackColor = true;
            startCalc_button.Click += button_calc_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameProcces, Id, Memory, startTime, Priority, Treads });
            dataGridView1.Location = new Point(27, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(750, 283);
            dataGridView1.TabIndex = 2;
            // 
            // NameProcces
            // 
            NameProcces.HeaderText = "Ім'я";
            NameProcces.Name = "NameProcces";
            NameProcces.Width = 125;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Width = 90;
            // 
            // Memory
            // 
            Memory.HeaderText = "Пам'ять";
            Memory.Name = "Memory";
            Memory.Width = 110;
            // 
            // startTime
            // 
            startTime.HeaderText = "Час запуску";
            startTime.Name = "startTime";
            startTime.Width = 125;
            // 
            // Priority
            // 
            Priority.HeaderText = "Пріорітет";
            Priority.Name = "Priority";
            Priority.Width = 125;
            // 
            // Treads
            // 
            Treads.HeaderText = "Потоки";
            Treads.Name = "Treads";
            Treads.Width = 125;
            // 
            // startWord_button
            // 
            startWord_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startWord_button.Location = new Point(186, 45);
            startWord_button.Name = "startWord_button";
            startWord_button.Size = new Size(114, 41);
            startWord_button.TabIndex = 3;
            startWord_button.Text = "MS Word";
            startWord_button.UseVisualStyleBackColor = true;
            startWord_button.Click += startWord_button_Click;
            // 
            // startSteam_button
            // 
            startSteam_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startSteam_button.Location = new Point(347, 45);
            startSteam_button.Name = "startSteam_button";
            startSteam_button.Size = new Size(114, 41);
            startSteam_button.TabIndex = 4;
            startSteam_button.Text = "Steam";
            startSteam_button.UseVisualStyleBackColor = true;
            startSteam_button.Click += startSteam_button_Click;
            // 
            // startChrome_button
            // 
            startChrome_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startChrome_button.Location = new Point(504, 45);
            startChrome_button.Name = "startChrome_button";
            startChrome_button.Size = new Size(114, 41);
            startChrome_button.TabIndex = 5;
            startChrome_button.Text = "Chrome";
            startChrome_button.UseVisualStyleBackColor = true;
            startChrome_button.Click += startChrome_button_Click;
            // 
            // startExplorer_button
            // 
            startExplorer_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startExplorer_button.Location = new Point(663, 45);
            startExplorer_button.Name = "startExplorer_button";
            startExplorer_button.Size = new Size(114, 41);
            startExplorer_button.TabIndex = 6;
            startExplorer_button.Text = "Провідник";
            startExplorer_button.UseVisualStyleBackColor = true;
            startExplorer_button.Click += startExplorer_button_Click;
            // 
            // killProc_button
            // 
            killProc_button.BackColor = Color.LightCoral;
            killProc_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            killProc_button.Location = new Point(27, 416);
            killProc_button.Name = "killProc_button";
            killProc_button.Size = new Size(133, 66);
            killProc_button.TabIndex = 7;
            killProc_button.Text = "Завершити процес";
            killProc_button.UseVisualStyleBackColor = false;
            killProc_button.Click += killProc_button_Click;
            // 
            // downPriority_button
            // 
            downPriority_button.BackColor = Color.SandyBrown;
            downPriority_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            downPriority_button.Location = new Point(644, 416);
            downPriority_button.Name = "downPriority_button";
            downPriority_button.Size = new Size(133, 66);
            downPriority_button.TabIndex = 8;
            downPriority_button.Text = "Знизити пріорітет";
            downPriority_button.UseVisualStyleBackColor = false;
            downPriority_button.Click += downPriority_button_Click;
            // 
            // upPriority_button
            // 
            upPriority_button.BackColor = Color.CornflowerBlue;
            upPriority_button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            upPriority_button.ForeColor = SystemColors.ButtonHighlight;
            upPriority_button.Location = new Point(504, 416);
            upPriority_button.Name = "upPriority_button";
            upPriority_button.Size = new Size(133, 66);
            upPriority_button.TabIndex = 9;
            upPriority_button.Text = "Збільшити пріорітет";
            upPriority_button.UseVisualStyleBackColor = false;
            upPriority_button.Click += upPriority_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(upPriority_button);
            Controls.Add(downPriority_button);
            Controls.Add(killProc_button);
            Controls.Add(startExplorer_button);
            Controls.Add(startChrome_button);
            Controls.Add(startSteam_button);
            Controls.Add(startWord_button);
            Controls.Add(dataGridView1);
            Controls.Add(startCalc_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startCalc_button;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameProcces;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Memory;
        private DataGridViewTextBoxColumn startTime;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Treads;
        private Button startWord_button;
        private Button startSteam_button;
        private Button startChrome_button;
        private Button startExplorer_button;
        private Button killProc_button;
        private Button downPriority_button;
        private Button upPriority_button;
    }
}