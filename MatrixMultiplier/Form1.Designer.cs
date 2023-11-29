namespace MatrixMultiplier
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
            progressBar = new ProgressBar();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            buttonStart = new Button();
            labelDone = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.FromArgb(128, 255, 128);
            progressBar.Location = new Point(12, 12);
            progressBar.MarqueeAnimationSpeed = 1;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 58);
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Top;
            buttonStart.Location = new Point(305, 76);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(188, 58);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelDone
            // 
            labelDone.AutoSize = true;
            labelDone.Location = new Point(12, 85);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(99, 41);
            labelDone.TabIndex = 2;
            labelDone.Text = "Done!";
            labelDone.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDone);
            Controls.Add(buttonStart);
            Controls.Add(progressBar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Button buttonStart;
        private Label labelDone;
    }
}