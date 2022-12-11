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
using static AssetTrackingSystem.Connection;

namespace AssetTrackingSystem
{
    public partial class SoftwareForm : Form
    {
        int id = 0;
        public SoftwareForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Direction df = new Direction();
            df.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = Utils.ConnectionString;
                //inserting data into coresponding data fields within mySQL database.
                string Query = "insert into software(OSName,Version,Manufacturer,ExtraData) values('" + this.SystemBox.Text + "','" + this.versionbox.Text + "','" + this.manubox.Text + "','" + this.extrabox.Text + "');";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataReader Reader;
                Conn.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Software data has been added");
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help view data through dataGridView_hardware: https://www.w3schools.com/sql/default.asp
                //This is my connection string to mySQL database.
                string Connection = Utils.ConnectionString;
                //populate dataGridView_hardware
                string Query = "select * from software;";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                DataTable dTable = new DataTable();
                Adapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // assigned dTable object to the dataGridView_hardware object to display data.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.SelectedCells[0].RowIndex;

            //DataGridViewRow IndexRow = this.dataGridView1.Rows[e.RowIndex];
            id = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            SystemBox.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            versionbox.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            manubox.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
            extrabox.Text = dataGridView1.Rows[RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SystemBox.Text != "")
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = Utils.ConnectionString;
                //inserting data into coresponding data fields within mySQL database.
                //string Query = "update software set SystemName='" + this.SystemBox.Text + "',Version='" + this.versionbox.Text + "',Manufacturer='" + this.manubox.Text + "',ExtraData='" + this.extrabox.Text + "';";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand("UPDATE software SET OSName=@OSName, Version=@Version, Manufacturer=@Manufacturer where id=@id", Conn);
                //MySqlCommand Command = new MySqlCommand(Query, Conn);
                //MySqlDataReader Reader;
                Conn.Open();
                Command.Parameters.AddWithValue("@id", id);
                Command.Parameters.AddWithValue("@OSName", SystemBox.Text);
                Command.Parameters.AddWithValue("@Version", versionbox.Text);
                Command.Parameters.AddWithValue("@Manufacturer", manubox.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                string Connection = Utils.ConnectionString;
                // Query = "delete from software where id=@id";
                MySqlConnection Conn = new MySqlConnection(Connection); ;
                MySqlCommand Command = new MySqlCommand("delete from software where id = @id", Conn);
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

        private void button5_Click(object sender, EventArgs e)
        {
            versionbox.Text = SoftwareInfo.GetVersion();
            manubox.Text = SoftwareInfo.GetManufacturer();
            SystemBox.Text = SoftwareInfo.GetOSName();
        }
    }
}
