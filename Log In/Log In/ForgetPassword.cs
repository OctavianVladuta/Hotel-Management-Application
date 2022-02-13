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
using DSQL_Users;

namespace Log_In
{
    public partial class ForgetPassword : Form
    {
        SqlCommandBuilder cmbld;
        SqlDataAdapter da;
        DataSet ds;

        public ForgetPassword()
        {
            InitializeComponent();
        }

        public ForgetPassword(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }
        Form1 frm = new Form1();

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type your new password")
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
                textBoxPassword.Text = "Type your new password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxRetypePassword_Enter(object sender, EventArgs e)
        {
            if (textBoxRetypePassword.Text == "Re-type your new password")
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
                textBoxRetypePassword.Text = "Re-type your new password";
                textBoxRetypePassword.ForeColor = Color.Gray;
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
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


            if (textBoxPassword.Text == "Type your new password")
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

            if (textBoxRetypePassword.Text == "Re-type your new password")
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
            user.Email = textBoxEmail.Text;
            bool Start = true;

            foreach (var User in frm.userslist.usersList)
            {
                if (user.Email == User.Email)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        if (ds.Tables[0].Rows[i][1].ToString() == textBoxEmail.Text)
                        {
                            ds.Tables[0].Rows[i][2] = textBoxPassword.Text;
                            da.Update(ds.Tables["users"]);
                        }

                    MessageBox.Show("Your password has been changed");
                    this.Close();
                    frm.Show();
                    Start = false;
                }
            }

            frm.userslist.usersList.Clear();
            foreach (var users in new DbSqlServerUsers().GetAll())
            {
                frm.userslist.usersList.Add(users);
            }

            if (Start == true)
            {
                MessageBox.Show("Email doesn't exists");
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            textBoxEmail.Focus();
            EmailCheck.Visible = false;
            passwordCheck.Visible = false;
            ReTypePasswordCheck.Visible = false;
            da = new SqlDataAdapter("Select * from Users", DbSqlServerUsers.con);
            ds = new DataSet();
            cmbld = new SqlCommandBuilder(da);
            da.Fill(ds, "users");
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
