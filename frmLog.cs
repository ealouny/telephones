using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormApps
{
    public partial class frmLog : Form
    {
        //clsData c = new clsData();
        //public string user_right = "";
        public frmLog()
        {
            InitializeComponent();
            txtUser.Text = "";
            txtPwd.Text = "";

            txtUser.Text = "";
            txtPwd.Text = "";

            txtUser.Focus();    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           //Hard code for Login
           //User either admin or employee
           //Administrator -> username: admin
           //                 password:  admin
           //Emploee       -> username: emp
           //              _> password: emp             

            if (txtUser.Text  !=  "" &&  txtPwd.Text != "" ) 
            {
                //textBox1.Text =  "";               
                if ((txtUser.Text) == "admin")
                {
                    frmAdmin f = new frmAdmin();
                    f.Show();
                    this.Hide();
                }
                else if ((txtUser.Text) ==  "emp")
                {
                    frmTelephoneDir frm = new frmTelephoneDir();    
                    frm.Show();
                    this.Hide();
                }                            
            }
            else
            {
                MessageBox.Show("Username and password required.");
                txtUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
    }
}