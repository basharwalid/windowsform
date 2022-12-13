using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interrface
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Long_term l1 = new Long_term();
            l1.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carview cv = new carview();
            cv.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Motorcycles m1 = new Motorcycles();
             m1.Show();  
        }
    }
}
