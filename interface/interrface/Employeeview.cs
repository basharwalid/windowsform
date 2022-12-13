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
    
    public partial class Employeeview : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
        SqlDataAdapter DA;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Employeeview()
        {
            InitializeComponent();
            DA = new SqlDataAdapter("Select * from Employee", con);
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Employeeview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_Rental_Database_VersionIIIDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.car_Rental_Database_VersionIIIDataSet.Employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(DA);
            DA.Update(dt);
            MessageBox.Show("Passed Succussfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
