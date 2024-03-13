using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace QLSV
{
    public partial class MainForm : Form
    {
        public bool isAdmin { get; set; }

        public MainForm()
        {
            InitializeComponent();
            isAdmin = Login_From.isAdmin;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AddStudentForm();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminToolStripMenuItem.Visible = isAdmin;
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new StudentListForm();
            frm.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateDeleteStudentForm();
            frm.Show();
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AdminAccountListForm();
            frm.Show();
        }

        private void manageAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new ManageAccountForm();
            frm.Show();
        }

        private void requestAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new RequestAccountForm();
            frm.Show();
        }
    }
}
