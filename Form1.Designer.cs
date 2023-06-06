namespace SearchForbiddenWords
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.TxtFolderPath = new System.Windows.Forms.TextBox();
            this.BtnLoadWords = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.LblProgress = new System.Windows.Forms.Label();
            this.dataGridViewTopWords = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopWords)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnResume
            // 
            this.BtnResume.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResume.Location = new System.Drawing.Point(29, 397);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(116, 32);
            this.BtnResume.TabIndex = 0;
            this.BtnResume.Text = "Возобновить поиск";
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectFolder.Location = new System.Drawing.Point(29, 297);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(167, 37);
            this.BtnSelectFolder.TabIndex = 1;
            this.BtnSelectFolder.Text = "Выбрать ";
            this.BtnSelectFolder.UseVisualStyleBackColor = true;
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click_1);
            // 
            // TxtFolderPath
            // 
            this.TxtFolderPath.Location = new System.Drawing.Point(88, 184);
            this.TxtFolderPath.Name = "TxtFolderPath";
            this.TxtFolderPath.Size = new System.Drawing.Size(142, 20);
            this.TxtFolderPath.TabIndex = 2;
            // 
            // BtnLoadWords
            // 
            this.BtnLoadWords.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadWords.Location = new System.Drawing.Point(217, 297);
            this.BtnLoadWords.Name = "BtnLoadWords";
            this.BtnLoadWords.Size = new System.Drawing.Size(177, 37);
            this.BtnLoadWords.TabIndex = 3;
            this.BtnLoadWords.Text = "Выбрать";
            this.BtnLoadWords.UseVisualStyleBackColor = true;
            this.BtnLoadWords.Click += new System.EventHandler(this.BtnLoadWords_Click);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(164, 150);
            this.dataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Искомые слова";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(29, 340);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(365, 37);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Cтарт";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(249, 181);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(201, 23);
            this.progressBar.TabIndex = 6;
            // 
            // BtnPause
            // 
            this.BtnPause.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.Location = new System.Drawing.Point(164, 397);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(102, 32);
            this.BtnPause.TabIndex = 7;
            this.BtnPause.Text = "пауза";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(284, 397);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(98, 32);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "Стоп";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // dataGridViewResults
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewResults.Location = new System.Drawing.Point(195, 12);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.Size = new System.Drawing.Size(429, 150);
            this.dataGridViewResults.TabIndex = 9;
            // 
            // LblProgress
            // 
            this.LblProgress.AutoSize = true;
            this.LblProgress.Location = new System.Drawing.Point(196, 227);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(0, 13);
            this.LblProgress.TabIndex = 10;
            // 
            // dataGridViewTopWords
            // 
            this.dataGridViewTopWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewTopWords.Location = new System.Drawing.Point(473, 168);
            this.dataGridViewTopWords.Name = "dataGridViewTopWords";
            this.dataGridViewTopWords.RowHeadersVisible = false;
            this.dataGridViewTopWords.Size = new System.Drawing.Size(164, 220);
            this.dataGridViewTopWords.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 300F;
            this.dataGridViewTextBoxColumn1.HeaderText = "TOP 10 слов";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "       Выберите файл \r\nс запрещенными словами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = " Выберите папку\r\n где будем искать";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ищем в";
            // 
            // Column2
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "Имя файла";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Количество совпадений";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column4.HeaderText = "Путь к файлу";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTopWords);
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BtnLoadWords);
            this.Controls.Add(this.TxtFolderPath);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.BtnResume);
            this.Name = "Form1";
            this.Text = "добавить папку";
         
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnSelectFolder;
        private System.Windows.Forms.TextBox TxtFolderPath;
        private System.Windows.Forms.Button BtnLoadWords;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.DataGridView dataGridViewTopWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

