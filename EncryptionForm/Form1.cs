using System.ComponentModel;
using System.Text;

namespace EncryptionForm
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;
        private BackgroundWorker encryptionWorker;
        private DateTime startTime;

        private Crypting crypting;

        public Form1()
        {
            InitializeComponent();
            crypting = new Crypting(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    filePath_label.Text = selectedFilePath;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Tuple<string, string, bool> arguments = (Tuple<string, string, bool>)e.Argument;
            string filePath = arguments.Item1;
            string key = arguments.Item2;
            bool encrypt = arguments.Item3;

            if (encrypt)
            {
                e.Result = crypting.EncryptFile(filePath, key);
            }
            else
            {
                e.Result = crypting.DecryptFile(filePath, key);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            start_button.Enabled = true;
            radioButton_encrypting.Enabled = true;
            radioButton_decrypting.Enabled = true;

            if (e.Error != null)
            {
                MessageBox.Show("Виникла Помилка:\n" + e.Error.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string resultFilePath = (string)e.Result;
                TimeSpan elapsedTime = DateTime.Now - startTime;
                long resultFileSize = new FileInfo(resultFilePath).Length;

                MessageBox.Show($"Успішно виконано:\n\nШлях до вихідного файлу: {resultFilePath}\nРозмір вихідного файлу: {resultFileSize} байт\n" +
                    $"Витрачено часу: {elapsedTime.TotalSeconds} секунд", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            string key = textBox_for_key.Text;

            if (string.IsNullOrEmpty(selectedFilePath) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("ОБОВ'ЯЗКОВО! Оберіть файл та вкажіть ключ!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                start_button.Enabled = false;
                radioButton_encrypting.Enabled = false;
                radioButton_decrypting.Enabled = false;
                startTime = DateTime.Now;

                backgroundWorker1.RunWorkerAsync(new Tuple<string, string, bool>(selectedFilePath, key, radioButton_encrypting.Checked));
            }
        }
    }
}