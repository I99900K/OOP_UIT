using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components.Object;

namespace Components
{
    public partial class GameManager : UserControl
    {
        #region Attributes
        private Manager gManager = Manager.GetInstance();
        private Dice dice = Dice.GetInstance(); //dice will be used to return random number where the obstacles will be spawned
        #endregion

        public GameManager()
        {
            InitializeComponent();
            ResetGame();
        }

        private void GameEvent(object sender, EventArgs e)
        {
            catPic.Top += gManager.JumpSpeed;

            txtScore.Text = $"Score: {gManager.Score}";
            txtState.Text = $"State:\n{gManager.Cat.State.ToString()}";
            txtRatio.Text = $"Score Ratio: +{gManager.PointsRatio}";

            gManager.PlayGame();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag is "barrier")
                {
                    control.Left -= Convert.ToInt32(gManager.ObstacleSpeed);

                    if (control.Left + control.Width < -120)
                    {
                        control.Left = this.ClientSize.Width + dice.Next(200, 800);
                        gManager.CalculateScore();
                    }

                    if (catPic.Bounds.IntersectsWith(control.Bounds))
                    {
                        gameTimer.Stop();
                        catPic.Image = Properties.Resources.dead;
                        txtRestart.Visible = true;
                    }
                }
            }

            if (catPic.Top >= 380 && !gManager.Jump)
            {
                gManager.Force = gManager.Cat.CalculateForce();
                catPic.Top = floor.Top - catPic.Height;
                gManager.JumpSpeed = 0;
            }


            if (gManager.Score >= gManager.DifficultManager)
            {
                gManager.ObstacleSpeed *= gManager.Difficult;
                gManager.DifficultManager += 10;
                gManager.ChangeState();
            }
        }

        //Event Handler for the down key
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gManager.Jump)
            {
                gManager.Jump = true;
            }
        }

        //Event Handler for the up key
        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (gManager.Jump)
            {
                gManager.Jump = false;
            }
        }
        private void ResetGame()
        {
            gManager.ResetGame();

            catPic.Top = floor.Top - catPic.Height;
            catPic.Image = Properties.Resources.run;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag is "barrier")
                {
                    int position = dice.Next(600, 1000);

                    control.Left = 640 + (control.Left + position + control.Width * 3);
                }
            }

            txtRestart.Visible = false;
            gameTimer.Start();
        }

    }
}
