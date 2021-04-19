using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAutorization
{
    public partial class RegisterForm : Form
    {
        Point mouseDownPoint;
        private Color textBoxBackColorGrey;


        public RegisterForm()
        {
            InitializeComponent();

            textBoxBackColorGrey = Color.FromArgb(94, 94, 88);
            textBoxRegistrationName.Text = "Enter your name";
            textBoxRegistrationSurname.Text = "Enter your surname";
        }

        private void buttonClosedForm_Click(object sender, EventArgs e)
        {

            Application.Exit();
            //this.Close();
        }

        private void buttonExpansionForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonTurnForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxRegistrationName_MouseEnter(object sender, EventArgs e)
        {
            textBoxRegistrationName.BackColor = textBoxBackColorGrey;
        }

        private void textBoxRegistrationSurname_MouseEnter(object sender, EventArgs e)
        {
            textBoxRegistrationSurname.BackColor = textBoxBackColorGrey;
        }

        private void textBoxUser_MouseEnter(object sender, EventArgs e)
        {
            textBoxUser.BackColor = textBoxBackColorGrey;
        }

        private void textBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = textBoxBackColorGrey;
        }

        private void buttonClosedForm_MouseEnter(object sender, EventArgs e)
        {
            buttonClosedForm.BackColor = Color.FromArgb(235, 64, 52);
        }

        private void bottonRegister_MouseEnter(object sender, EventArgs e)
        {
            bottonRegister.BackColor = textBoxBackColorGrey;
        }

        

        private void textBoxRegistrationName_MouseLeave(object sender, EventArgs e)
        {
            textBoxRegistrationName.BackColor = Color.White;
            if (textBoxRegistrationName.Text == "")
            {
                textBoxRegistrationName.Text = "Enter your name";
                textBoxRegistrationName.ForeColor = Color.White;
            }
        }

        private void textBoxRegistrationSurname_MouseLeave(object sender, EventArgs e)
        {
            textBoxRegistrationSurname.BackColor = Color.White;
            if (textBoxRegistrationSurname.Text == "")
            {
                textBoxRegistrationSurname.Text = "Enter your surname";
                textBoxRegistrationSurname.ForeColor = Color.White;
            }

        }

        private void textBoxUser_MouseLeave(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void bottonRegister_MouseLeave(object sender, EventArgs e)
        {
            bottonRegister.BackColor = Color.White;
        }

        private void buttonClosedForm_MouseLeave(object sender, EventArgs e)
        {
            buttonClosedForm.BackColor = Color.White;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownPoint.X;
                this.Top += e.Y - mouseDownPoint.Y;

                // 234678
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void textBoxRegistrationName_Enter(object sender, EventArgs e)
        {
            if (textBoxRegistrationName.Text == "Enter your name")
            {
                textBoxRegistrationName.Text = "";
            }
        }

        private void textBoxRegistrationSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxRegistrationSurname.Text == "Enter your surname")
            {
                textBoxRegistrationSurname.Text = "";

            }
        }

        private void bottonRegister_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
        }
    }
}
