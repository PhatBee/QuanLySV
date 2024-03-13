using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QLSV
{
    internal class Register_Form : Form
    {
        private Panel panel1;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Button bt_Register;
        private Button bt_Cancel;
        private TextBox TextBoxPassword;
        private TextBox TextBoxUsername;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox textBoxPhone;
        private TextBox textBoxGmail;
        private Label label9;
        private TextBox textBoxConfirm;
        private TextBox textBoxLName;
        private TextBox textBoxFName;
        private Label label8;
        private ErrorProvider errorProviderConfirm;
        private System.ComponentModel.IContainer components;
        private Button bt_OTP;
        private TextBox textBoxOTP;
        private Label label1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_OTP = new System.Windows.Forms.Button();
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxGmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Register = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderConfirm = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 632);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(300, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 182);
            this.label5.TabIndex = 19;
            this.label5.Text = "Welcome to the Service Management Student";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(80, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_OTP);
            this.panel2.Controls.Add(this.textBoxOTP);
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.textBoxGmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxConfirm);
            this.panel2.Controls.Add(this.textBoxLName);
            this.panel2.Controls.Add(this.textBoxFName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bt_Register);
            this.panel2.Controls.Add(this.bt_Cancel);
            this.panel2.Controls.Add(this.TextBoxPassword);
            this.panel2.Controls.Add(this.TextBoxUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 632);
            this.panel2.TabIndex = 14;
            // 
            // bt_OTP
            // 
            this.bt_OTP.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OTP.Location = new System.Drawing.Point(242, 244);
            this.bt_OTP.Name = "bt_OTP";
            this.bt_OTP.Size = new System.Drawing.Size(96, 33);
            this.bt_OTP.TabIndex = 25;
            this.bt_OTP.Text = "Send OTP";
            this.bt_OTP.UseVisualStyleBackColor = true;
            this.bt_OTP.Click += new System.EventHandler(this.bt_OTP_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOTP.Location = new System.Drawing.Point(31, 246);
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(205, 27);
            this.textBoxOTP.TabIndex = 24;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(333, 202);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(273, 27);
            this.textBoxPhone.TabIndex = 22;
            // 
            // textBoxGmail
            // 
            this.textBoxGmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGmail.Location = new System.Drawing.Point(31, 202);
            this.textBoxGmail.Name = "textBoxGmail";
            this.textBoxGmail.Size = new System.Drawing.Size(273, 27);
            this.textBoxGmail.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(329, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone Number:";
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBoxConfirm.Location = new System.Drawing.Point(222, 423);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(273, 27);
            this.textBoxConfirm.TabIndex = 20;
            this.textBoxConfirm.UseSystemPasswordChar = true;
            this.textBoxConfirm.TextChanged += new System.EventHandler(this.textBoxConfirm_TextChanged);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.Location = new System.Drawing.Point(333, 128);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(273, 27);
            this.textBoxLName.TabIndex = 19;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.Location = new System.Drawing.Point(31, 128);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(273, 27);
            this.textBoxFName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(27, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Confirm Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gmail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "First Name:";
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bt_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Register.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Register.Location = new System.Drawing.Point(101, 485);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(110, 45);
            this.bt_Register.TabIndex = 15;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bt_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Cancel.Location = new System.Drawing.Point(359, 485);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(110, 45);
            this.bt_Cancel.TabIndex = 14;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(222, 377);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(273, 27);
            this.TextBoxPassword.TabIndex = 13;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(222, 329);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(273, 27);
            this.TextBoxUsername.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username:";
            // 
            // errorProviderConfirm
            // 
            this.errorProviderConfirm.ContainerControl = this;
            // 
            // Register_Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(943, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Register_Form";
            this.Text = "Register-22110394";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirm)).EndInit();
            this.ResumeLayout(false);

        }

        public Register_Form()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int otp;

        bool verif()
        {
            if ((TextBoxUsername.Text.Trim() == "")
                || (TextBoxPassword.Text.Trim() == ""))
            {
                return false;
            }
            else    
            { 
                return true; 
            }
        }

        private void Register_Form_Load(object sender, System.EventArgs e)
        {

        }

        private void textBoxConfirm_TextChanged(object sender, System.EventArgs e)
        {
            errorProviderConfirm.Clear();
            if (this.textBoxConfirm.Text != TextBoxPassword.Text)
            {
                errorProviderConfirm.SetError(this.textBoxConfirm, "Password does not match");
            }
            else if (this.textBoxConfirm.Text == TextBoxPassword.Text)
            {
                errorProviderConfirm.Clear();
            }
        }

        private void bt_Register_Click(object sender, System.EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            ACCOUNT account = new ACCOUNT();
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            string firstname = textBoxFName.Text;
            string lastname = textBoxLName.Text;
            string gmail = textBoxGmail.Text;
            string phone = textBoxPhone.Text;


            if (textBoxFName.Text == "")
            {
                MessageBox.Show("Please input First Name", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxLName.Text == "")
            {
                MessageBox.Show("Please input Last Name", "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxGmail.Text == "")
            {
                MessageBox.Show("Please input Email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxGmail.Text == "")
            {
                MessageBox.Show("Please input Phone Number", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Please input Username", "Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Please input Username", "Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxPassword.Text == "")
            {
                MessageBox.Show("Please input Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (TextBoxPassword.Text.Length < 8 || TextBoxPassword.Text.Length > 15)
            {
                MessageBox.Show("Password must be 8 to 15 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxPassword.Text != textBoxConfirm.Text)
            {
                MessageBox.Show("Confirm Password does not match, please check again", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!otp.ToString().Equals(textBoxOTP.Text))
            {
                MessageBox.Show("OTP is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Username Account is already exist, Please Change Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (verif())
                {
                    if (account.insertAccount(username, password, firstname, lastname, gmail, phone))
                    {
                        MessageBox.Show("New Account Added", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, Please Try Again", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void bt_OTP_Click(object sender, System.EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);
                var fromaddr = new MailAddress("phatbeewinform@gmail.com");
                var toaddr = new MailAddress(textBoxGmail.ToString());
                const string frompass = "xjtqlcoadsymgogh";
                const string subject = "OTP Code for Activate Account";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromaddr.Address, frompass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromaddr, toaddr)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("OTP has sent to gmail ", textBoxGmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}