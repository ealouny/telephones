namespace WinFormApps
{
    partial class frmAdmin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comDept);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtComments);
            this.panel1.Controls.Add(this.txtExt);
            this.panel1.Controls.Add(this.txtPhone2);
            this.panel1.Controls.Add(this.txtPhone1);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtDept);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(74, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 257);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(657, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Devision/Department list";
            // 
            // comDept
            // 
            this.comDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDept.FormattingEnabled = true;
            this.comDept.Location = new System.Drawing.Point(657, 47);
            this.comDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comDept.Name = "comDept";
            this.comDept.Size = new System.Drawing.Size(190, 28);
            this.comDept.TabIndex = 23;
            this.comDept.SelectedIndexChanged += new System.EventHandler(this.comDept_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 233);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1359, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(891, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Notes/Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone 2 (Mobile)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone 1 (Office)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search by first name, last name, extension or phone numbers";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(891, 121);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 27);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(657, 199);
            this.txtComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(527, 27);
            this.txtComments.TabIndex = 10;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(455, 199);
            this.txtExt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(167, 27);
            this.txtExt.TabIndex = 9;
            this.txtExt.TextChanged += new System.EventHandler(this.txtExt_TextChanged);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(257, 199);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(167, 27);
            this.txtPhone2.TabIndex = 8;
            this.txtPhone2.TextChanged += new System.EventHandler(this.txtPhone2_TextChanged);
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(53, 199);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(167, 27);
            this.txtPhone1.TabIndex = 7;
            this.txtPhone1.TextChanged += new System.EventHandler(this.txtPhone1_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(463, 121);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(167, 27);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(657, 121);
            this.txtDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(190, 27);
            this.txtDept.TabIndex = 5;
            this.txtDept.TextChanged += new System.EventHandler(this.txtDept_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(257, 121);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(167, 27);
            this.txtLName.TabIndex = 3;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(53, 121);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(167, 27);
            this.txtFName.TabIndex = 2;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(53, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAdmin);
            this.panel2.Location = new System.Drawing.Point(74, 367);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 391);
            this.panel2.TabIndex = 1;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(3, 4);
            this.dgvAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 25;
            this.dgvAdmin.Size = new System.Drawing.Size(1361, 321);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 297);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(244, 297);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 44);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(360, 298);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(476, 297);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 44);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(629, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1062, 315);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 27);
            this.txtID.TabIndex = 16;
            this.txtID.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(732, 785);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 44);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 855);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.Text = "Administrator Portal - Telephone Directory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtComments;
        private TextBox txtExt;
        private TextBox txtPhone2;
        private TextBox txtPhone1;
        private TextBox txtTitle;
        private TextBox txtDept;
        private TextBox txtLName;
        private TextBox txtFName;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvAdmin;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private StatusStrip statusStrip1;
        private TextBox txtID;
        private ComboBox comDept;
        private Label label11;
        private Button btnClose;
    }
}