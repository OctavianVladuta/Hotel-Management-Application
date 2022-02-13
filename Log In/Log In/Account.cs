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

namespace Log_In
{
    public partial class Account : Form
    {
        internal Accounts accountdefault = new Accounts();
        public Account()
        {
            InitializeComponent();
        }
        public Account(Form1 fr, Interface fr1)
        {
            InitializeComponent();
            frm = fr;
            frm1 = fr1;
        }
        Form1 frm = new Form1();
        Interface frm1 = new Interface();


        private void uploadProfilePictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| JPEG files(*jpeg)|*.jpeg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                try
                {
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pictureBox1.ImageLocation = dialog.FileName;
                    }
                }
                catch { }
            }
            catch { MessageBox.Show("An Error Ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var DBSQL = new DbSqlServerAccounts();

            Accounts account = new Accounts();

            account.Id = frm.userdefault.Id;
            account.Nume = textBoxName.Text;
            account.Prenume = textBoxFirstName.Text;
            account.Email = textBoxEmail.Text;
            account.Telefon = textBoxPhone.Text;
            account.Adresa = textBoxAdress.Text;
            account.Oras = textBoxCity.Text;
            account.Tara = textBoxCountry.Text;
            account.CodPostal = textBoxPostalCode.Text;
            account.Picture = pictureBox1.ImageLocation;
            account.AccountBalance = accountdefault.AccountBalance;

            DBSQL.Update(account);


            profilePictureBox.ImageLocation = account.Picture;
            AccountBalance.Text = $"{account.AccountBalance}";
        }

        private void Account_Load(object sender, EventArgs e)
        {

            var DBSQL = new DbSqlServerAccounts();
            pictureBox1.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";
            profilePictureBox.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";

            accountdefault = DBSQL.GetAccount(frm.userdefault.Id);
            if (accountdefault != null)
            {
                textBoxName.Text = accountdefault.Nume;
                textBoxFirstName.Text = accountdefault.Prenume;
                textBoxEmail.Text = accountdefault.Email;
                textBoxPhone.Text = accountdefault.Telefon;
                textBoxAdress.Text = accountdefault.Adresa;
                textBoxCity.Text = accountdefault.Oras;
                textBoxCountry.Text = accountdefault.Tara;
                textBoxPostalCode.Text = accountdefault.CodPostal;

                if (accountdefault.Picture != "")
                {
                    pictureBox1.ImageLocation = accountdefault.Picture;

                    profilePictureBox.ImageLocation = accountdefault.Picture;
                }
                else
                {
                    pictureBox1.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";
                    profilePictureBox.ImageLocation = "C:\\Users\\Octavian\\Desktop\\Poze proprietati\\account_50px.png";
                }

                AccountBalance.Text = accountdefault.AccountBalance.ToString();

            }


        }

        private void addMoneeyButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Calculator")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {

                Calculator frm1 = new Calculator(this);
                frm1.Show();

            }
        }

        private void reservationHistoryButton_Click(object sender, EventArgs e)
        {
            frm1.panel_main.Controls.Clear();
            History frm2 = new History(this);
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm1.panel_main.Controls.Add(frm2);
            frm2.Show();
        }
    }
}
