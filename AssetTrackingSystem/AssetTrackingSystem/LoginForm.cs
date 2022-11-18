﻿using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        //private string connectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource = lochnagar.abertay.ac.uk; database = sql2204315; username = sql2204315; password = 45Hysx3CEDI4");
            MySqlCommand cmd = new MySqlCommand("SELECT passwordhash FROM userlogin WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", UsertextBox.Text);

                conn.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                    if (BCrypt.Net.BCrypt.Verify(PassTextBox.Text, dataReader.GetString(0)))
                    //if (PassTextBox.Text == dataReader.GetString(0))
                        {
                            
                           DialogResult = DialogResult.OK;
                           MessageBox.Show("Correct");
                        }

                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                }
            

            if (BCrypt.Net.BCrypt.Verify(PassTextBox.Text, dataReader.GetString(0)))
            {
                deletebtn dataform = new deletebtn();
                dataform.Show();
                this.Hide();
            }
        }

        private void passbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PassTextBox.PasswordChar == '*')
            {
                passbox.BringToFront();
                PassTextBox.PasswordChar = '\0';
            }

            else if (PassTextBox.PasswordChar == '\0')
            {
                passbox.BringToFront();
                PassTextBox.PasswordChar = '*';
            }
        }
    }
}
