using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectCollisionGame
{
    public partial class ObjectCollidingGame : Form
    {

        bool goLeft, goRight,goUp, goDown, shooting, isGameOver;
        int score;
        int killerSpeed = 30;
        int dragonSpeed;
        int bulletSpeed;
        Random rnd = new Random();

        public ObjectCollidingGame()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();

            Dragon1.Top += dragonSpeed;
            Dragon2.Top += dragonSpeed;
            Dragon3.Top += dragonSpeed;


            if ((Dragon1.Top > 530) || (Dragon2.Top > 530) || (Dragon3.Top > 530))
            {
                gameOver();
            }



          
            if(goUp==true && Killer.Top > 0)
            {
                Killer.Top -= killerSpeed;
            }
            if(goDown==true && Killer.Top< 483)
            {
                Killer.Top += killerSpeed;
            }

            if (goLeft == true && Killer.Left > 0)
            {
                Killer.Left -= killerSpeed;
            }
            if (goRight == true && Killer.Left < 728)
            {
                Killer.Left += killerSpeed;
            }
           
            if (shooting == true)
            {
                bulletSpeed = 50;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top <-30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(Dragon1.Bounds))
            {
                score += 1;
                Dragon1.Top = -350;
                Dragon1.Left = rnd.Next(20, 300);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(Dragon2.Bounds))
            {
                score += 1;
                Dragon2.Top = -650;
                Dragon2.Left = rnd.Next(330, 550);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(Dragon3.Bounds))
            {
                score += 1;
                Dragon3.Top = -850;
                Dragon3.Left = rnd.Next(580, 700);
                shooting = false;
            }

            if(Dragon1.Bounds.IntersectsWith(Killer.Bounds) || Dragon2.Bounds.IntersectsWith(Killer.Bounds) || Dragon3.Bounds.IntersectsWith(Killer.Bounds))
            {
                gameOver();
            }

            if (score==5)
            {
                dragonSpeed = 10;
            }
            if ( score ==10)
            {
                dragonSpeed = 15;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting==false)
            {
                shooting = true;

                bullet.Top = Killer.Top - 61;
                bullet.Left = Killer.Left+ 13 + (Killer.Width / 2);

            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            dragonSpeed = 4;

            Dragon1.Left = rnd.Next(20, 730);
            Dragon2.Left = rnd.Next(20, 730);
            Dragon3.Left = rnd.Next(20, 730);

            Dragon1.Top = rnd.Next(0, 180) * -1;
            Dragon2.Top = rnd.Next(200, 500) * -1;
            Dragon3.Top = rnd.Next(520, 800) * -1;

            score = 0;
            bulletSpeed = 0;
          bullet.Left = -300;
           shooting = false;
            txtScore.Text =  score.ToString();
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            shooting = false;
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press Enter to try again.";
        }
    }
}
