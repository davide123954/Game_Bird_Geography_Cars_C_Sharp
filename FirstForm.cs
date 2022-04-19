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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBird_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To play, you must to press the space bar.", "Bird Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bird b1 = new Bird();
            b1.ShowDialog();
        }

        private void btnGeography_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To play, yoy must to click on button Next.", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Geography g1 = new Geography();
            g1.ShowDialog();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To play with the car you must to use the arrows.", "Cars Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cars c1 = new Cars();
            c1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
