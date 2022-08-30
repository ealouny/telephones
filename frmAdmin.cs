using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormApps
{
    public partial class frmAdmin : Form
    {
        private clsData d = new clsData();  
        SqlDataAdapter da;
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        //public string constr = "Data Source=DESKTOP-SNS8QH5\\SQLEXPRESS;Initial Catalog=Telephone; Integrated Security=SSPI;";
       
        public frmAdmin()
        {
            InitializeComponent();
            getData();
           
            btnEdit.Enabled = false;                
            btnDelete.Enabled = false;

            dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Disable_TextFileds();
            getcombolistbox();
            txtSearch.Focus();
        }

        public void getData()
        {
            using (SqlConnection connection = new SqlConnection(d.conn_string))
            {
                var bindingSource = new BindingSource();
                string my_sql =  "select * from tblTelephones order by Dept";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(my_sql, connection))
                {
                    try
                    {
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bindingSource.DataSource = table;
                        dgvAdmin.ReadOnly = true;
                        dgvAdmin.DataSource = bindingSource;
                        dgvAdmin.Columns[0].Visible = false;                     
                        dgvAdmin.Columns[1].HeaderText = "First Name";
                        dgvAdmin.Columns[2].HeaderText = "Last Name";
                        dgvAdmin.Columns[3].HeaderText = "Department";
                        dgvAdmin.Columns[4].HeaderText = "Title";
                        dgvAdmin.Columns[5].HeaderText = "Email";
                        dgvAdmin.Columns[6].HeaderText = "Phone (Office)";
                        dgvAdmin.Columns[7].HeaderText = "Phone (Mobile)";
                        dgvAdmin.Columns[8].HeaderText = "Extension";
                        dgvAdmin.Columns[9].HeaderText = "Notes/Comments";
                        dgvAdmin.Columns[10].Visible = false;
                        dgvAdmin.Columns[11].Visible = false;
                        dgvAdmin.Columns[12].Visible = false;
                        dgvAdmin.MultiSelect = false;
                        dgvAdmin.Columns[5].Width = 210;
                        dgvAdmin.Columns[9].Width = 230;
                        dgvAdmin.AllowUserToResizeRows = false;
                        dgvAdmin.AllowUserToResizeColumns = false;
                        dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvAdmin.MultiSelect = false;
                        dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
                        dgvAdmin.BackgroundColor = Color.White;
                        btnUpdate.Enabled = false;
                        foreach (DataGridViewColumn col in dgvAdmin.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        dgvAdmin.EnableHeadersVisualStyles = false;
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR Loading ...");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                dgvAdmin.Columns[0].Visible = false;
                dgvAdmin.Columns[1].HeaderText = "First Name";
                Clear_TextFields();
                string sql = "SELECT * From tblTelephones where FName =  '"
                  + txtSearch.Text + "' or LName = '" + txtSearch.Text + "' or ext = '"
                  + txtSearch.Text + "' or Phone1 = '" + txtSearch.Text + "' or Phone2 = '"
                  + txtSearch.Text + "'";
                SqlConnection conn = new SqlConnection(d.conn_string);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtID.Text = reader.GetValue(0).ToString();
                    txtFName.Text = reader.GetValue(1).ToString();
                    txtLName.Text = reader.GetValue(2).ToString();
                    txtDept.Text = reader.GetValue(3).ToString();
                    txtTitle.Text = reader.GetValue(4).ToString();
                    txtEmail.Text = reader.GetValue(5).ToString();
                    txtPhone1.Text = reader.GetValue(6).ToString();
                    txtPhone2.Text = reader.GetValue(7).ToString();
                    txtExt.Text = reader.GetValue(8).ToString();
                    txtComments.Text = reader.GetValue(9).ToString();
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                }
                else
                {
                    txtSearch.Focus();  
                    MessageBox.Show("NO data found in the record...");
                }
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                Clear_TextFields(); 
                Enable_TextFileds();
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;    
                btnUpdate.Text = "Save";
                btnUpdate.Enabled = false;                
                btnDelete.Enabled = false;  
                txtFName.Focus();
            }
            else if (btnUpdate.Text == "Update")
            {                
                            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Add the records
            SqlConnection conn = new SqlConnection(d.conn_string);
            if (txtID.Text == "")
            {              
                if (IsTextFieldValid())
                {
                    btnAdd.Text = "Add";
                    string sql = "insert into tblTelephones(UID,FName,LName,Dept,Title,";
                           sql += "Email,Phone1,Phone2,Ext,Comments,Dept_OrderId,IsActive,";
                           sql += "Empl_OrderId) values(@uid,@fname,@lname,@dept,@title,";
                           sql += "@email,@phone1,@phone2,@ext,@comments,@dept_orderid,";
                           sql += "@isactive,@empl_orderid)";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@uid", SqlDbType.UniqueIdentifier).Value= Guid.NewGuid();
                    cmd.Parameters.AddWithValue("@fname", txtFName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@dept", txtDept.Text);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone1", txtPhone1.Text);
                    cmd.Parameters.AddWithValue("@phone2", txtPhone2.Text);
                    cmd.Parameters.AddWithValue("@ext", txtExt.Text);
                    cmd.Parameters.AddWithValue("@comments", txtComments.Text);
                    int dept_id = 0;
                    dept_id = Get_DeptOrderId(txtDept.Text);
                    int empl_id = 0;
                    empl_id = Get_EmplOrderId (txtTitle.Text);
                    cmd.Parameters.AddWithValue("@dept_orderid", dept_id);
                    cmd.Parameters.AddWithValue("@isactive", 1);
                    cmd.Parameters.AddWithValue("@empl_orderid",empl_id );
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    MessageBox.Show("Employee info was added successfully");
                    Clear_TextFields();    
                    DisplayData();
                }
            }
            else 
            //Update the records
            {
                if (txtID.Text != "")
                {
                    string sql = "update tblTelephones set FName=@fname,LName=@lname,";
                    sql += "Dept=@dept,Title=@title,Email=@email,Phone1=@phone1,";
                    sql += "Phone2=@phone2,Ext=@ext,Comments=@comments,Dept_OrderId=@dept_orderid, ";
                    sql += "IsActive=@isactive,Empl_OrderId=@empl_orderid";
                    sql += " where UID=@uid";
                    
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@uid", txtID.Text);
                    cmd.Parameters.AddWithValue("@fname", txtFName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                    cmd.Parameters.AddWithValue("@dept", txtDept.Text);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone1", txtPhone1.Text);
                    cmd.Parameters.AddWithValue("@phone2", txtPhone2.Text);
                    cmd.Parameters.AddWithValue("@ext", txtExt.Text);
                    cmd.Parameters.AddWithValue("@comments", txtComments.Text);
                    int dept_id = 0;
                    dept_id = Get_DeptOrderId(txtDept.Text);
                    int empl_id = 0;
                    empl_id = Get_EmplOrderId(txtTitle.Text);
                    cmd.Parameters.AddWithValue("@dept_orderid", dept_id);
                    cmd.Parameters.AddWithValue("@isactive", 1);
                    cmd.Parameters.AddWithValue("@empl_orderid", empl_id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee info was updated successfully");
                    Clear_TextFields();
                    DisplayData();
                }
            }            
        }

        private int Get_DeptOrderId(string dept)
        {
            int sVal = 0;
            if (dept == "Finance")
            {
                sVal = 2;
            }
            else if(dept == "HR")
            {
                sVal = 3;
            }
            else if (dept == "Engineer")
            {
                sVal = 4;
            }
            else if (dept== "IT")
            {
                sVal = 5;
            }            
           return sVal;
        }

        private int Get_EmplOrderId(string title)
        {
            int sVal = 0;
            if (title == "VP")
            {
                sVal = 1;
            }
            else if (title == "Director")
            {
                sVal = 2;
            }
            else if (title == "Assistant Director")
            {
                sVal = 3;
            }
            else if (title == "Manager")
            {
                sVal = 4;
            }
            else if  (title == "Assistant Manager")
            {
                sVal = 5;
            } 
            else if (title == "Supervisor")
            {
                sVal = 6;
            }
            else if (title == "Employee")
            {
                sVal = 9;
            }

            return sVal;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" || txtLName.Text != "")
            {
                btnEdit.Enabled = false;
                btnUpdate.Text = "Update";
                btnDelete.Enabled = false;
                Enable_TextFileds();
                txtFName.Focus();
            }
            else 
            {
                Disable_TextFileds();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete records
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Do you want to delete this record?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from tblTelephones where UID=@uid";
                    SqlConnection conn = new SqlConnection(d.conn_string);
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@uid", txtID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    Clear_TextFields();
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear_TextFields();
            Disable_TextFileds();

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;
            txtSearch.Text = "";
        }  
        
        //Test only
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               MessageBox.Show("Enter key pressed 1");                
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed 2");
            }
        }            

        public bool IsTextFieldValid()
        {
            bool retVal;
            retVal = false;

            if (txtFName.Text != "" && txtLName.Text != "" && txtDept.Text != "" && txtTitle.Text != "")
            {

                retVal = true;
            }
            else
            {
                MessageBox.Show("Please enter the required text field before saving.");
            }
            return retVal;
         }


        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // var sender_datagridview = (DataGridView)sender;
           // if (sender_datagridview.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != 0)
           // {

           // }
           // else
            //{ 
            txtID.Text = dgvAdmin.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dgvAdmin.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dgvAdmin.CurrentRow.Cells[2].Value.ToString();
            txtDept.Text = dgvAdmin.CurrentRow.Cells[3].Value.ToString();
            txtTitle.Text = dgvAdmin.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvAdmin.CurrentRow.Cells[5].Value.ToString();
            txtPhone1.Text = dgvAdmin.CurrentRow.Cells[6].Value.ToString();
            txtPhone2.Text = dgvAdmin.CurrentRow.Cells[7].Value.ToString();
            txtExt.Text = dgvAdmin.CurrentRow.Cells[8].Value.ToString();
            txtComments.Text = dgvAdmin.CurrentRow.Cells[9].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
            btnUpdate.Text = "Update";
            btnEdit.Enabled = true ;
            //}           
        }
        
        //Display All Data in DataGridView  
        private void DisplayData()             
        {
             string sql = "select * from tblTelephones order by dept";
             SqlConnection conn = new SqlConnection(d.conn_string);             
             conn.Open();
             DataTable dt = new DataTable();
             da = new SqlDataAdapter(sql, conn);
             da.Fill(dt);
             dgvAdmin.DataSource = dt;
             conn.Close();
        }

        //Display Data in combobox / populate combobox 
        private void DisplayEachDept()
        {
            string sql = "select dept from tblTelephones group by ";
                   sql += "dept order by dept";
            SqlConnection conn = new SqlConnection(d.conn_string);
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dgvAdmin.DataSource = dt;
            conn.Close();
        }

        //Display data each department on datagridview
        private void DisplayEachDeptInfo(string str)
        {
            string sql = "select * from tblTelephones  where ";
            sql += "dept = '" + str + "'order ";
            sql += "by empl_orderid asc, lname asc";

            string sql_all = "select * from tblTelephones order ";
                   sql_all += " by lname asc";

            SqlConnection conn = new SqlConnection(d.conn_string);
            conn.Open();
            DataTable dt = new DataTable();
            if (str == "All")
            {
                da = new SqlDataAdapter(sql_all, conn);
            }
            else
            {
                da = new SqlDataAdapter(sql, conn);
            }
            da.Fill(dt);
            dgvAdmin.DataSource = dt;
            conn.Close();
        }

        private void Clear_TextFields()
        {           
            txtID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtDept.Text = "";
            txtTitle.Text = "";
            txtEmail.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtExt.Text = "";
            txtComments.Text = "";
        }

       private void Disable_TextFileds()
        {
            txtFName.Enabled = false;
            txtLName.Enabled=   false;
            txtDept.Enabled = false;    
            txtTitle.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone1.Enabled   = false;
            txtPhone2.Enabled = false;
            txtExt.Enabled= false;
            txtComments.Enabled = false;            
        }

        private void Enable_TextFileds()
        {
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtDept.Enabled = true;
            txtTitle.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone1.Enabled = true;
            txtPhone2.Enabled = true;
            txtExt.Enabled = true;
            txtComments.Enabled = true;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true; 
            btnUpdate.Enabled = true;            
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtPhone1_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void txtExt_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            try
            {
                int temp = Convert.ToInt32(txtExt.Text);
            }
            catch (Exception)
            {
               // MessageBox.Show("Please provide number only - extension should be a number.");
            }
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }
               

        private void getcombolistbox()
        {
            conn = new SqlConnection(d.conn_string);
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Dept FROM tblTelephones Group By Dept Order by Dept;";
            dr = cmd.ExecuteReader();
            comDept.Items.Add("All");
            while (dr.Read())
            {        
            
                comDept.ValueMember = "OrderID";
                comDept.Items.Add(dr["Dept"]);
            }
            conn.Close();
        }

        private void comDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            str = comDept.Text;
            if ((comDept.Items.Count > 0) && (comDept.Items.ToString() == "All"))
            {
                MessageBox.Show("Message ALL");
            }
            else
            {
                comDept.Text = comDept.Items.ToString();
                DisplayEachDeptInfo(str);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
 }

 