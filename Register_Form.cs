using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    internal class Register_Form : Form
    {
        private Label label1;
        private Label label2;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button bt_Cancel;
        private Button bt_Register;
        private PictureBox pictureBox1;
        private Label label3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(251, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Register";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(257, 267);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(309, 29);
            this.TextBoxUsername.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(257, 336);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(309, 29);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(391, 435);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(110, 45);
            this.bt_Cancel.TabIndex = 5;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Register
            // 
            this.bt_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Register.Location = new System.Drawing.Point(135, 435);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(110, 45);
            this.bt_Register.TabIndex = 6;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = true;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Register_Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(638, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register_Form";
            this.Text = "Register-22110394";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Register_Form()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void bt_Register_Click(object sender, System.EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            ACCOUNT account = new ACCOUNT();
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Please input Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextBoxPassword.Text == "")
            {
                MessageBox.Show("Please input Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("Username Account is already exist, Please Change Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else if (TextBoxPassword.Text.Length < 8 || TextBoxPassword.Text.Length > 15)
                {
                    MessageBox.Show("Password must be 8 to 15 characters", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information );
                }
                else if (verif())
                {
                    if (account.insertAccount(username, password))
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
    }
}