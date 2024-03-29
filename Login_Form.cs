﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login_From : Form
    {
        public static bool isAdmin { get; set; }

        public Login_From()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_From_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\ADMIN\\Pictures\\Picture1.png");
            progressBar1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Register_Form();
            frm.ShowDialog();
        }

        private void bt_logIn_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.LimeGreen; // Use a more visually appealing green
            progressBar1.Visible = true;
            for (int i = 1; i <= progressBar1.Maximum; i++)
            {
                // Đặt giá trị của thanh tiến trình
                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = i; });

                // Sleep một chút để có thể quan sát được thanh tiến trình di chuyển
                Thread.Sleep(30);

            }
            progressBar1.Visible = false;

            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            if (checkBoxAdmin.Checked)
            {
                isAdmin = true;
                SqlCommand command = new SqlCommand("SELECT * FROM admin WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

            }
            else
            {
                isAdmin = false;
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

            }
            if ((table.Rows.Count > 0))
            {

                /*                MessageBox.Show("Ok, next time will be go to Main menu of App");
                */
                this.DialogResult = DialogResult.OK;
            }
            else if (TextBoxUsername.Text == "")
            {
                errorProvider1.SetError(TextBoxUsername, "Username is required");
                MessageBox.Show("Please input Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (TextBoxPassword.Text == "")
            {
                errorProvider1.SetError(TextBoxPassword, "Password is required");
                MessageBox.Show("Please input Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
