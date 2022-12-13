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
    public partial class UpdateEmpid : Form
    {
        public UpdateEmpid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text!="")
            {
                updateEmp ue = new updateEmp();
                ue.Show();
            }
            else
            {
                MessageBox.Show("Please enter Employee ID" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
