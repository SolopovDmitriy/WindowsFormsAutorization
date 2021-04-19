using MySql.Data.MySqlClient;
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

namespace WindowsFormsAutorization
{
    public partial class LoginForm1 : Form
    {
        Point mouseDownPoint;
        public LoginForm1()
        {
            InitializeComponent();
            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 46);
        }

        private void buttonClosedForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void buttonTurnForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExpansionForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void textBoxUser_MouseEnter(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.FromArgb(94, 94, 88);
        }

        private void textBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.FromArgb(94, 94, 88);
        }

        private void textBoxUser_MouseLeave(object sender, EventArgs e)
        {
            textBoxUser.BackColor = Color.White;
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }
      
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void buttonCome_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxUser.Text;
            String passUser = textBoxPassword.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(); 
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login=@uL AND password=@uP", db.getConnection());
            //MySqlCommand command = new MySqlCommand($"SELECT * FROM users WHERE login='{loginUser}' AND password='{passUser}'", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            MySqlParameter loginUserParam = new MySqlParameter("@uL", loginUser);
            command.Parameters.Add(loginUserParam);
            MySqlParameter passUserParam = new MySqlParameter("@uP", passUser);
            command.Parameters.Add(passUserParam);

            this.Text = command.CommandText;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm1 mainForm1 = new MainForm1();
                mainForm1.Show();
                //MessageBox.Show("Yes, this user is authorized"); 
            }
            else
            {
                MessageBox.Show("No, this user is not logged in");
            }

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
