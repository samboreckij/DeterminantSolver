namespace DeterninantTest
{
    partial class MainForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.dimNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textInputLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.detParallelLabel = new System.Windows.Forms.Label();
            this.directCompTimeLabel = new System.Windows.Forms.Label();
            this.detParallelTextBox = new System.Windows.Forms.TextBox();
            this.directCompTimeTextBox = new System.Windows.Forms.TextBox();
            this.formMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detDirectTextBox = new System.Windows.Forms.TextBox();
            this.detDirectLabel = new System.Windows.Forms.Label();
            this.parallelCompTimeTextBox = new System.Windows.Forms.TextBox();
            this.parallelCompTimeLabel = new System.Windows.Forms.Label();
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.directDetBW = new System.ComponentModel.BackgroundWorker();
            this.parallelDetBW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dimNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.formMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(12, 165);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(607, 91);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Расчитать";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dimNumericUpDown
            // 
            this.dimNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimNumericUpDown.Location = new System.Drawing.Point(12, 79);
            this.dimNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dimNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimNumericUpDown.Name = "dimNumericUpDown";
            this.dimNumericUpDown.Size = new System.Drawing.Size(607, 53);
            this.dimNumericUpDown.TabIndex = 4;
            this.dimNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dimNumericUpDown.ValueChanged += new System.EventHandler(this.dimNumericUpDown_ValueChanged);
            // 
            // textInputLabel
            // 
            this.textInputLabel.AutoSize = true;
            this.textInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInputLabel.Location = new System.Drawing.Point(12, 0);
            this.textInputLabel.Name = "textInputLabel";
            this.textInputLabel.Size = new System.Drawing.Size(607, 46);
            this.textInputLabel.TabIndex = 3;
            this.textInputLabel.Text = "Задайте размерность матрицы";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.parallelCompTimeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.parallelCompTimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.detDirectTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.detDirectLabel);
            this.splitContainer1.Panel1.Controls.Add(this.directCompTimeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.detParallelTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.directCompTimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.detParallelLabel);
            this.splitContainer1.Panel1.Controls.Add(this.textInputLabel);
            this.splitContainer1.Panel1.Controls.Add(this.okButton);
            this.splitContainer1.Panel1.Controls.Add(this.dimNumericUpDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.matrixView);
            this.splitContainer1.Size = new System.Drawing.Size(2111, 1162);
            this.splitContainer1.SplitterDistance = 703;
            this.splitContainer1.TabIndex = 6;
            // 
            // detParallelLabel
            // 
            this.detParallelLabel.AutoSize = true;
            this.detParallelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detParallelLabel.Location = new System.Drawing.Point(12, 605);
            this.detParallelLabel.Name = "detParallelLabel";
            this.detParallelLabel.Size = new System.Drawing.Size(525, 46);
            this.detParallelLabel.TabIndex = 7;
            this.detParallelLabel.Text = "Определитель (... потоков)";
            // 
            // directCompTimeLabel
            // 
            this.directCompTimeLabel.AutoSize = true;
            this.directCompTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directCompTimeLabel.Location = new System.Drawing.Point(12, 432);
            this.directCompTimeLabel.Name = "directCompTimeLabel";
            this.directCompTimeLabel.Size = new System.Drawing.Size(463, 46);
            this.directCompTimeLabel.TabIndex = 8;
            this.directCompTimeLabel.Text = "Время, мс (один поток)";
            // 
            // detParallelTextBox
            // 
            this.detParallelTextBox.Location = new System.Drawing.Point(12, 684);
            this.detParallelTextBox.Name = "detParallelTextBox";
            this.detParallelTextBox.Size = new System.Drawing.Size(607, 61);
            this.detParallelTextBox.TabIndex = 9;
            // 
            // directCompTimeTextBox
            // 
            this.directCompTimeTextBox.Location = new System.Drawing.Point(12, 511);
            this.directCompTimeTextBox.Name = "directCompTimeTextBox";
            this.directCompTimeTextBox.Size = new System.Drawing.Size(607, 61);
            this.directCompTimeTextBox.TabIndex = 10;
            // 
            // formMenuStrip
            // 
            this.formMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMenuStrip.Name = "formMenuStrip";
            this.formMenuStrip.Size = new System.Drawing.Size(2111, 49);
            this.formMenuStrip.TabIndex = 7;
            this.formMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(100, 45);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(339, 46);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // detDirectTextBox
            // 
            this.detDirectTextBox.Location = new System.Drawing.Point(12, 338);
            this.detDirectTextBox.Name = "detDirectTextBox";
            this.detDirectTextBox.Size = new System.Drawing.Size(607, 61);
            this.detDirectTextBox.TabIndex = 12;
            // 
            // detDirectLabel
            // 
            this.detDirectLabel.AutoSize = true;
            this.detDirectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detDirectLabel.Location = new System.Drawing.Point(12, 259);
            this.detDirectLabel.Name = "detDirectLabel";
            this.detDirectLabel.Size = new System.Drawing.Size(540, 46);
            this.detDirectLabel.TabIndex = 11;
            this.detDirectLabel.Text = "Определитель (один поток)";
            // 
            // parallelCompTimeTextBox
            // 
            this.parallelCompTimeTextBox.Location = new System.Drawing.Point(12, 857);
            this.parallelCompTimeTextBox.Name = "parallelCompTimeTextBox";
            this.parallelCompTimeTextBox.Size = new System.Drawing.Size(607, 61);
            this.parallelCompTimeTextBox.TabIndex = 14;
            // 
            // parallelCompTimeLabel
            // 
            this.parallelCompTimeLabel.AutoSize = true;
            this.parallelCompTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parallelCompTimeLabel.Location = new System.Drawing.Point(12, 778);
            this.parallelCompTimeLabel.Name = "parallelCompTimeLabel";
            this.parallelCompTimeLabel.Size = new System.Drawing.Size(448, 46);
            this.parallelCompTimeLabel.TabIndex = 13;
            this.parallelCompTimeLabel.Text = "Время, мс (... потоков)";
            // 
            // matrixView
            // 
            this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixView.Location = new System.Drawing.Point(0, 0);
            this.matrixView.Name = "matrixView";
            this.matrixView.RowTemplate.Height = 40;
            this.matrixView.Size = new System.Drawing.Size(1404, 1162);
            this.matrixView.TabIndex = 15;
            // 
            // directDetBW
            // 
            this.directDetBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.directDetBW_DoWork);
            this.directDetBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.directDetBW_RunWorkerCompleted);
            // 
            // parallelDetBW
            // 
            this.parallelDetBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parallelDetBW_DoWork);
            this.parallelDetBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.parallelDetBW_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2111, 1211);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.formMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.formMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeterminantTest @ Samboretskiy S.S.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dimNumericUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.formMenuStrip.ResumeLayout(false);
            this.formMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown dimNumericUpDown;
        private System.Windows.Forms.Label textInputLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox directCompTimeTextBox;
        private System.Windows.Forms.TextBox detParallelTextBox;
        private System.Windows.Forms.Label directCompTimeLabel;
        private System.Windows.Forms.Label detParallelLabel;
        private System.Windows.Forms.TextBox detDirectTextBox;
        private System.Windows.Forms.Label detDirectLabel;
        private System.Windows.Forms.MenuStrip formMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox parallelCompTimeTextBox;
        private System.Windows.Forms.Label parallelCompTimeLabel;
        private System.Windows.Forms.DataGridView matrixView;
        private System.ComponentModel.BackgroundWorker directDetBW;
        private System.ComponentModel.BackgroundWorker parallelDetBW;
    }
}

