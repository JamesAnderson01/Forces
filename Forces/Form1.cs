using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FORCE = Convert.ToDouble(textBox2.Text);
            double ANGLE = Convert.ToDouble(textBox1.Text);
            double Fx = FORCE * cos(ANGLE);
            double Fy = FORCE * sin(ANGLE);
            MessageBox.Show("Fx = " + Fx);
            MessageBox.Show("Fy = " + Fy);
        }

        double sin (double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double cos (double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
