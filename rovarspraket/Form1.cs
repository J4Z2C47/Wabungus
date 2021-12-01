using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rovarspraket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> vowels = new List<char> { 'a','o','u','å','e','i','y','ä','ö' };

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";

            foreach (char c in richTextBox1.Text)
            {
                if (Char.IsLetter(c) && vowels.IndexOf(c.ToString().ToLower()[0]) == -1)
                {
                    richTextBox2.Text += $"{c}ungus";
                }
                else
                {
                    richTextBox2.Text += c;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
