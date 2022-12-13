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
    public partial class Short_term : Form
    {
        SqlConnection c1 = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
        SqlCommand cmd1;
        public Short_term()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM Car WHERE CarID = '" + textBox1 + "'";
            cmd1 = new SqlCommand(query, c1);
            SqlDataReader s1;
            try 
            {
                c1.Open();
                s1 = cmd1.ExecuteReader();
                MessageBox.Show("CAR DELETED");
                while (s1.Read())
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            

        }
    }
}
