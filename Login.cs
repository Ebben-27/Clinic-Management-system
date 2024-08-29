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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Start_Form start_Form = new Start_Form();
            start_Form.Show();


        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox Password_TextBox = new TextBox();
            Password_TextBox.PasswordChar = '*';
        }

        private void Continue_button_Click(object sender, EventArgs e)
        {
            String text = Username_textBox.Text;
            MessageBox.Show("Welcome back " + text + ".");
            Main main = new Main();
            main.Show();
            this.Hide();
            this.Close();
        }
    }
}
