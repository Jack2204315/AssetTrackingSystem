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
    public partial class LinkTablesForm : Form
    {
        int id = 0;
        public LinkTablesForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viewbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                string Connection = Utils.ConnectionString;
                string Query = "SELECT * FROM hardware;";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                DataTable dTable = new DataTable();
                Adapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            snbox1.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            mbox1.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            manubox1.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
        }

        private void viewbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                string Connection = Utils.ConnectionString;
                string Query = "SELECT * FROM software;";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                DataTable dTable = new DataTable();
                Adapter.Fill(dTable);
                dataGridView2.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dataGridView2.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView2.Rows[RowIndex].Cells[0].Value.ToString());
            snbox2.Text = dataGridView2.Rows[RowIndex].Cells[1].Value.ToString();
            vbox.Text = dataGridView2.Rows[RowIndex].Cells[2].Value.ToString();
            manubox2.Text = dataGridView2.Rows[RowIndex].Cells[3].Value.ToString();
        }

        private void viewbtn3_Click(object sender, EventArgs e)
        {
            try
            {
                string Connection = Utils.ConnectionString;
                string Query = "SELECT * FROM LinkTable;";
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                Adapter.SelectCommand = Command;
                DataTable dTable = new DataTable();
                Adapter.Fill(dTable);
                dataGridView3.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (snbox1.Text != "" && (snbox2.Text != ""))
            {
                string Connection = Utils.ConnectionString;
                MySqlConnection Conn = new MySqlConnection(Connection);
                MySqlCommand Command = new MySqlCommand("INSERT into LinkTable(hardwareid, softwareid)" + "VALUES(@SystemName, @OSName)", Conn);
                Conn.Open();
                Command.Parameters.AddWithValue("@SystemName", snbox1.Text);
                Command.Parameters.AddWithValue("@OSName", snbox2.Text);
                Command.ExecuteNonQuery();
                MessageBox.Show("Data Linked");
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Provide data to link");
            }
        }
    }
}
