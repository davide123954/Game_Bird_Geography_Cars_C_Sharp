using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menu
{
    public partial class Geography : Form
    {
        public Geography()
        {
            InitializeComponent();
        }

        private void Geography_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBox1.Items.Add(s);
        }
        public void OpentxtFile()
        {
            if ((lblCount.Text == "1") && (listBox1.Text == "Brazil") || (lblCount.Text == "2") && (listBox1.Text == "Israel") || (lblCount.Text == "3") && (listBox1.Text == "New York") || (lblCount.Text == "4") && (listBox1.Text == "France") || ((lblCount.Text == "5") && (listBox1.Text == "Italy") || (lblCount.Text == "6") && (listBox1.Text == "Russia")|| (lblCount.Text == "7") && (listBox1.Text == "Ukraine")))
            {
                FileStream g = new FileStream("good.txt", FileMode.Append);//create file or append
                StreamWriter m = new StreamWriter(g);
                m.WriteLine("The file contains only good answers !!!! ");
                m.WriteLine("Answer IS:  " + listBox1.Text.ToString());
                m.Close();
                g.Close();
            }
        }
            public void OpentxtBadfile()
            {
                if ((lblCount.Text == "1") && (listBox1.Text != "Brazil") || (lblCount.Text == "2") && (listBox1.Text != "Israel") || (lblCount.Text == "3") && (listBox1.Text != "New York") || (lblCount.Text == "4") && (listBox1.Text != "France") || ((lblCount.Text == "5") && (listBox1.Text != "Italy") || (lblCount.Text == "6") && (listBox1.Text != "Russia")|| (lblCount.Text == "7") && (listBox1.Text != "Ukraine")))
                {

                    FileStream g = new FileStream("bad.txt", FileMode.Append);//create file or append
                    StreamWriter m = new StreamWriter(g);
                    m.WriteLine("THE FILE CONTAINS ONLY INCORRECT ANSWERS:(");
                    m.WriteLine("incorrect answer is: " + listBox1.Text.ToString());
                    m.Close();
                    g.Close();
                }
            }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((lblCount.Text == "1") && (listBox1.Text == "Brazil"))
            {
                MessageBox.Show("Brasil is located in the South America", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
            else if ((lblCount.Text == "2") && (listBox1.Text == "Israel"))
            {
                MessageBox.Show("Israel is a country in Western Asia, located on the southeastern shore of the Mediterranean Sea", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
        
            else if ((lblCount.Text == "3") && (listBox1.Text == "New York"))
            {
                MessageBox.Show("New York City is situated in the northeastern United States, in southeastern New York State", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
            else if ((lblCount.Text == "4") && (listBox1.Text == "France"))
            {
                MessageBox.Show("Paris is located in northern central France, in a north-bending arc of the river Seine", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
            else if ((lblCount.Text == "5") && (listBox1.Text == "Italy"))
            {
                MessageBox.Show("Rome is in the Lazio region of central Italy on the Tiber (Italian: Tevere) river.", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }

            else if ((lblCount.Text == "6") && (listBox1.Text == "Russia"))
            {
                MessageBox.Show("Russia: Россия, Rossiya, or the Russian Federation, is a transcontinental country spanning Eastern Europe.", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
            else if ((lblCount.Text == "7") && (listBox1.Text == "Ukraine"))
            {
                MessageBox.Show("Ukraine:Only for Alona !!!\nUkraine is a vast Eastern European country known for its Orthodox churches, the Black Sea coast and forested mountains. In the capital Kiev, the golden dome of the Cathedral of Saint Sophia stands out, with mosaics and frescoes from the 11th century.", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = true;
                MessageBox.Show("YOU GOT THE GOOD PLACE !!", "Geography Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpentxtFile();
            }
            else
            {
                MessageBox.Show("NO, TRY AGAIN !!", "Geography Game",MessageBoxButtons.OK,MessageBoxIcon.Information);
                OpentxtBadfile();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Random Myno = new Random();
            int Maxpictures = 8;
            int numNo = Myno.Next(1, Maxpictures);
            lblCount.Text = numNo.ToString();
            if (numNo == 1)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Brasile;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 2)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Israel;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 3)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.New_York;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 4)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Paris;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 5)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Rome;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 6)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Russia;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
            else if (numNo == 7)
            {
                btnNext.Enabled = false;
                pictureBox1.Image = Properties.Resources.Ukraine;
                listBox1.Enabled = true;
                btnSubmit.Enabled = true;

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 goTo = new Form1();
            goTo.ShowDialog();
        }
    }
}
