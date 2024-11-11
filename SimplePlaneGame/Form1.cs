namespace SimplePlaneGame
{
    public partial class Form1 : Form
    {
       /* Deklarasikan Variabel */ 
        private bool isGameOver = false;
        private int planeSpeed = 20;
        private int asteroidSpeed = 10;
        private int score = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            /* Setup Component */ 
            btnStart.Visible = true;
            planePic.Visible = false;
            asteroidPic.Visible = false;

            labelScore.Text = "Score: " + score;

            KeyPreview = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            asteroidPic.Top += asteroidSpeed;

            if(asteroidPic.Top > this.ClientSize.Height)
            {
                asteroidPic.Top = -asteroidPic.Height;
                asteroidPic.Left = random.Next(0, this.ClientSize.Width - asteroidPic.Width);
                score++;
                labelScore.Text = "Score: " + score;
            }

            if (planePic.Bounds.IntersectsWith(asteroidPic.Bounds))
            {
                gameOver();
            }

            if (score >= 15)
            {
                asteroidSpeed = 15;
            }
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                if (e.KeyCode == Keys.Left && planePic.Left > 0)
                {
                    planePic.Left -= planeSpeed;
                }
                else if (e.KeyCode == Keys.Right && planePic.Right < this.ClientSize.Width)
                {
                    planePic.Left += planeSpeed;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* Jalankan Fungsi Start */
            startGame();
        }

        private void startGame()
        {
            isGameOver = false;
            btnStart.Visible = false;

            score = 0;
            labelScore.Text = "Score: " + score;

            planePic.Visible = true;
            planePic.Left = this.ClientSize.Width / 2 - planePic.Width / 2;
/*            planePic.Top = this.ClientSize.Height / 2 - planePic.Height / 2;
*/
            asteroidPic.Visible = true;
            asteroidPic.Top = -asteroidPic.Height;
            asteroidPic.Left = random.Next(0, this.ClientSize.Width - asteroidPic.Width);

            gameTimer.Start();
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            MessageBox.Show("Mampus nabrak. Cuma dapet score: " + score);
            btnStart.Visible = true;
            planePic.Visible = false;
            asteroidPic.Visible = false;
        }
    }
}
