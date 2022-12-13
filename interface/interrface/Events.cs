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
    public partial class Events : Form
    {

        public Events()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carview CV = new carview();
            CV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wedding w = new Wedding();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateEmp ue = new updateEmp();
            ue.Show();  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Employeeview ev = new Employeeview();
            ev.Show();
        }
    }
}
