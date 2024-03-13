using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public RadioButton RadioButtonOther;
        public RadioButton RadioButtonFemale;
        public RadioButton RadioButtonMale;
        public DateTimePicker dateTimePicker1;
        private Button bt_Find;
        private Button bt_Remove;
        private Button bt_Edit;
        private Button bt_upImage;
        public PictureBox PictureBoxStudentImage;
        public TextBox TextBoxAddress;
        public TextBox TextBoxPhone;    
        public TextBox TextBoxLname;
        public TextBox TextBoxFname;
        public TextBox TextBoxID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_close;
        private ComboBox comboBox_Find;
        private Label label9;
        private TextBox textBox_Find;
        private Button bt_ChangeID;
        STUDENT student = new STUDENT();


        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.RadioButtonOther = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_Find = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_upImage = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.comboBox_Find = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.bt_ChangeID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButtonOther
            // 
            this.RadioButtonOther.AutoSize = true;
            this.RadioButtonOther.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonOther.Location = new System.Drawing.Point(427, 425);
            this.RadioButtonOther.Name = "RadioButtonOther";
            this.RadioButtonOther.Size = new System.Drawing.Size(69, 23);
            this.RadioButtonOther.TabIndex = 45;
            this.RadioButtonOther.TabStop = true;
            this.RadioButtonOther.Text = "Other";
            this.RadioButtonOther.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(293, 425);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(86, 23);
            this.RadioButtonFemale.TabIndex = 44;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(174, 425);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(66, 23);
            this.RadioButtonMale.TabIndex = 43;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            this.RadioButtonMale.CheckedChanged += new System.EventHandler(this.RadioButtonMale_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 343);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(422, 27);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.Color.Yellow;
            this.bt_Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Find.Location = new System.Drawing.Point(730, 27);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(98, 34);
            this.bt_Find.TabIndex = 41;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.Location = new System.Drawing.Point(502, 537);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(169, 68);
            this.bt_Remove.TabIndex = 40;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(210, 537);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(169, 68);
            this.bt_Edit.TabIndex = 39;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_upImage
            // 
            this.bt_upImage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_upImage.Location = new System.Drawing.Point(747, 419);
            this.bt_upImage.Margin = new System.Windows.Forms.Padding(5);
            this.bt_upImage.Name = "bt_upImage";
            this.bt_upImage.Size = new System.Drawing.Size(410, 35);
            this.bt_upImage.TabIndex = 38;
            this.bt_upImage.Text = "Upload Image";
            this.bt_upImage.UseVisualStyleBackColor = true;
            this.bt_upImage.Click += new System.EventHandler(this.bt_upImage_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(747, 271);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(410, 140);
            this.PictureBoxStudentImage.TabIndex = 37;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(750, 113);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(407, 109);
            this.TextBoxAddress.TabIndex = 36;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(164, 487);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(422, 27);
            this.TextBoxPhone.TabIndex = 35;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.Location = new System.Drawing.Point(164, 268);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(422, 27);
            this.TextBoxLname.TabIndex = 34;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.Location = new System.Drawing.Point(164, 194);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(422, 27);
            this.TextBoxFname.TabIndex = 33;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(164, 120);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(325, 27);
            this.TextBoxID.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(640, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 490);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.LightGray;
            this.bt_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(796, 537);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(169, 68);
            this.bt_close.TabIndex = 46;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // comboBox_Find
            // 
            this.comboBox_Find.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Find.FormattingEnabled = true;
            this.comboBox_Find.Items.AddRange(new object[] {
            "ID",
            "Phone"});
            this.comboBox_Find.Location = new System.Drawing.Point(361, 33);
            this.comboBox_Find.Name = "comboBox_Find";
            this.comboBox_Find.Size = new System.Drawing.Size(128, 29);
            this.comboBox_Find.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Search:";
            // 
            // textBox_Find
            // 
            this.textBox_Find.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Find.Location = new System.Drawing.Point(522, 33);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(181, 27);
            this.textBox_Find.TabIndex = 50;
            // 
            // bt_ChangeID
            // 
            this.bt_ChangeID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChangeID.Location = new System.Drawing.Point(511, 116);
            this.bt_ChangeID.Name = "bt_ChangeID";
            this.bt_ChangeID.Size = new System.Drawing.Size(89, 34);
            this.bt_ChangeID.TabIndex = 51;
            this.bt_ChangeID.Text = "Change";
            this.bt_ChangeID.UseVisualStyleBackColor = true;
            this.bt_ChangeID.Click += new System.EventHandler(this.bt_ChangeID_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1212, 641);
            this.Controls.Add(this.bt_ChangeID);
            this.Controls.Add(this.textBox_Find);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_Find);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.RadioButtonOther);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_upImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateDeleteStudentForm-22110394";
            this.Load += new System.EventHandler(this.UpdateDeleteStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bt_Find_Click(object sender, System.EventArgs e)
        {
            DataTable table = new DataTable();
            if (comboBox_Find.Text == "")
            {
                MessageBox.Show("Please select a search type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_Find.Text == "")
            {
                MessageBox.Show("Please input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox_Find.Text == "ID")
            {
                int id = int.Parse(textBox_Find.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
                table = student.getStudents(command);
            }
            else if (comboBox_Find.Text == "Phone")
            {
                string phone = textBox_Find.Text;
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE phone = " + phone);
                table = student.getStudents(command);
            }
           

            if (table.Rows.Count > 0)
            {
                TextBoxID.Text = table.Rows[0]["ID"].ToString();
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString().Trim() == "Male")
                {
                    RadioButtonMale.Checked = true;
                }

              

                if (table.Rows[0]["gender"].ToString().Trim() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else if (table.Rows[0]["gender"].ToString().Trim() == "Other")
                {
                    RadioButtonOther.Checked = true;
                }

                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // kiểm tra nhập vào là ký tự
        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {

            int id;
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime birthdaytime = dateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;
            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            if (RadioButtonOther.Checked)
            {
                gender = "Other";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            // Kiểm tra first name
            if (TextBoxFname.Text == "")
            {
                MessageBox.Show("Please input First Name", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.IsMatch(TextBoxFname.Text, "^[a-zA-Z\\s]+$")) // Kiểm tra dữ liệu (a-z, A-Z, khoảng trắng)
            {
                MessageBox.Show("First Name must be contain only letters and space", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra last name
            else if (TextBoxLname.Text == "")
            {
                MessageBox.Show("Please input Last Name", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.IsMatch(TextBoxLname.Text, "^[a-zA-Z\\s]+$")) // Kiểm tra dữ liệu (a-z, A-Z, khoảng trắng)
            {
                MessageBox.Show("Last Name must be contain only letters and space", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra tuổi
            else if ((this_year - born_year) < 18 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student Age must be between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra gender
            else if (!RadioButtonFemale.Checked && !RadioButtonMale.Checked && !RadioButtonOther.Checked)
            {
                MessageBox.Show("Please select Gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Kiểm tra sdt
            else if (TextBoxPhone.Text == "")
            {
                MessageBox.Show("Please input Phone Number", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.IsMatch(TextBoxPhone.Text, "^[0-9]+$")) // Kiểm tra kiểu dữ liệu từ 0 - 9
            {
                MessageBox.Show("Phone number must be contain only numbers", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra địa chỉ
            else if (TextBoxAddress.Text == "")
            {
                MessageBox.Show("Please input Address", "Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxPhone.Text.Trim().Length != 10)
            {
                MessageBox.Show("A valid phone number has 10 digits", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("Please add Image", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // sv từ 18 - 100
            else if ((this_year - born_year) < 18 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student Age must be between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TextBoxID.Text);
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, birthdaytime, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student Info Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Unknown Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               
        }

        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxLname.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            // Delete student
            try
            {
                int studentID = Convert.ToInt32(TextBoxID.Text);
                // display a confirmation message before delete
                if (MessageBox.Show("Are you Sure you want to delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear fields after delete
                        TextBoxID.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_upImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif | *.jpg; *.png; *.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_ChangeID_Click(object sender, EventArgs e)
        {

        }
    }
}