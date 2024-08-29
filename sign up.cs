using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Storage
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void Signup_Password_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Signup_Password_textbox = new TextBox();
            Signup_Password_textbox.PasswordChar = '*';

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Start_Form start_Form = new Start_Form();
            start_Form.Show();

            this.Hide();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        

        private void Register_button_Click(object sender, EventArgs e)
        {
            String text = Signup_Username_textBox.Text;
            MessageBox.Show("Hello " + text + " welcome to the Clinic Management system.");
            Main main = new Main();
            main.Show();
            this.Hide();
            this.Close();
        }

        private void Signup_progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
