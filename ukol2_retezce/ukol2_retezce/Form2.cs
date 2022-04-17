using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2_retezce
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;            
            char[] vys_text = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 'A' && text[i] <= 'Z'))
                {
                    int znak = Convert.ToInt32(text[i]) + 32;
                    vys_text[i] = (char)znak;
                }
                else
                {
                    vys_text[i] = (char)text[i];
                }
            }

            string vys = new string(vys_text);
            textBox1.Text = vys;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            text = text.Replace("*", "");
            textBox1.Text = text;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
