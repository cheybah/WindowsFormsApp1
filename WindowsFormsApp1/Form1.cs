using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Int32.Parse(p1.Text);
            int q = Int32.Parse(q1.Text);

            if (p * q != 0)
            {
                Console.Write(" ");
            }
            else
            {
                pgcd1.Text = "Le PGCD ne peut pas être calculé car un variable est nul";
            
            }

            while (p != q)
            {
                if (p > q)
                {
                    p -= q;
                }
                else
                {
                    q -= p;
                }

            }

            pgcd1.Text = p.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
