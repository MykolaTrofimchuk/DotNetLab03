using System.Diagnostics;

namespace TaskManagerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddInfoAboutProcess(Process proc)
        {

            string procName = proc.ProcessName;
            int procId = proc.Id;
            var procMemmory = proc.PagedMemorySize64;
            var procStartTime = proc.StartTime;
            var procPriority = proc.PriorityClass;
            var procThreads = proc.Threads;

            dataGridView1.Rows.Add(procName, procId, procMemmory, procStartTime, procPriority, procThreads);
        }

        private void RemoveRowFromDataGridView(Process process)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Tag == process)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }

        private void UpdateRowInDataGridView(Process updatedProcess)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if ((int)row.Cells[1].Value == (int)updatedProcess.Id)
                {
                    var prior = updatedProcess.PriorityClass;

                    row.Cells[0].Value = updatedProcess.ProcessName;
                    row.Cells[1].Value = updatedProcess.Id;
                    row.Cells[2].Value = updatedProcess.PagedMemorySize64;
                    row.Cells[3].Value = updatedProcess.StartTime;
                    row.Cells[4].Value = prior;
                    row.Cells[5].Value = updatedProcess.Threads;

                    row.Tag = updatedProcess;

                    break;
                }
                else
                    MessageBox.Show("Помилка");
            }
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            var calc = Process.Start(@"calc");
            AddInfoAboutProcess((Process)calc);
        }

        private void startWord_button_Click(object sender, EventArgs e)
        {
            var msWord = Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
            AddInfoAboutProcess((Process)msWord);
        }

        private void startChrome_button_Click(object sender, EventArgs e)
        {
            var chrome = Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            AddInfoAboutProcess((Process)chrome);
        }

        private void startExplorer_button_Click(object sender, EventArgs e)
        {
            var explorer = Process.Start(@"explorer.exe");
            AddInfoAboutProcess((Process)explorer);
        }

        private void startSteam_button_Click(object sender, EventArgs e)
        {
            var taskManager = Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
            AddInfoAboutProcess((Process)taskManager);
        }

        private void killProc_button_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null)
            {
                var procIdValue = selectedRow.Cells[1].Value;

                if (procIdValue != null && int.TryParse(procIdValue.ToString(), out int procId))
                {
                    try
                    {
                        var currentProc = Process.GetProcessById(procId);
                        currentProc.Kill();

                        RemoveRowFromDataGridView(currentProc);
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Помилка при зупинці процесу: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Неможливо отримати ідентифікатор процесу.");
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для зупинки процесу.");
            }
        }


        private void upPriority_button_Click(object sender, EventArgs e)
        {
            ChangeProcessPriority(true);
        }

        private void downPriority_button_Click(object sender, EventArgs e)
        {
            ChangeProcessPriority(false);
        }

        private void ChangeProcessPriority(bool increase)
        {
            try
            {
                var selectedRow = dataGridView1.CurrentRow;

                if (selectedRow != null)
                {
                    var procIdValue = selectedRow.Cells["Id"].Value;

                    if (procIdValue != null && int.TryParse(procIdValue.ToString(), out int procId))
                    {
                        var currentProc = Process.GetProcessById(procId);

                        // Отримати поточний пріоритет
                        ProcessPriorityClass currentPriority = currentProc.PriorityClass;

                        // Змінити пріоритет
                        switch (currentPriority)
                        {
                            case ProcessPriorityClass.Idle:
                                currentProc.PriorityClass = increase ? ProcessPriorityClass.BelowNormal : ProcessPriorityClass.Idle;
                                downPriority_button.Enabled = false;
                                upPriority_button.Enabled = true;
                                break;

                            case ProcessPriorityClass.BelowNormal:
                                currentProc.PriorityClass = increase ? ProcessPriorityClass.Normal : ProcessPriorityClass.Idle;
                                downPriority_button.Enabled = true;
                                upPriority_button.Enabled = true;
                                break;

                            case ProcessPriorityClass.Normal:
                                currentProc.PriorityClass = increase ? ProcessPriorityClass.AboveNormal : ProcessPriorityClass.BelowNormal;
                                downPriority_button.Enabled = true;
                                upPriority_button.Enabled = true;
                                break;

                            case ProcessPriorityClass.AboveNormal:
                                currentProc.PriorityClass = increase ? ProcessPriorityClass.High : ProcessPriorityClass.Normal;
                                downPriority_button.Enabled = true;
                                upPriority_button.Enabled = true;
                                break;

                            case ProcessPriorityClass.High:
                                currentProc.PriorityClass = increase ? ProcessPriorityClass.RealTime : ProcessPriorityClass.AboveNormal;
                                upPriority_button.Enabled = false;
                                downPriority_button.Enabled = true;
                                break;

                            case ProcessPriorityClass.RealTime:
                                // RealTime є найвищим пріоритетом, його не можна збільшити
                                break;

                            default:
                                upPriority_button.Enabled = true;
                                downPriority_button.Enabled = true;
                                break;
                        }

                        // Оновити рядок у DataGridView
                        UpdateRowInDataGridView(currentProc);
                    }
                    else
                    {
                        MessageBox.Show("Неможливо отримати ідентифікатор процесу.");
                    }
                }

                else
                {
                    MessageBox.Show("Виберіть рядок для зміни пріоритету.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Помилка при зміні пріорітету: {ex.Message}");
            }

        }

    }
}