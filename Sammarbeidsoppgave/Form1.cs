using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sammarbeidsoppgave
{
    public partial class Form1 : Form
    {
        //Kasper
        public Form1()
        {
            InitializeComponent();
            AddMenuItems();
            AddGameItems();
            ResetGame();
        }

        //Thomas
        Point location = Point.Empty;
        PictureBox moving;

        Bricks icons = new Bricks();

        //Kasper
        Panel menuPanel = new Panel();
        Panel questPanel = new Panel();
        PictureBox player = new PictureBox();
        PictureBox door1 = new PictureBox();
        PictureBox door2 = new PictureBox();
        PictureBox door3 = new PictureBox();
        PictureBox doorQuit = new PictureBox();

        PictureBox picture1 = new PictureBox();
        PictureBox picture2 = new PictureBox();
        PictureBox picture3 = new PictureBox();
        PictureBox picture4 = new PictureBox();
        PictureBox pictureNull1 = new PictureBox();
        PictureBox pictureNull2 = new PictureBox();
        PictureBox pictureAnswer = new PictureBox();

        PictureBox[] menuItems = new PictureBox[5];
        PictureBox[] gameItems = new PictureBox[7];

        bool moveRight = false;
        bool moveLeft = false;
        int speed = 3;
        

        //Kasper & Thomas
        private void ResetGame ()
        {
            //sette spillet til startområdet hvor den også resetter classene som trenger det
            //Brukes til startup og når man er ferdig med å spille en runde
            questPanel.MouseDown += Form1_MouseDown;
            questPanel.MouseMove += Form1_MouseMove;
            questPanel.MouseUp += Form1_MouseMove;

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuPanel.Controls.Add(menuItems[i]);

            }

            for (int i = 0; i < gameItems.Length; i++)
            {
                questPanel.Controls.Add(gameItems[i]);
                gameItems[i].MouseDown += Form1_MouseDown;
                gameItems[i].MouseMove += Form1_MouseMove;
                gameItems[i].MouseUp += Form1_MouseUp;
            }
        }

        //Kasper
        private void AddMenuItems()
        {
            this.Size = new Size(1300, 763);
            this.BackColor = Color.Black;

            menuPanel.Size = new Size(1280, 720);
            this.Controls.Add(menuPanel);
            menuPanel.Location = new Point(2, 2);
            menuPanel.Visible = true;
            menuPanel.BackColor = Color.White;
            
            menuItems[0] = player;
            player.Location = new Point(10, 575);
            player.Size = new Size(75, 135);
            player.BackColor = Color.Lime;
            player.Image = new Bitmap(Sammarbeidsoppgave.Properties.Resources.player);
            
            menuItems[1] = door1;
            door1.Location = new Point(500, 200);
            door1.Size = new Size(100, 180);
            door1.BackColor = Color.Brown;
            door1.Image = new Bitmap(Sammarbeidsoppgave.Properties.Resources.door);

            menuItems[2] = door2;
            door2.Location = new Point(700, 300);
            door2.Size = new Size(100, 180);
            door2.BackColor = Color.Brown;
            door2.Image = new Bitmap(Sammarbeidsoppgave.Properties.Resources.door);

            menuItems[3] = door3;
            door3.Location = new Point(500, 500);
            door3.Size = new Size(100, 180);
            door3.BackColor = Color.Brown;
            door3.Image = new Bitmap(Sammarbeidsoppgave.Properties.Resources.door);

            menuItems[4] = doorQuit;
            doorQuit.Location = new Point(50, 150);
            doorQuit.Size = new Size(100, 180);
            doorQuit.BackColor = Color.Brown;
            doorQuit.Image = new Bitmap(Sammarbeidsoppgave.Properties.Resources.doorQuit);
        }

        //Kasper
        private void AddGameItems()
        {
            questPanel.Size = new Size(1280, 720);
            this.Controls.Add(questPanel);
            questPanel.Visible = false;

            gameItems[0] = picture1;
            picture1.Location = new Point(1000, 10);
            picture1.Size = new Size(180, 100);
            picture1.BackColor = Color.RoyalBlue;
            picture1.Image = new Bitmap(icons.Pictures[0]);

            gameItems[1] = picture2;
            picture2.Location = new Point(1000, 130);
            picture2.Size = new Size(180, 100);
            picture2.BackColor = Color.RoyalBlue;
            picture2.Image = new Bitmap(icons.Pictures[1]);

            gameItems[2] = picture3;
            picture3.Location = new Point(1000, 250);
            picture3.Size = new Size(180, 100);
            picture3.BackColor = Color.RoyalBlue;
            picture3.Image = new Bitmap(icons.Pictures[2]);

            gameItems[3] = picture4;
            picture4.Location = new Point(1000, 370);
            picture4.Size = new Size(180, 100);
            picture4.BackColor = Color.RoyalBlue;
            picture4.Image = new Bitmap(icons.Pictures[3]);

            gameItems[4] = pictureNull1;
            pictureNull1.Location = new Point(1000, 490);
            pictureNull1.Size = new Size(180, 100);
            pictureNull1.BackColor = Color.Tomato;

            gameItems[5] = pictureNull2;
            pictureNull2.Location = new Point(1000, 610);
            pictureNull2.Size = new Size(180, 100);
            pictureNull2.BackColor = Color.Tomato;

            gameItems[6] = pictureAnswer;
            pictureAnswer.Location = new Point(700, 610);
            pictureAnswer.Size = new Size(180, 100);
            pictureAnswer.BackColor = Color.Tomato;
            picture4.Image = new Bitmap(icons.Questions[icons.Difficulty,icons.QuestionLvL]);
        }

        //Kasper
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: moveLeft = true; break;
                case Keys.Right: moveRight = true; break;
            }

            if (moveLeft || moveRight)
                movementTimer.Start();
        }

        //Kasper
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: moveLeft = false; break;
                case Keys.Right: moveRight = false; break;
            }

            if (!(moveLeft || moveRight))
                movementTimer.Stop();
        }

        //Kasper
        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (Collision() == false)
            {
                Movement();
            }
        }

        private void Movement()
        {
            if (moveLeft)
            {
                player.Location = new Point(player.Location.X - speed, player.Location.Y);
            }
            if (moveRight)
            {
                player.Location = new Point(player.Location.X + speed, player.Location.Y);
            }
        }

        private bool Collision()
        {
            if ((player.Bounds.IntersectsWith(door1.Bounds)) ||
                (player.Bounds.IntersectsWith(door2.Bounds)) ||
                (player.Bounds.IntersectsWith(door3.Bounds)) ||
                (player.Bounds.IntersectsWith(doorQuit.Bounds)))
            {
                return true;
            }
            else
                return false;
        }
        }
        
        //Thomas
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //PictureBox pb = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (sender == gameItems[i])
                    {
                        location = new Point(e.X, e.Y);
                        moving = menuItems[i];
                    }
                }
            }
        }

        //Thomas
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = moving.Location;
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                moving.Location = newlocation;
            }
        }

        //Thomas
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (gameItems[i].Name == moving.Name)
                    {
                        gameItems[i] = moving;
                    }
                }
                location = Point.Empty;
                moving = null;
            }
        }
    }
}
