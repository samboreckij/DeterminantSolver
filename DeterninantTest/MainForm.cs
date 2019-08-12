using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixOperations;

namespace DeterninantTest
{
    public partial class MainForm : Form
    {
        public Matrix MyMatrix;
        public bool isDimensionChanged = true;
        public int numberOfProcessors = Environment.ProcessorCount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parallelCompTimeLabel.Text = "Время, мс (" + numberOfProcessors.ToString() + " потоков)";
            detParallelLabel.Text = "Определитель (" + numberOfProcessors.ToString() + " потоков)";
        }

        private void Matrix_View()
        {
            matrixView.ColumnCount = StaticData.Dimension;
            matrixView.RowCount = StaticData.Dimension;
            for (int i = 0; i < StaticData.Dimension; i++)
                for (int j = 0; j < StaticData.Dimension; j++)
                    matrixView[i, j].Value = MyMatrix[i + 1, j + 1];
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (isDimensionChanged)
            {
                StaticData.Dimension = Convert.ToInt32(dimNumericUpDown.Value);
                MyMatrix = new Matrix(StaticData.GenerateMatrix());
            }
            Matrix_View();
            detDirectTextBox.Text = "Wait...";
            detParallelTextBox.Text = "Wait...";
            directCompTimeTextBox.Text = "Wait...";
            parallelCompTimeTextBox.Text = "Wait...";
            directDetBW.RunWorkerAsync();
            parallelDetBW.RunWorkerAsync();
            okButton.Text = "Пересчитать";
            isDimensionChanged = false;
        }

        private void dimNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            okButton.Text = "Расчитать";
            isDimensionChanged = true;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox_Samboretskiy about = new AboutBox_Samboretskiy();
            about.Show();
        }

        private void directDetBW_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double det = MyMatrix.Determinant();
            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            e.Result = new Tuple<double, string>(det, time);
        }

        private void parallelDetBW_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double det = MyMatrix.DeterminantP();
            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();
            e.Result = new Tuple<double, string>(det, time);
        }

        private void directDetBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<double, string> res = e.Result as Tuple<double, string>;
            this.detDirectTextBox.Text = res.Item1.ToString();
            this.directCompTimeTextBox.Text = res.Item2;
        }

        private void parallelDetBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tuple<double, string> res = e.Result as Tuple<double, string>;
            this.detParallelTextBox.Text = res.Item1.ToString();
            this.parallelCompTimeTextBox.Text = res.Item2;
        }
    }
}
