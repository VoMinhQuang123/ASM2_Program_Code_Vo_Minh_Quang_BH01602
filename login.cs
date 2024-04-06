using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace WinFormsApp10
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim().ToLower();
            string passWord = txtPassword.Text.Trim().ToLower();
            if (userName != "")
            {
                if (userName.Equals("quangvmbh01602") && passWord.Equals("123456"))
                {
                    this.Hide();
                    Funtion funtion = new Funtion();
                    funtion.ShowDialog();
                }
                else if (passWord == "")
                {
                    MessageBox.Show("Please enter a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please enter the correct password account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (userName == "" && passWord != "")
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter your password account information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the program?!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
