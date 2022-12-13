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
    public partial class carview : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
        SqlDataAdapter DA;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public carview()
        {
            InitializeComponent();
            DA = new SqlDataAdapter("Select * from Car", con);
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void carview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_Rental_Database_VersionIIIDataSet.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.car_Rental_Database_VersionIIIDataSet.Car);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(DA);
            DA.Update(dt);
            MessageBox.Show("Passed Succussfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
