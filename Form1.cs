using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForbiddenWords
{
    public partial class Form1 : Form
    {
        private List<string> forbiddenWords;
        private string tempFolderPath;
        private int totalFilesCount;
        private int processedFilesCount;
        private bool isPaused;
        private object lockObject = new object();

        public Form1()
        {
            InitializeComponent();
           
            forbiddenWords = new  List<string>();
            BtnResume.Enabled = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
        }
       

       

        private void BtnSelectFolder_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    TxtFolderPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void BtnLoadWords_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.RestoreDirectory = true;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    try
                    {
                        string text = File.ReadAllText(dialog.FileName);
                        List<string> words = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        forbiddenWords = words;
                        dataGridView.Rows.Clear();
                        foreach (string word in words)
                        {
                            dataGridView.Rows.Add(word);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                    }
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFolderPath.Text))
            {
                MessageBox.Show("Выберите папку для поиска файлов.");
                return;
            }

            if (forbiddenWords == null || forbiddenWords.Count == 0)
            {
                MessageBox.Show("Пожалуйста, загрузите список запрещенных слов.");
                return;
            }

            tempFolderPath = Path.Combine(Path.GetTempPath(), "ForbiddenWordsSearch");
            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }

            totalFilesCount = 0;
            processedFilesCount = 0;
            isPaused = false;

            progressBar.Value = 0;
            BtnPause.Enabled = true;
            BtnStop.Enabled = true;
            BtnStart.Enabled = false;
            BtnSelectFolder.Enabled = false;
            BtnLoadWords.Enabled = false;

            ThreadPool.QueueUserWorkItem(new WaitCallback(SearchForForbiddenWords), TxtFolderPath.Text);
        }


        private void SearchForForbiddenWords(object folderPathObj)
        {
            string folderPath = (string)folderPathObj;
            List<string> files = GetFiles(folderPath);
            totalFilesCount = files.Count;

            Parallel.ForEach(files, file =>
            {
                if (isPaused)
                {
                    while (isPaused)
                    {
                        Thread.Sleep(1000);
                    }
                }
                AnalyzeFile(file);
            });
        }


        private List<string> GetFiles(string folderPath)
        {
            List<string> files = new List<string>();
            try
            {
                files.AddRange(Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения файлов: {ex.Message}");
            }
            return files;
        }


        private void AnalyzeFile(object fileObj)
        {
            string file = (string)fileObj;
            int count = CountWordsOccurrences(file, forbiddenWords);
            if (count > 0)
            {
                string fileName = Path.GetFileName(file);
                string fileCopy = Path.Combine(tempFolderPath, "Copy_" + fileName);
                try
                {
                    string content = File.ReadAllText(file);
                    foreach (string word in forbiddenWords)
                    {
                        content = Regex.Replace(content, word, "***", RegexOptions.IgnoreCase);
                    }
                    File.WriteAllText(fileCopy, content);
                    lock (lockObject)
                    {
                        processedFilesCount++;
                    }
                    UpdateUI(file, count, fileCopy);
                }
                catch (UnauthorizedAccessException)
                {
                    // игнорировать недоступные файлы
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка анализа файла: {ex.Message}");
                }
            }
            lock (lockObject)
            {
                processedFilesCount++;
            }
            UpdateProgress();
        }


        private int CountWordsOccurrences(string file, List<string> words)
        {
            int count = 0;
            try
            {
                string content = File.ReadAllText(file);
                Parallel.ForEach(words, word =>
                {
                    count += Regex.Matches(content, word, RegexOptions.IgnoreCase).Count;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подсчета слов: {ex.Message}");
            }
            return count;
        }

        private void UpdateUI(string file, int count, string fileCopy)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateUI(file, count, fileCopy)));
                return;
            }
            // Создаем новую строку для таблицы и заполняем ее данными
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridViewResults);
            newRow.Cells[0].Value = Path.GetFileName(file);
            newRow.Cells[1].Value = count;
            newRow.Cells[2].Value = fileCopy;
            // Добавляем новую строку в таблицу
            dataGridViewResults.Rows.Add(newRow);
        }

        private void CalculateTopForbiddenWords()
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string word in forbiddenWords)
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridViewResults.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string fileName = row.Cells[0].Value.ToString();
                        int occurrences = int.Parse(row.Cells[1].Value.ToString());
                        if (fileName.Contains(word))
                        {
                            count += occurrences;
                        }
                    }
                }
                wordsCount.Add(word, count);
            }

            var topWords = wordsCount.OrderByDescending(x => x.Value).Take(10);
            dataGridViewTopWords.Rows.Clear();
            foreach (var pair in topWords)
            {
                dataGridViewTopWords.Rows.Add(pair.Key, pair.Value);
            }
        }


        private void UpdateProgress()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateProgress()));
                return;
            }
            int progressPercentage = (int)((float)processedFilesCount / totalFilesCount * 100);
            progressBar.Value = progressPercentage;
            LblProgress.Text = $"Обработанный {processedFilesCount} из {totalFilesCount} файла";
            if (progressPercentage == 100)
            {
                MessageBox.Show("Анализ файлов завершен!");
                CalculateTopForbiddenWords();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            isPaused = false;
            BtnPause.Enabled = false;
            BtnResume.Enabled = false;
            BtnStop.Enabled = false;
            BtnStart.Enabled = true;
            BtnSelectFolder.Enabled = true;
            BtnLoadWords.Enabled = true;
            dataGridViewResults.Rows.Clear();
            dataGridViewTopWords.Rows.Clear();
            progressBar.Value = 0;
            LblProgress.Text = "Готов к работе";
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            BtnPause.Enabled = false;
            BtnResume.Enabled = true;
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            isPaused = false;
            BtnPause.Enabled = true;
            BtnResume.Enabled = false;
        }

      
    }
}

