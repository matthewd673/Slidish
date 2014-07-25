using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slidish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox cube;
        int score = 0;
        int speed = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            spawnCube();
            timer1.Start();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Right)
            {

                r.Location = new Point(r.Location.X + 7, r.Location.Y);
                g.Location = new Point(g.Location.X + 7, g.Location.Y);
                y.Location = new Point(y.Location.X + 7, y.Location.Y);
                b.Location = new Point(b.Location.X + 7, b.Location.Y);

            }
            else if(e.KeyCode == Keys.Left)
            {

                r.Location = new Point(r.Location.X - 7, r.Location.Y);
                g.Location = new Point(g.Location.X - 7, g.Location.Y);
                y.Location = new Point(y.Location.X - 7, y.Location.Y);
                b.Location = new Point(b.Location.X - 7, b.Location.Y);

            }

        }

        

        void spawnCube()
        {

            Random bckcolor = new Random();
            cube = new PictureBox();
            cube.Width = 50;
            cube.Height = 50;
            int cubecolor = bckcolor.Next(4);

            switch (cubecolor)
            {
                case 1:
                    cube.BackColor = Color.Red;
                    break;
                case 2:
                    cube.BackColor = Color.Lime;
                    break;
                case 3:
                    cube.BackColor = Color.Yellow;
                    break;
                case 4:
                    cube.BackColor = Color.Teal;
                    break;
                default:
                    cube.BackColor = Color.White;
                    break;
            }

            Random cubex = new Random();
            int x = cubex.Next(0, this.Width);

            cube.Location = new Point(x, 0);

            this.Controls.Add(cube);

            cube.Move += new EventHandler(cubeMove);

        }

        void cubeMove(object sender, EventArgs e)
        {
            
            if(cube.Bounds.IntersectsWith(r.Bounds))
            {

                if(cube.BackColor == Color.Red)
                {

                    score += 1;
                    label1.Text = score.ToString();
                    this.Controls.Remove(cube);
                    spawnCube();
                    Console.Beep();

                }
                else
                {

                    r.Height -= 50;
                    r.Location = new Point(r.Location.X, r.Location.Y + 50);
                    this.Controls.Remove(cube);
                    spawnCube();

                }

            }

            if (cube.Bounds.IntersectsWith(g.Bounds))
            {

                if (cube.BackColor == Color.Lime)
                {

                    score += 1;
                    label1.Text = score.ToString();
                    this.Controls.Remove(cube);
                    spawnCube();
                    Console.Beep();

                }
                else
                {

                    g.Height -= 50;
                    g.Location = new Point(g.Location.X, g.Location.Y + 50);
                    this.Controls.Remove(cube);
                    spawnCube();

                }

            }

            if (cube.Bounds.IntersectsWith(y.Bounds))
            {

                if (cube.BackColor == Color.Yellow)
                {

                    score += 1;
                    label1.Text = score.ToString();
                    this.Controls.Remove(cube);
                    spawnCube();
                    Console.Beep();

                }
                else
                {

                    y.Height -= 50;
                    y.Location = new Point(y.Location.X, y.Location.Y + 50);
                    this.Controls.Remove(cube);
                    spawnCube();

                }

            }

            if (cube.Bounds.IntersectsWith(b.Bounds))
            {

                if (cube.BackColor == Color.Teal)
                {

                    score += 1;
                    label1.Text = score.ToString();
                    this.Controls.Remove(cube);
                    spawnCube();
                    Console.Beep();

                }
                else
                {

                    b.Height -= 50;
                    b.Location = new Point(b.Location.X, b.Location.Y + 50);
                    this.Controls.Remove(cube);
                    spawnCube();

                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            cube.Location = new Point(cube.Location.X, cube.Location.Y + speed);

            if(cube.Location.Y > this.Height)
            {

                cube.Location = new Point(cube.Location.X, 0);
                this.Controls.Remove(cube);
                spawnCube();

            }

            if(r.Height == 0 || g.Height == 0 || y.Height == 0 || b.Height == 0)
            {

                Application.Exit();

            }

        }

    }
}
