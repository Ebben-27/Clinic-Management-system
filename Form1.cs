namespace C_Storage
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void Login_button1_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            sign_up myForm = new sign_up();
            this.Hide();    
            myForm.ShowDialog();

        }
    }
}
