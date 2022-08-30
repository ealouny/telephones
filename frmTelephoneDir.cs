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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormApps
{
    public partial class frmTelephoneDir : Form
    {
        frmSearch f = new frmSearch();
        clsData d = new clsData();
        SqlDataAdapter da;
        public SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        //string constr = "Data Source=DESKTOP-SNS8QH5\\SQLEXPRESS;Initial Catalog=Telephone; Integrated Security=SSPI;";
        public bool bSearch = false;
        public frmTelephoneDir()
        {
            InitializeComponent();
            getData();
            getcombolistbox();  
          
        }

        public void getData()
        {           
            using (SqlConnection connection = new SqlConnection(d.conn_string))
            {
                var bindingSource = new BindingSource();
                string sql = "select * from tblTelephones order by lname";
                                
                if (bSearch == false)
                {                 
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, connection))
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            bindingSource.DataSource = dt;
                            dgvEmployees.ReadOnly = true;
                            dgvEmployees.DataSource = bindingSource;
                            dgvEmployees.Columns[0].Visible = false;
                            dgvEmployees.Columns[1].HeaderText = "First Name";
                            dgvEmployees.Columns[2].HeaderText = "Last Name";
                            dgvEmployees.Columns[3].HeaderText = "Department";
                            dgvEmployees.Columns[4].HeaderText = "Title";
                            dgvEmployees.Columns[5].HeaderText = "Email";
                            dgvEmployees.Columns[6].HeaderText = "Phone (Office)";
                            dgvEmployees.Columns[7].HeaderText = "Phone (Mobile)";
                            dgvEmployees.Columns[8].HeaderText = "Extension)";
                            dgvEmployees.Columns[9].HeaderText = "Notes/Comments)";
                            dgvEmployees.Columns[10].Visible = false;
                            dgvEmployees.Columns[11].Visible = false;
                            dgvEmployees.Columns[12].Visible = false;
                            dgvEmployees.Columns[5].Width = 210;
                            dgvEmployees.Columns[9].Width = 230;
                            dgvEmployees.MultiSelect = false;
                            dgvEmployees.AllowUserToResizeRows = false;
                            dgvEmployees.AllowUserToResizeColumns = false;
                            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvEmployees.MultiSelect = false;
                            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

                            dgvEmployees.BackgroundColor = Color.White;

                            foreach (DataGridViewColumn col in dgvEmployees.Columns)
                            {
                                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                            dgvEmployees.EnableHeadersVisualStyles = false;
                        }

                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "ERROR Loading");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    } 
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {               
           // f.Show();
            f.ShowDialog();;         
        }      
           
              
        private void DisplayEachDeptInfo(string str)
        {
            string sql = "select * from tblTelephones  where ";
            sql += "dept = '" + str + "'order by empl_orderid asc,";
            sql += "lname asc";

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
            dgvEmployees.DataSource = dt;
            conn.Close();
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

                comDept.ValueMember = "Dept_OrderID";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
   