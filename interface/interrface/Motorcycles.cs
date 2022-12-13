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
    public partial class Motorcycles : Form
    {
        public Motorcycles()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-LOAR6A2\MSSQLSERVER01;Initial Catalog=""Car Rental Database VersionIII"";Integrated Security=True");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT CarID, Color, DepartmentID, MakerID, CarModel,ManufacturCompany, EngineCapacity, HorsePower, MaximumSpeed ,TransmissionType, YearModel , Fuel , TankSize, Seats, TractionType, FuelTankCapacity, NumberOfCylinder,Price FROM  Car Where  CarID = @CarID", conn2);
            cmd2.Parameters.AddWithValue("CarID", textBox21.Text);
            SqlDataReader reader1;
            reader1 = cmd2.ExecuteReader();
            if (reader1.Read())
            {
                textBox1.Text = reader1["CarModel"].ToString();
                textBox3.Text = reader1["Color"].ToString();
                textBox22.Text = reader1["DepartmentID"].ToString();
                textBox8.Text = reader1["MakerID"].ToString();
                textBox1.Text = reader1["CarModel"].ToString();
                textBox20.Text = reader1["ManufacturCompany"].ToString();
                textBox6.Text = reader1["EngineCapacity"].ToString();
                textBox7.Text = reader1["HorsePower"].ToString();
                textBox9.Text = reader1["MaximumSpeed"].ToString();
                textBox9.Text = reader1["TransmissionType"].ToString();
                textBox11.Text = reader1["YearModel"].ToString();
                textBox12.Text = reader1["Fuel"].ToString();
                textBox13.Text = reader1["TankSize"].ToString();
                textBox14.Text = reader1["Seats"].ToString();
                textBox15.Text = reader1["TractionType"].ToString();
                textBox16.Text = reader1["FuelTankCapacity"].ToString();
                textBox17.Text = reader1["NumberOfCylinder"].ToString();
                textBox18.Text = reader1["price"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            conn2.Close();
        }
    }
}
