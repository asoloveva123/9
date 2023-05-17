using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = NumberSymbols(textBox1.Text, 'а').ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
