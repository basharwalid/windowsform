using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace interrface
{
    public partial class Long_term : Form
    {
        SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
        SqlCommand cmd1;   
        public Long_term()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Long_term_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                cmd1=new SqlCommand("insert into Car values('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "')", c1);
                c1.Open();
                cmd1.ExecuteNonQuery();
                c1.Close();
            }
        }
    }
}
