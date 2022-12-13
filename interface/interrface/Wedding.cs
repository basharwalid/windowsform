using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interrface
{
    public partial class Wedding : Form
    {
        SqlConnection c2 = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
        SqlCommand cmd2;
        public Wedding()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                cmd2 = new SqlCommand("insert into Employee values('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox1.Text + "')", c2);
                c2.Open();
                cmd2.ExecuteNonQuery();
                c2.Close();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
