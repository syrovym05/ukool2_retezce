using System;
using System.Windows.Forms;

namespace ukol2_retezce
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            //vstup = vstup.ToLower();
            char[] text = vstup.ToCharArray();
            int posun = Convert.ToInt32(numericUpDown1.Value);

            for(int i = 0; i < text.Length; i++)
            {
                //if (text[i] != ' ')
                {
                    if (text[i] >= 'a' && text[i] <= 'z' && text[i] + posun <= 'z')
                    {
                        text[i] = (char)((int)text[i] + posun);
                    }
                    else if (text[i] >= 'a' && text[i] <= 'z' && text[i] + posun > 'z')
                    {
                        text[i] = (char)((int)text[i] + posun - 26);
                    }
                    else if (text[i] >= 'A' && text[i] <= 'Z' && text[i] + posun <= 'Z')
                    {
                        text[i] = (char)((int)text[i] + posun);
                    }
                    else if (text[i] >= 'A' && text[i] <= 'Z' && text[i] + posun > 'Z')
                    {
                        text[i] = (char)((int)text[i] + posun - 26);
                    }
                    else text[i] = text[i];

                }
            }
            string vys = new string(text);
            textBox1.Text = vys;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            //vstup = vstup.ToLower();
            char[] text = vstup.ToCharArray();
            int posun = Convert.ToInt32(numericUpDown1.Value);

            for (int i = 0; i < text.Length; i++)
            {

               // if (text[i] != ' ')
                {
                    if (text[i] >= 'a' && text[i] <= 'z' && text[i] - posun >= 'a')
                    {
                        text[i] = (char)((int)text[i] - posun);
                    }
                    else if (text[i] >= 'a' && text[i] <= 'z' && text[i] - posun < 'a')
                    {
                        text[i] = (char)((int)text[i] - posun + 26);
                    }
                    else if (text[i] >= 'A' && text[i] <= 'Z' && text[i] - posun >= 'A')
                    {
                        text[i] = (char)((int)text[i] - posun);
                    }
                    else if (text[i] >= 'A' && text[i] <= 'Z' && text[i] - posun < 'A')
                    {
                        text[i] = (char)((int)text[i] - posun + 26);
                    }
                    else text[i] = text[i];

                    
                }
            }

            string vys = new string(text);
            textBox1.Text = vys;
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
