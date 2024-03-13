using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Linq;
using System.Data;
using System.Threading;

namespace QLSV
{
    public partial class StudentListForm : Form
    {
        private System.ComponentModel.IContainer components;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewImageColumn pictureDataGridViewImageColumn;
        private Button bt_refresh;
        private myDBDataSet myDBDataSet;
        private BindingSource stdBindingSource;
        private myDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private Label label1;
        private TextBox TextBoxPhone;
        private Label label2;
        private TextBox TextBoxFind;
        private Button bt_Find;
        private ProgressBar progressBar1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private ComboBox comboBoxFind;
        private GroupBox groupBoxGender;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private RadioButton radioButton_Other;
        private DataGridView dataGridView1;

        public StudentListForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new QLSV.myDBDataSet();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.stdTableAdapter = new QLSV.myDBDataSetTableAdapters.stdTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFind = new System.Windows.Forms.TextBox();
            this.bt_Find = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBoxFind = new System.Windows.Forms.ComboBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Other = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.stdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1204, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "MSSV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bdate";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Day of Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(536, 552);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 35);
            this.bt_refresh.TabIndex = 1;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find Phone:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(112, 15);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(249, 27);
            this.TextBoxPhone.TabIndex = 3;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Find:";
            // 
            // TextBoxFind
            // 
            this.TextBoxFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFind.Location = new System.Drawing.Point(768, 15);
            this.TextBoxFind.Name = "TextBoxFind";
            this.TextBoxFind.Size = new System.Drawing.Size(256, 27);
            this.TextBoxFind.TabIndex = 5;
            // 
            // bt_Find
            // 
            this.bt_Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Find.Location = new System.Drawing.Point(1059, 10);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(75, 36);
            this.bt_Find.TabIndex = 6;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = true;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 552);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // comboBoxFind
            // 
            this.comboBoxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFind.FormattingEnabled = true;
            this.comboBoxFind.Items.AddRange(new object[] {
            "Name",
            "Gender"});
            this.comboBoxFind.Location = new System.Drawing.Point(640, 15);
            this.comboBoxFind.Name = "comboBoxFind";
            this.comboBoxFind.Size = new System.Drawing.Size(121, 29);
            this.comboBoxFind.TabIndex = 8;
            this.comboBoxFind.TextChanged += new System.EventHandler(this.comboBoxFind_TextChanged);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButton_Male);
            this.groupBoxGender.Controls.Add(this.radioButton_Female);
            this.groupBoxGender.Controls.Add(this.radioButton_Other);
            this.groupBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGender.Location = new System.Drawing.Point(768, -7);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(285, 60);
            this.groupBoxGender.TabIndex = 22;
            this.groupBoxGender.TabStop = false;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Male.Location = new System.Drawing.Point(18, 23);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(65, 24);
            this.radioButton_Male.TabIndex = 15;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Female.Location = new System.Drawing.Point(102, 23);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(80, 24);
            this.radioButton_Female.TabIndex = 16;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Other
            // 
            this.radioButton_Other.AutoSize = true;
            this.radioButton_Other.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Other.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Other.Location = new System.Drawing.Point(203, 23);
            this.radioButton_Other.Name = "radioButton_Other";
            this.radioButton_Other.Size = new System.Drawing.Size(69, 24);
            this.radioButton_Other.TabIndex = 17;
            this.radioButton_Other.TabStop = true;
            this.radioButton_Other.Text = "Other";
            this.radioButton_Other.UseVisualStyleBackColor = true;
            // 
            // StudentListForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 629);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.comboBoxFind);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.TextBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentListForm";
            this.Text = "StudentListForm-22110394";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        STUDENT student = new STUDENT();
        stTableDataContext db = new stTableDataContext();
        MY_DB mydb = new MY_DB();

        // Dùng datagridview để lấy dữ liệu của sinh viên
        private void StudentListForm_Load(object sender, System.EventArgs e)
        {

            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            // Xử lý hình ảnh, code có tham khảo
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // Đối tượng làm việc với dạng picture của datagridview
            dataGridView1.RowTemplate.Height = 80; // Auto-size, co giãn để picture đẹp

            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            dateStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].DefaultCellStyle = dateStyle;

            groupBoxGender.Visible = false;
            progressBar1.Visible = false;

        }

        private void bt_refresh_Click(object sender, System.EventArgs e)
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

            SqlCommand command = new SqlCommand("SELECT * FROM std");
            // Nạp lại dữ liệu lên datagridview
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout= DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false; // giải thích trên stackoverflow
        }

        private void dataGridView1_DoubleClick(object sender, System.EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            // Theo thứ tự các cột
            updateDeleteStudentForm.TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStudentForm.TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStudentForm.TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStudentForm.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

           

            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male"))
            {
                updateDeleteStudentForm.RadioButtonMale.Checked = true;
            }
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                updateDeleteStudentForm.RadioButtonFemale.Checked = true;
            }
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Other"))
            {
                updateDeleteStudentForm.RadioButtonOther.Checked = true;
            }

            updateDeleteStudentForm.TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStudentForm.TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            // Code xử lý hình ảnh up lên
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStudentForm.PictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeleteStudentForm.Show();


        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {

            /* var list = (from s in db.stds where s.phone.Contains(TextBoxPhone.Text) select s).ToList();
             dataGridView1.DataSource = list;*/

            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE phone LIKE '%' + @phone + '%'", mydb.getConnection);
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextBoxPhone.Text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void bt_Find_Click(object sender, EventArgs e)
        {
            if (comboBoxFind.Text == "")
            {
                MessageBox.Show("Please choose type find", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }
            else if (comboBoxFind.Text == "Name")
            {
                if (TextBoxFind.Text == "")
                {
                    MessageBox.Show("Please import data find", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string name = TextBoxFind.Text;
                // SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname LIKE '%' + @fname + '%'", mydb.getConnection);
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE (fname + ' ' + lname) LIKE '%' + @name + '%' OR (lname + ' ' + fname) LIKE '%' + @name + '%'", mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

                // SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname) LIKE '%" + TextBoxFFName.Text + "%'", mydb.getConnection);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {

                    MessageBox.Show("No result", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView1.DataSource = table;
            }
            else if (comboBoxFind.Text == "Gender")
            {
                string gender;
                if (radioButton_Male.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton_Female.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton_Other.Checked)
                {
                    gender = "Other";
                }
                else
                {
                    MessageBox.Show("Please select the gender you are looking for", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE gender=@gender", mydb.getConnection);
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {

                    MessageBox.Show("No result", "Find ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView1.DataSource = table;
            }



            /*
            // Nhay ra form moi
            StudentSearchForm form = new StudentSearchForm();
            form.dataGridViewSearch.DataSource = table;
            form.dataGridViewSearch.RowTemplate.Height = 80;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)form.dataGridViewSearch.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // ĐỊnh dạng dd/mm/yyyu
            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            dateStyle.Format = "dd/MM/yyyy";
            form.dataGridViewSearch.Columns[3].DefaultCellStyle = dateStyle;

            form.dataGridViewSearch.AllowUserToAddRows = false;
            form.Show(); */

            /*var list = (from s in db.stds where s.fname.Contains(fname) select s).ToList();
           if (list.Count == 0)
           {
               MessageBox.Show("No result", "Please Find Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return;
           }
           StudentSearchForm form = new StudentSearchForm();
           form.dataGridViewSearch.DataSource = list;
           form.dataGridViewSearch.RowTemplate.Height = 80;
           form.Show();*/


        }

        private void comboBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFind.Text == "Gender")
            {
                TextBoxFind.Visible = false;
                groupBoxGender.Visible = true;
            }
            else
            {
                TextBoxFind.Visible = true;
                groupBoxGender.Visible = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}