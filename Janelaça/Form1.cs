using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelaça
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aleatorio = rnd.Next(0, trackBar1.Value + 1);
            label1.Text = aleatorio.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
