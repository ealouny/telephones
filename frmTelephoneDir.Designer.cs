namespace WinFormApps
{
    partial class frmTelephoneDir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comDept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comDept);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(74, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 87);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Division/Department";
            // 
            // comDept
            // 
            this.comDept.FormattingEnabled = true;
            this.comDept.Location = new System.Drawing.Point(566, 31);
            this.comDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comDept.Name = "comDept";
            this.comDept.Size = new System.Drawing.Size(197, 28);
            this.comDept.TabIndex = 22;
            this.comDept.SelectedIndexChanged += new System.EventHandler(this.comDept_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Search by first name, last name, extension or phone numbers ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(59, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(70, 122);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 29;
            this.dgvEmployees.Size = new System.Drawing.Size(1361, 578);
            this.dgvEmployees.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(718, 733);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTelephoneDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 784);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmTelephoneDir";
            this.Text = "Employee Portal - Telephone Directory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private DataGridView dgvEmployees;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTitle;
        private TextBox txtDept;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtSearch;
        private TextBox txtComments;
        private TextBox txtExt;
        private TextBox txtPhone2;
        private TextBox txtPhone1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label11;
        private ComboBox comDept;
        private Button btnClose;
    }
}