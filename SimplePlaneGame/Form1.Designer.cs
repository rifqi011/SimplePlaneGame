namespace SimplePlaneGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            planePic = new PictureBox();
            asteroidPic = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            labelScore = new Label();
            ((System.ComponentModel.ISupportInitialize)planePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asteroidPic).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.AutoSize = true;
            btnStart.BackColor = SystemColors.ControlDark;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Segoe UI", 12F);
            btnStart.Location = new Point(173, 264);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 42);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // planePic
            // 
            planePic.Image = (Image)resources.GetObject("planePic.Image");
            planePic.Location = new Point(173, 509);
            planePic.Name = "planePic";
            planePic.Size = new Size(93, 96);
            planePic.SizeMode = PictureBoxSizeMode.Zoom;
            planePic.TabIndex = 1;
            planePic.TabStop = false;
            // 
            // asteroidPic
            // 
            asteroidPic.Image = (Image)resources.GetObject("asteroidPic.Image");
            asteroidPic.Location = new Point(238, 12);
            asteroidPic.Name = "asteroidPic";
            asteroidPic.Size = new Size(91, 86);
            asteroidPic.SizeMode = PictureBoxSizeMode.Zoom;
            asteroidPic.TabIndex = 2;
            asteroidPic.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 610);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 3;
            label1.Text = "Rifqi yang bikin, rill";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(391, 610);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(75, 25);
            labelScore.TabIndex = 4;
            labelScore.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 644);
            Controls.Add(labelScore);
            Controls.Add(label1);
            Controls.Add(asteroidPic);
            Controls.Add(planePic);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Plane Game";
            KeyDown += Form1_Keydown;
            ((System.ComponentModel.ISupportInitialize)planePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)asteroidPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox planePic;
        private PictureBox asteroidPic;
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private Label labelScore;
    }
}
