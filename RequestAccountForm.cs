using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class RequestAccountForm : Form
    {
        ACCOUNT account = new ACCOUNT();
        public RequestAccountForm()
        {
            InitializeComponent();
        }

        private void RequestAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet3.request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.myDBDataSet3.request);

            SqlCommand command = new SqlCommand("SELECT * FROM request");
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = account.getAccounts(command);

            dataGridView1.AllowUserToAddRows = false;

        }

        private void bt_Approve_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRow)
            {
                string username = row.Cells[0].Value.ToString();
                string password = row.Cells[1].Value.ToString();
                string fname = row.Cells[2].Value.ToString();
                string lname = row.Cells[3].Value.ToString();
                string gmail = row.Cells[4].Value.ToString();
                string phone = row.Cells[5].Value.ToString();

                if (account.submitAccount(username, password, fname, lname, gmail, phone))
                {
                    account.deleteRequestAccount(username);
                    MessageBox.Show("Account added", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRow)
            {
                string username = row.Cells[0].Value.ToString();
                account.deleteRequestAccount(username);
                MessageBox.Show("Account deleted", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM request");
            // Nạp lại dữ liệu lên datagridview
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = account.getAccounts(command);
            dataGridView1.AllowUserToAddRows = false; // giải thích trên stackoverflow
        }

        private void bt_AppproveAll_Click(object sender, EventArgs e)
        {
           

        }
    }
}
