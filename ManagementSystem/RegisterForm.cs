﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Prog\C#\ManagementSystem\ManagementSystem\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';   
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " вже використовуеться"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users " +
                                    "(username, password, date_register) " +
                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Реєстрація успішна!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}