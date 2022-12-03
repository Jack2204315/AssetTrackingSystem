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
    public partial class SoftwareForm : Form
    {
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
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                //inserting data into coresponding data fields within mySQL database.
                string Query = "insert into software(SystemName,Version,Manufacturer,ExtraData) values('" + this.SystemBox.Text + "','" + this.versionbox.Text + "','" + this.manubox.Text + "','" + this.extrabox.Text + "');";
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
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the reference to help establish a connection to MySQL database: https://www.c-sharpcorner.com/UploadFile/9582c9/insert-update-delete-display-data-in-mysql-using-C-Sharp/
                //This is my connection string to mySQL database.
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                //inserting data into coresponding data fields within mySQL database.
                string Query = "update software set SystemName='" + this.SystemBox.Text + "',Version='" + this.versionbox.Text + "',Manufacturer='" + this.manubox.Text + "',ExtraData='" + this.extrabox.Text + "';";
                MySqlConnection Conn = new MySqlConnection(Connection); ;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow IndexRow = this.dataGridView1.Rows[e.RowIndex];
                SystemBox.Text = IndexRow.Cells[0].Value.ToString();
                versionbox.Text = IndexRow.Cells[1].Value.ToString();
                manubox.Text = IndexRow.Cells[2].Value.ToString();
                extrabox.Text = IndexRow.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Connection = "datasource=lochnagar.abertay.ac.uk;database=sql2204315;username=sql2204315;password=45Hysx3CEDI4";
                string Query = "delete from software where SystemName='" + this.SystemBox.Text + "';";
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

        private void button5_Click(object sender, EventArgs e)
        {
            versionbox.Text = SoftwareInfo.GetVersion();
            manubox.Text = SoftwareInfo.GetManufacturer();
            SystemBox.Text = SoftwareInfo.GetOSName();
        }
    }
}
