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
            deleteEmp de = new deleteEmp();
            de.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wedding w = new Wedding();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEmpid uid = new UpdateEmpid();
            uid.Show();
        }
    }
}
