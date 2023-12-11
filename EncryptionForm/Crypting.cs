using System;
using System.IO;
using System.Text;

namespace EncryptionForm
{
    public class Crypting
    {
        private Form1 form;

        public Crypting(Form1 form)
        {
            this.form = form;
        }

        public string EncryptFile(string filePath, string key)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            for (int i = 0; i < fileBytes.Length; i++)
            {
                fileBytes[i] ^= keyBytes[i % keyBytes.Length];

                int percent = (int)((i + 1.0) / fileBytes.Length * 100);

                if ((i + 1) % (fileBytes.Length / 100) == 0)
                    form.backgroundWorker1.ReportProgress(percent);
            }

            string encryptedFilePath = "encrypted_" + Path.GetFileName(filePath);
            File.WriteAllBytes(encryptedFilePath, fileBytes);

            return encryptedFilePath;
        }

        public string DecryptFile(string filePath, string key)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            for (int i = 0; i < fileBytes.Length; i++)
            {
                fileBytes[i] ^= keyBytes[i % keyBytes.Length];

                int percent = (int)((i + 1.0) / fileBytes.Length * 100);

                if ((i + 1) % (fileBytes.Length / 100) == 0)
                    form.backgroundWorker1.ReportProgress(percent);
            }

            string decryptedFilePath = "decrypted_" + Path.GetFileName(filePath);
            File.WriteAllBytes(decryptedFilePath, fileBytes);

            return decryptedFilePath;
        }
    }
}
