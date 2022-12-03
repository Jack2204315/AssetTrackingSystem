using MySql.Data.MySqlClient;  // for MySQL
using System.Management;
using System.Management.Instrumentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace AssetTrackingSystem
{
    public partial class deletebtn : Form
    {
        public deletebtn()
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
                MessageBox.Show("Hardware data has been added");
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

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                //inserting data into coresponding data fields within mySQL database.
                string Query = "update hardware set SystemName='" + this.SystemTextBox.Text + "',Model='" + this.ModelTextBox.Text + "',Manufacturer='" + this.ManuTextBox.Text + "',Type='" + this.TypeTextBox.Text + "',IPaddress='" + this.IPadTextBox.Text + "',ExtraData='" + this.ExtraDataTextBox.Text + "';";
                MySqlConnection Conn = new MySqlConnection(Connection);;
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataReader Reader;
                Conn.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Data Updated");
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

        private void dataGridView_hardware_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow IndexRow = this.dataGridView_hardware.Rows[e.RowIndex];
                SystemTextBox.Text = IndexRow.Cells[0].Value.ToString();
                ModelTextBox.Text = IndexRow.Cells[1].Value.ToString();
                ManuTextBox.Text = IndexRow.Cells[2].Value.ToString();
                TypeTextBox.Text = IndexRow.Cells[3].Value.ToString();
                IPadTextBox.Text = IndexRow.Cells[4].Value.ToString();
                ExtraDataTextBox.Text = IndexRow.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                string Query = "delete from hardware where SystemName='" + this.SystemTextBox.Text + "';";
                MySqlConnection Conn = new MySqlConnection(Connection); ;
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataReader Reader;
                Conn.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Data Deleted");
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

        private void deletebtn_Load(object sender, EventArgs e)
        {

        }

        private void retrievebtn_Click(object sender, EventArgs e)
        {
            ManuTextBox.Text = HardwareInfo.GetManufacturer();
            ModelTextBox.Text = HardwareInfo.GetModel();
            TypeTextBox.Text = HardwareInfo.GetSystemType();

            string q1 = Environment.MachineName;
            SystemTextBox.Text = q1;

            //https://www.youtube.com/watch?v=izpntJlcs8o
            //link above was used for ip fetch code.
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPadTextBox.Text = address.ToString();
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Direction df = new Direction();
            df.Show();
            Visible = false;
        }
    }
}
