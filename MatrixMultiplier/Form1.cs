using System.ComponentModel;

namespace MatrixMultiplier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelDone.Visible = false;
            backgroundWorker.RunWorkerAsync();
        }

        public static int[,] GenerateRandomMatrix(int n)
        {
            // Create a new random number generator.
            Random random = new Random();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next();
                }
            }

            return matrix;
        }
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int[,] A = GenerateRandomMatrix(1000);
            int[,] B = GenerateRandomMatrix(1000);
            int percentage = 0;
            int index = 0;

            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);

            if (cA != rB)
            {
                MessageBox.Show("Matrixes can't be multiplied!!");
            }
            else
            {
                int temp = 0;
                int[,] kHasil = new int[rA, cB];

                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        kHasil[i, j] = temp;
                        index++;
                        percentage = (index) * 100 / (rA * cB);
                        backgroundWorker.ReportProgress(percentage);
                    }
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelDone.Visible = true;
        }
    }
}