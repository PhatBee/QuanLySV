using System.Windows.Forms;

namespace QLSV
{
    internal class StudentSearchForm : Form
    {
        public DataGridView dataGridViewSearch;

        private void InitializeComponent()
        {
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(907, 377);
            this.dataGridViewSearch.TabIndex = 0;
            // 
            // StudentSearchForm
            // 
            this.ClientSize = new System.Drawing.Size(938, 412);
            this.Controls.Add(this.dataGridViewSearch);
            this.Name = "StudentSearchForm";
            this.Load += new System.EventHandler(this.StudentSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        private void StudentSearchForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}