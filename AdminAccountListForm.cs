using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AdminAccountListForm : Form
    {
        ACCOUNT account = new ACCOUNT();
        public AdminAccountListForm()
        {
            InitializeComponent();
        }

        private void AdminAccountListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.myDBDataSet2.login);
            
            SqlCommand command = new SqlCommand("SELECT * FROM login");
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = account.getAccounts(command);

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ManageAccountForm ManageAccountForm = new ManageAccountForm();
            // Theo thứ tự các cột
            ManageAccountForm.textBoxUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ManageAccountForm.textBoxPass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ManageAccountForm.textBoxFname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ManageAccountForm.textBoxLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ManageAccountForm.textBoxGmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ManageAccountForm.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            ManageAccountForm.Show();

        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login");
            // Nạp lại dữ liệu lên datagridview
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = account.getAccounts(command);
            dataGridView1.AllowUserToAddRows = false; // giải thích trên stackoverflow
        }
    }
}
