using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSQL_Users;
using System.Windows.Input;

namespace Log_In
{
    public partial class Form1 : Form
    {
        internal UsersList userslist = new UsersList();
        internal Users userdefault = new Users();
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Registration")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                this.Hide();
                Registration frm = new Registration(this);
                frm.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Type your email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type your email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type your password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;

            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Type your password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            bool Start = true;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Interface")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {

                Users user = new Users();
                user.Email = textBoxEmail.Text;
                user.Password = textBoxPassword.Text;

                if (user.Email == "admin" && user.Password == "123456")
                {
                    this.Hide();
                    AdminInterface frm = new AdminInterface(this);
                    loginCheck.Visible = false;
                    frm.Show();
                    Start = false;
                }
                else
                {
                    foreach (var User in userslist.usersList)
                    {
                        if (user.Equals(User))
                        {
                            this.Hide();
                            Interface frm = new Interface(this);
                            loginCheck.Visible = false;
                            userdefault = User;
                            frm.Show();
                            Start = false;
                        }
                    }
                }
                if (Start == true)
                {
                    loginCheck.Text = "Username or/and Password are wrong";
                    loginCheck.Visible = true;
                }
            }



            //textBoxPassword.PasswordChar = '\0';
            //textBoxPassword.Text = "Type your password";
            //textBoxPassword.ForeColor = Color.Gray;
            //textBoxEmail.Text = "";
            //textBoxEmail.ForeColor = Color.Gray;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginCheck.Visible = false;
            userslist.usersList.Clear();
            foreach (var users in new DbSqlServerUsers().GetAll())
            {
                userslist.usersList.Add(users);
            }
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ForgetPassword")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                this.Hide();
                ForgetPassword frm = new ForgetPassword(this);
                frm.Show();

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
