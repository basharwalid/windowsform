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
    public partial class updateEmp : Form
    {
        public updateEmp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT EmployeeID, EmployeeName, EmployeeDepartment, EmployeeEmail, EmployeeUsername, EmployeePassword, EmployeeGender, EmployeeAge, EmployeeNationalID, EmployeePhoneNumber , EmployeeCountry , EmployeeAddress, EmployeeNationality, EmployeeSalary, EmployeeBankingInforamtion, EmployeeGraduationState FROM  Employee Where  EmployeeID = @EmployeeID", conn1);
            cmd1.Parameters.AddWithValue("EmployeeID", textBox1.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                textBox2.Text = reader1["EmployeeName"].ToString();
                textBox3.Text = reader1["EmployeeDepartment"].ToString();
                textBox4.Text = reader1["EmployeeEmail"].ToString();
                textBox5.Text = reader1["EmployeeUsername"].ToString();
                textBox6.Text = reader1["EmployeePassword"].ToString();
                textBox7.Text = reader1["EmployeeGender"].ToString();
                textBox8.Text = reader1["EmployeeAge"].ToString();
                textBox9.Text = reader1["EmployeeNationalID"].ToString();
                textBox10.Text = reader1["EmployeePhoneNumber"].ToString();
                textBox11.Text = reader1["EmployeeCountry"].ToString();
                textBox12.Text = reader1["EmployeeAddress"].ToString();
                textBox13.Text = reader1["EmployeeNationality"].ToString();
                textBox14.Text = reader1["EmployeeSalary"].ToString();
                textBox15.Text = reader1["EmployeeBankingInforamtion"].ToString();
                textBox16.Text = reader1["EmployeeGraduationState"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            conn1.Close();
        }
    }
}
