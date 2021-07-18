using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        Graphics grapaper;
        int cellSize = 20;
        private SolidBrush brshBlack = new SolidBrush(Color.Black);
        private SolidBrush brshRed = new SolidBrush(Color.Red);
        int arraySize = 27;
        int[,] gameArray = new int[27, 27];
        int snakeSize ;
        int face;
        int i, j;
        int score;
        int highScore;
        Random rand= new Random();
        public SnakeGame()
        {
            InitializeComponent();
            grapaper = picBxGameZone.CreateGraphics();
            this.KeyPreview = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartGame();
            
        }
        private void StartGame()
        {
            score = 0;
            lblScore.Text = score.ToString();
            snakeSize = 5;
            face = 2;
            for (i = 0; i < arraySize; i++)
                for (j = 0; j < arraySize; j++)
                    gameArray[i, j] = 0;
            for (i = snakeSize; i > 0; i--)
                gameArray[(arraySize - 2) / 2 + i, (arraySize - 2) / 2] = snakeSize - i + 1;
            ThrowBait();

            gameTimer.Interval = 500;
            gameTimer.Start();
        }
       private void picbx_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            for (i = 1; i < arraySize-1; i++)
            {
                for (j = 1; j < arraySize-1; j++)
                {
                    if (gameArray[i, j] > 0)
                        e.Graphics.FillRectangle(brshBlack, (i-1) * cellSize, (j-1) * cellSize, cellSize, cellSize);
                    else if (gameArray[i, j] == -2)
                        e.Graphics.FillRectangle(brshRed, (i - 1) * cellSize, (j - 1) * cellSize, cellSize, cellSize);
                }

            }
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameLogic();
            
        }
        private void gameLogic()
        {

            for (i = 1; i < arraySize-1; i++)
            {
                for (j = 1; j < arraySize-1; j++)
                {
                    if (gameArray[i, j] > 1 && gameArray[i, j] < snakeSize) gameArray[i, j]++;
                    else if (gameArray[i, j] == 1)
                    {
                        
                        int headX, headY;
                        int testCase = TestCase(face, i, j, out headX, out headY);
                        if (testCase > 0)
                        {
                            gameTimer.Stop();
                            MessageBox.Show("Game Over");
                            System.Threading.Thread.Sleep(1000);
                            StartGame();
                        }
                        else if (testCase == -2)
                        {
                            gameTimer.Interval = gameTimer.Interval*95 / 100;
                            ThrowBait();
                            score += 10;
                            lblScore.Text = score.ToString();
                            snakeSize += 1;
                            if (headX > i)
                                gameArray[headX, headY] = -1;
                            else
                                gameArray[headX, headY] = 1;
                            gameArray[i, j]++;
                            if (headY > j) j++;
                        }
                        else
                        {
                            if (headX > i)
                                gameArray[headX, headY] = -1;
                            else
                                gameArray[headX, headY] = 1;
                            gameArray[i, j]++;
                            if (headY > j) j++;


                        }
                        
                    }
                    else if (gameArray[i, j] == -1) gameArray[i, j] = 1;
                    else if (gameArray[i, j] == snakeSize) gameArray[i, j] = 0;




                }

            }
            if (hitborder())
            {
                gameTimer.Stop();
                MessageBox.Show("Game over");
                System.Threading.Thread.Sleep(1000);
                StartGame();

            }
            else this.picBxGameZone.Refresh();


        }
        private bool hitborder()
        {
            
            int x;
            for (x = 1; x <arraySize; x++)
            {
                if (gameArray[x, 0] != 0 || gameArray[0, x] != 0 || gameArray[26, x] != 0 || gameArray[x, 26] != 0)
                
                {
                    return true;

                }
            }
            return false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key  
            switch (keyData)
            {
                case Keys.Left:
                    ChangeDirection(0);
                    break;
                case Keys.Right:
                    ChangeDirection(1);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        
        private void ChangeDirection(int leftOrRight)
        {
            if (leftOrRight == 0)
            {
                switch (face)
                {
                    case 1:
                        face = 4;
                        break;
                    case 2:
                        face = 1;
                        break;
                    case 3:
                        face = 2;
                        break;
                    case 4:
                        face = 3;
                        break;

                }
            }
            else
            {
                switch (face)
                {
                    case 1:
                        face = 2;
                        break;
                    case 2:
                        face = 3;
                        break;
                    case 3:
                        face = 4;
                        break;
                    case 4:
                        face = 1;
                        break;

                }
            }
        }
        private int TestCase(int facing,int i,int j, out int indexX,out int indexY)
        {
            switch (facing){
                case 1:
                    indexX = i;
                    indexY = j - 1;
                    break;
                    
                case 2:
                    indexX = i+1;
                    indexY = j;
                    break;
                case 3:
                    indexX = i;
                    indexY = j + 1;
                    break;
                default:
                    indexX = i - 1;
                    indexY = j;
                    break;

            }
            return gameArray[indexX, indexY];
            

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            MessageBox.Show("USE left <- and Right -> arrow key to move and eat red bait.\n\nLeft and Right are relative to your current direction");
            gameTimer.Start();
        }

        private void ThrowBait()
        {
            gameArray[rand.Next(1, 25), rand.Next(1, 25)] = -2;
        }

    }
}
