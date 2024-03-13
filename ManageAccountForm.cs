using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class ManageAccountForm : Form
    {
        ACCOUNT account = new ACCOUNT();
        public ManageAccountForm()
        {
            InitializeComponent();
        }

        private void ManageAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (comboBoxFind.Text == "")
            {
                MessageBox.Show("Please select a search type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxFind.Text == "")
            {
                MessageBox.Show("Please input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBoxFind.Text == "Username")
            {
                string username = textBoxFind.Text;
                SqlCommand command = new SqlCommand("Select * from login where username = @username");
                command.Parameters.AddWithValue("@username", username);
                table = account.getAccounts(command);
            }
            else if (comboBoxFind.Text == "Gmail")
            {
                string gmail = textBoxFind.Text;
                SqlCommand command = new SqlCommand("Select * from login where gmail = @gmail");
                command.Parameters.AddWithValue("@gmail", gmail);
                table = account.getAccounts(command);
            }

            if (table.Rows.Count > 0)
            {
                textBoxUser.Text = table.Rows[0]["username"].ToString();
                textBoxPass.Text = table.Rows[0]["password"].ToString();
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                textBoxGmail.Text = table.Rows[0]["gmail"].ToString();
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();


            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text;
            string pass = textBoxPass.Text;
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string gmail = textBoxGmail.Text;
            string phone = textBoxPhone.Text;


            try
            {
                if (account.updateAccount(user, pass, fname, lname, gmail, phone))
                {
                    MessageBox.Show("Account Info Updated", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textBoxUser.Text;
                // display a confirmation message before delete
                if (MessageBox.Show("Are you Sure you want to delete This Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (account.deleteAccount(user))
                    {
                        MessageBox.Show("Account Deleted", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear fields after delete
                        textBoxUser.Text = "";
                        textBoxPass.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxGmail.Text = "";
                        textBoxPhone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Account Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Don't have username in system", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
