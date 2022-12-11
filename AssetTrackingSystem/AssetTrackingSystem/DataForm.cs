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
using static AssetTrackingSystem.Connection;

namespace AssetTrackingSystem
{
    public partial class deletebtn : Form
    {
        int id = 0;
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
                string Connection = Utils.ConnectionString;
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
                string Connection = Utils.ConnectionString;
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
            if (SystemTextBox.Text != "")
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = Utils.ConnectionString;
                //inserting data into coresponding data fields within mySQL database.
                //string Query = "update software set SystemName='" + this.SystemBox.Text + "',Version='" + this.versionbox.Text + "',Manufacturer='" + this.manubox.Text + "',ExtraData='" + this.extrabox.Text + "';";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand("UPDATE hardware SET SystemName=@SystemName, Model=@Model, Manufacturer=@Manufacturer, Type=@Type, IPaddress=@IPaddress where id=@id", Conn);
                //MySqlCommand Command = new MySqlCommand(Query, Conn);
                //MySqlDataReader Reader;
                Conn.Open();
                Command.Parameters.AddWithValue("@id", id);
                Command.Parameters.AddWithValue("@SystemName", SystemTextBox.Text);
                Command.Parameters.AddWithValue("@Model", ModelTextBox.Text);
                Command.Parameters.AddWithValue("@Manufacturer", ManuTextBox.Text);
                Command.Parameters.AddWithValue("@Type", TypeTextBox.Text);
                Command.Parameters.AddWithValue("@IPaddress", IPadTextBox.Text);
                Command.ExecuteNonQuery();
                //Reader = Command.ExecuteReader();
                MessageBox.Show("Data Updated");
                //while (Reader.Read())
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Please select data to update");
            }
        }

        private void dataGridView_hardware_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                int RowIndex = dataGridView_hardware.SelectedCells[0].RowIndex;

                //DataGridViewRow IndexRow = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(dataGridView_hardware.Rows[RowIndex].Cells[0].Value.ToString());
                SystemTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[1].Value.ToString();
                ModelTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[2].Value.ToString();
                ManuTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[3].Value.ToString();
                TypeTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[4].Value.ToString();
                IPadTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[5].Value.ToString();
                ExtraDataTextBox.Text = dataGridView_hardware.Rows[RowIndex].Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                string Connection = Utils.ConnectionString;
                // Query = "delete from software where id=@id";
                MySqlConnection Conn = new MySqlConnection(Connection); ;
                MySqlCommand Command = new MySqlCommand("delete from hardware where id = @id", Conn);
                //MySqlDataReader Reader;
                Conn.Open();
                Command.Parameters.AddWithValue("@id", id);
                Command.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Data deleted");
                //while (Reader.Read())
            }
            else
            {
                MessageBox.Show("Please select data to delete");
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
