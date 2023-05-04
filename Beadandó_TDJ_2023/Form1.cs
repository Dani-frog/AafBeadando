using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadandó_TDJ_2023
{
    public partial class Form1 : Form
    {

        bool piros = false;
        bool kek = false;
        bool zold = false;
        string font = "Arial";
        bool szoveg = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 80;
            
            label3.Font = new Font(font, Convert.ToInt32(numericUpDown1.Value));
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                piros = true;
            }
            else
            {
                piros = false;
            }
            if (szoveg)
            {
                if (!piros && !kek && !zold) { label3.ForeColor = Color.Black; }
                else if (piros && kek && zold) { label3.ForeColor = Color.White; }
                else if (piros && kek && !zold) { label3.ForeColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.ForeColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.ForeColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.ForeColor = Color.Red; } else if (!piros && kek && !zold) { label3.ForeColor = Color.Blue; } else if (!piros && !kek && zold) { label3.ForeColor = Color.Green; }
            }
            else
            {
                if (!piros && !kek && !zold) { label3.BackColor = Color.Transparent; }
                else if (piros && kek && zold) { label3.BackColor = Color.White; }
                else if (piros && kek && !zold) { label3.BackColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.BackColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.BackColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.BackColor = Color.Red; } else if (!piros && kek && !zold) { label3.BackColor = Color.Blue; } else if (!piros && !kek && zold) { label3.BackColor = Color.Green; }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                kek = true;
            }
            else
            {
                kek = false;
            }
            if (szoveg)
            {
                if (!piros && !kek && !zold) { label3.ForeColor = Color.Black; }
                else if (piros && kek && zold) { label3.ForeColor = Color.White; }
                else if (piros && kek && !zold) { label3.ForeColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.ForeColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.ForeColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.ForeColor = Color.Red; } else if (!piros && kek && !zold) { label3.ForeColor = Color.Blue; } else if (!piros && !kek && zold) { label3.ForeColor = Color.Green; }
            }
            else
            {
                if (!piros && !kek && !zold) { label3.BackColor = Color.Transparent; }
                else if (piros && kek && zold) { label3.BackColor = Color.White; }
                else if (piros && kek && !zold) { label3.BackColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.BackColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.BackColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.BackColor = Color.Red; } else if (!piros && kek && !zold) { label3.BackColor = Color.Blue; } else if (!piros && !kek && zold) { label3.BackColor = Color.Green; }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                zold = true;
            }
            else
            {
                zold = false;
            }
            if (szoveg)
            {
                if (!piros && !kek && !zold) { label3.ForeColor = Color.Black; }
                else if (piros && kek && zold) { label3.ForeColor = Color.White; }
                else if (piros && kek && !zold) { label3.ForeColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.ForeColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.ForeColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.ForeColor = Color.Red; } else if (!piros && kek && !zold) { label3.ForeColor = Color.Blue; } else if (!piros && !kek && zold) { label3.ForeColor = Color.Green; }
            }
            else
            { 
                if (!piros && !kek && !zold) { label3.BackColor = Color.Transparent; }
                else if (piros && kek && zold) { label3.BackColor = Color.White; }
                else if (piros && kek && !zold) { label3.BackColor = Color.Pink; }
                else if (piros && zold && !kek) { label3.BackColor = Color.Yellow; }
                else if (kek && zold && !piros) { label3.BackColor = Color.LightBlue; }
                else if (piros && !kek && !zold) { label3.BackColor = Color.Red; } else if (!piros && kek && !zold) { label3.BackColor = Color.Blue; } else if (!piros && !kek && zold) { label3.BackColor = Color.Green; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked==true)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
            }
            else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Underline);
            }
            

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
            }
            else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
            }
            else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Bold);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            font = radioButton1.Text;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Szöveg")
            {
                szoveg = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;

            }
            else
            {
                szoveg = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Szöveg";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            font = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            font = radioButton3.Text;
        }

    }
}
