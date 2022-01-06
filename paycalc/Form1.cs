namespace paycalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtboxFullname.Text == "" && txtboxUsername.Text == "" && txtboxPassword.Text == "" && txtboxRepeat.Text == "")
            {
                MessageBox.Show("Fullname, Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtboxPassword.Text == txtboxRepeat.Text)
            { 

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match", "Please Re-enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPassword.Text = "";
                txtboxRepeat.Text = "";
                txtboxRepeat.Focus();
                txtboxPassword.Focus();
            }

        }
        private void btnLoginInstead_Click(object sender, EventArgs e)
        {

        }
    }
}
