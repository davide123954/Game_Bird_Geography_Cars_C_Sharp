using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Cars : Form
    {
        int _tick;
        public Cars()
        {
            InitializeComponent();
           // lblGameOver.Visible = false; //only if is gameover is visible
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cars_KeyDown(object sender, KeyEventArgs e)
        {
           //this function give the command how to play (with the Arrows-Keys-חצים)
            
                if (e.KeyCode == Keys.Left)
                {
                    if (pictureBox8.Left > 0)
                        pictureBox8.Left += -8;//the maximum moviment of the car at the street at side left
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (pictureBox8.Right < 657)
                        pictureBox8.Left += 8;//the maximum moviment of the car at the street at side right
                }
                if (e.KeyCode == Keys.Up)//the movement are more fast
                    if (gamespeed < 21)
                    { gamespeed++; }
                if (e.KeyCode == Keys.Down)//slown down moovement
                    if (gamespeed > 0)
                    { gamespeed--; }
            

        }

        private void Cars_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);//line of street
            enemy(gamespeed);//speed of the 3 cars obstacle
            gameover();//when the car touch one of the 3 enemy(cars obstacles)
            coints(gamespeed);//the moneys change place evry time cars moving
            coinscollection();//count the money when car touch the money
        }
        int collectioncoints = 0;//count of the money
        Random r = new Random();
        int x;
        void enemy(int speed)//this function is for moving in the street the 3 cars obstacles(enemy1,2,3)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
        }
        void coints(int speed)//this function is very similar to the enemy function.here we get the money in differnte place
        {
            if (coint1.Top >= 500)
            {
                x = r.Next(0, 100);
                coint1.Location = new Point(x, 0);
            }
            else { coint1.Top += speed; }
            if (coint2.Top >= 500)
            {
                x = r.Next(0, 200);
                coint2.Location = new Point(x, 0);
            }
            else { coint2.Top += speed; }
            if (coint3.Top >= 500)
            {
                x = r.Next(0, 300);
                coint3.Location = new Point(x, 0);
            }
            else { coint3.Top += speed; }
        }
        void gameover()//we decide to stop the game only when the user is touching one of the enemy,and we can see the game are stoped
        {
            if (pictureBox8.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                _tick++;
                timer2.Start();
                this.Text = _tick.ToString();
                //lblGameOver.Visible = true;
            }
            if (pictureBox8.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                _tick++;
                timer2.Start();
                this.Text = _tick.ToString();
                //  lblGameOver.Visible = true;
            }
            if (pictureBox8.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                _tick++;
                timer2.Start();
                this.Text = _tick.ToString();
                // lblGameOver.Visible = true;
            }
        }
        void moveLine(int speed)//how the lines of the street are mooving and come back to create a demo street
        {
            if (pictureBox1.Top >= 500) { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }
            if (pictureBox2.Top >= 500) { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }
            if (pictureBox3.Top >= 500) { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }
            if (pictureBox4.Top >= 500) { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }
        }
        void coinscollection()//this function give the possibility to count the money and to see how much money the player get in the game
        {
            if (pictureBox8.Bounds.IntersectsWith(coint1.Bounds))
            {
                collectioncoints++;
                lblPoint.Text = collectioncoints.ToString();//with this we can see the money of the player
                x = r.Next(50, 300);
                coint1.Location = new Point(x, 0);
            }
            if (pictureBox8.Bounds.IntersectsWith(coint2.Bounds))
            {
                collectioncoints++;
                lblPoint.Text = collectioncoints.ToString();
                x = r.Next(50, 300);
                coint2.Location = new Point(x, 0);
            }
            if (pictureBox8.Bounds.IntersectsWith(coint3.Bounds))
            {
                collectioncoints++;
                lblPoint.Text = collectioncoints.ToString();
                x = r.Next(50, 300);
                coint3.Location = new Point(x, 0);
            }
        }
        int gamespeed = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            _tick++;
            if (_tick == 4)
            {
                this.Text = "Done-Game Over";
                MessageBox.Show("Game Over For Alona !!", "Cars Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 m = new Form1();
                m.ShowDialog();
                timer2.Stop();
            }
        }
    }
}
