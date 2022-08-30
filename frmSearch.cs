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

namespace WinFormApps
{
    public partial class frmSearch : Form
    {
        clsData d = new clsData();
        bool bSearch = false;
        SqlDataAdapter da;
        public SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        public frmSearch()
        {
            InitializeComponent();

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {          
          txtSearch.Focus();
        }

        private void get_search_data(string str_search)
        {
            using (SqlConnection connection = new SqlConnection(d.conn_string))
            {
                var bindingSource = new BindingSource();
              
               string sql_search = "SELECT * From tblTelephones where FName =  '"
                 + txtSearch.Text + "' or LName = '" + txtSearch.Text + "' or ext = '"
                 + txtSearch.Text + "' or Phone1 = '" + txtSearch.Text + "' or Phone2 = '"
                 + txtSearch.Text + "'";


                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_search, connection))
                {
                    try
                    {
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        bindingSource.DataSource = table;
                        dgvSearch.ReadOnly = true;
                        dgvSearch.DataSource = bindingSource;
                        dgvSearch.Columns[0].Visible = false;
                        dgvSearch.Columns[1].HeaderText = "First Name";
                        dgvSearch.Columns[2].HeaderText = "Last Name";
                        dgvSearch.Columns[3].HeaderText = "Department";
                        dgvSearch.Columns[4].HeaderText = "Title";
                        dgvSearch.Columns[5].HeaderText = "Email";
                        dgvSearch.Columns[6].HeaderText = "Phone (Office)";
                        dgvSearch.Columns[7].HeaderText = "Phone (Mobile)";
                        dgvSearch.Columns[8].HeaderText = "Extension";
                        dgvSearch.Columns[9].HeaderText = "Notes/Comments";
                        dgvSearch.Columns[10].Visible = false;
                        dgvSearch.Columns[11].Visible = false;
                        dgvSearch.Columns[12].Visible = false;
                        dgvSearch.MultiSelect = false;
                        dgvSearch.Columns[5].Width = 210;
                        dgvSearch.Columns[9].Width = 230;
                        dgvSearch.AllowUserToResizeRows = false;
                        dgvSearch.AllowUserToResizeColumns = false;
                        dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvSearch.MultiSelect = false;
                        dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
                        dgvSearch.BackgroundColor = Color.White;
                        
                        foreach (DataGridViewColumn col in dgvSearch.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        dgvSearch.EnableHeadersVisualStyles = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSearch.DataSource = null;
            dgvSearch.Rows.Clear();
            dgvSearch.Refresh();
            if (txtSearch.Text != "")
            {                
                get_search_data(txtSearch.Text.Trim());
            }
            else
            {
                MessageBox.Show("Searching text is requred, the field cannot be empty.");
                txtSearch.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public void getData()
        {
            using (SqlConnection connection = new SqlConnection(d.conn_string))
            {
                var bindingSource = new BindingSource();
                string sql = "select * from tblTelephones order by Dept";

                string sql_search = "";
                //If searching perform, 
                if (bSearch == true)
                {
                    sql_search = "SELECT * From tblTelephones where FName =  '"
                   + txtSearch.Text + "' or LName = '" + txtSearch.Text + "' or ext = '"
                   + txtSearch.Text + "' or Phone1 = '" + txtSearch.Text + "' or Phone2 = '"
                   + txtSearch.Text + "'";
                }
                else
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection))
                    {
                        try
                        {
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            bindingSource.DataSource = table;
                            dgvSearch.ReadOnly = true;
                            dgvSearch.DataSource = bindingSource;
                            dgvSearch.Columns[0].Visible = false;
                            dgvSearch.Columns[1].HeaderText = "First Name";
                            dgvSearch.Columns[2].HeaderText = "Last Name";
                            dgvSearch.Columns[3].HeaderText = "Department";
                            dgvSearch.Columns[4].HeaderText = "Title";
                            dgvSearch.Columns[5].HeaderText = "Email";
                            dgvSearch.Columns[6].HeaderText = "Phone (Office)";
                            dgvSearch.Columns[7].HeaderText = "Phone (Mobile)";
                            dgvSearch.Columns[8].HeaderText = "Extension)";
                            dgvSearch.Columns[9].HeaderText = "Notes/Comments)";
                            dgvSearch.Columns[10].Visible = false;
                            dgvSearch.Columns[11].Visible = false;
                            dgvSearch.Columns[12].Visible = false;
                            dgvSearch.Columns[5].Width = 210;
                            dgvSearch.Columns[9].Width = 230;
                            dgvSearch.MultiSelect = false;
                            dgvSearch.AllowUserToResizeRows = false;
                            dgvSearch.AllowUserToResizeColumns = false;
                            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvSearch.MultiSelect = false;
                            dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;

                            dgvSearch.BackgroundColor = Color.White;

                            foreach (DataGridViewColumn col in dgvSearch.Columns)
                            {
                                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                            dgvSearch.EnableHeadersVisualStyles = false;
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
    }
}
