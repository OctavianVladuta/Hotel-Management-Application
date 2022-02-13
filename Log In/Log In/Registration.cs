using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSQL_Accounts;
using DSQL_Users;

namespace Log_In
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public Registration(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Form1 frm = new Form1();

        private void Registration_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            EmailCheck.Visible = false;
            passwordCheck.Visible = false;
            ReTypePasswordCheck.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var DBSQL = new DbSqlServerUsers();
            var DBSQL1 = new DbSqlServerAccounts();

            if (textBoxEmail.Text == "Type your email")
            {
                EmailCheck.Text = "You must complete Email field";
                EmailCheck.Visible = true;
                return;
            }

            if ((!textBoxEmail.Text.Contains("@yahoo.com")) && (!textBoxEmail.Text.Contains("@gmail.com")))
            {
                EmailCheck.Text = "Your Email is invalid";
                EmailCheck.Visible = true;
                return;
            }

            else
                EmailCheck.Visible = false;


            if (textBoxPassword.Text == "Type your password")
            {
                passwordCheck.Text = "You must complete Password field";
                passwordCheck.Visible = true;
                return;
            }

            if (textBoxPassword.Text.Length < 6)
            {
                passwordCheck.Text = "Your password need to contain min. 6 characters";
                passwordCheck.Visible = true;
                return;
            }

            if (textBoxRetypePassword.Text == "Re-type your password")
            {
                passwordCheck.Text = "You must complete this field";
                passwordCheck.Visible = true;
                return;
            }

            if (textBoxRetypePassword.Text != textBoxPassword.Text)
            {
                ReTypePasswordCheck.Text = "Your passwords doesn't match";
                ReTypePasswordCheck.Visible = true;
                return;
            }


            Users user = new Users();
            user.Id = id();
            user.Email = textBoxEmail.Text;
            user.Password = textBoxPassword.Text;
            Accounts account = new Accounts();
            account.Id = user.Id;

            frm.userslist.usersList.Add(user);
            DBSQL.Create(user);
            DBSQL1.Create(account);
            MessageBox.Show("Your registration has been successful");
            this.Close();
            frm.Show();
        }

        public int id()
        {
            int i = 1;
            foreach (var user in frm.userslist.usersList)
            {
                if (i != user.Id)
                    return i;
                i++;
            }
            return frm.userslist.usersList.Count + 1;
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Type your email")
            {
                textBoxEmail.Text = "";
                EmailCheck.Visible = false;
                textBoxEmail.ForeColor = Color.Black;
            }
            else
                EmailCheck.Visible = false;

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if ((!textBoxEmail.Text.Contains("@yahoo.com")) && (!textBoxEmail.Text.Contains("@gmail.com")))
            {
                EmailCheck.Text = "Your Email is invalid";
                EmailCheck.Visible = true;
            }
            else
                EmailCheck.Visible = false;

            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type your email";
                EmailCheck.Visible = false;
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type your password")
            {
                textBoxPassword.Text = "";
                passwordCheck.Visible = false;
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }
            else
                passwordCheck.Visible = false;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 6)
            {
                passwordCheck.Text = "Your password need to contain min. 6 characters";
                passwordCheck.Visible = true;
            }
            else
                passwordCheck.Visible = false;

            if (textBoxPassword.Text == "")
            {
                textBoxPassword.PasswordChar = '\0';
                passwordCheck.Visible = false;
                textBoxPassword.Text = "Type your password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxRetypePassword_Enter(object sender, EventArgs e)
        {
            if (textBoxRetypePassword.Text == "Re-type your password")
            {
                textBoxRetypePassword.Text = "";
                ReTypePasswordCheck.Visible = false;
                textBoxRetypePassword.PasswordChar = '*';
                textBoxRetypePassword.ForeColor = Color.Black;
            }
            else
                ReTypePasswordCheck.Visible = false;

        }

        private void textBoxRetypePassword_Leave(object sender, EventArgs e)
        {
            if (textBoxRetypePassword.Text != textBoxPassword.Text)
            {
                ReTypePasswordCheck.Text = "Your passwords doesn't match";
                ReTypePasswordCheck.Visible = true;
            }
            else
                ReTypePasswordCheck.Visible = false;

            if (textBoxRetypePassword.Text == "")
            {
                textBoxRetypePassword.PasswordChar = '\0';
                ReTypePasswordCheck.Visible = false;
                textBoxRetypePassword.Text = "Re-type your password";
                textBoxRetypePassword.ForeColor = Color.Gray;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
