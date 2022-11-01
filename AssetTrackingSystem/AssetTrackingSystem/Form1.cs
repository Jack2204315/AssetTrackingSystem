using MySql.Data.MySqlClient;  // for MySQL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AssetTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                //inserting data into coresponding data fields within mySQL database.
                string Query = "insert into hardware(SystemName,Model,Manufacturer,Type,IPaddress,ExtraData) values('" + this.SystemTextBox.Text + "','" + this.ModelTextBox.Text + "','" + this.ManuTextBox.Text + "','" + this.TypeTextBox.Text + "','" + this.IPadTextBox.Text + "','" + this.ExtraDataTextBox.Text + "');";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataReader Reader;
                Conn.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Asset data has been added");
                while (Reader.Read())
                {
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help view data through dataGridView_hardware: https://www.w3schools.com/sql/default.asp
                //This is my connection string to mySQL database.
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                //populate dataGridView_hardware
                string Query = "select * from hardware;";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                DataTable dTable = new DataTable();
                Adapter.Fill(dTable);
                dataGridView_hardware.DataSource = dTable; // assigned dTable object to the dataGridView_hardware object to display data.
                                                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
