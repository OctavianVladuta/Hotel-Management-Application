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

    public partial class Interface : Form
    {

        public Interface()
        {
            InitializeComponent();
        }

        public Interface(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }

        Form1 frm = new Form1();


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Rooms frm = new Rooms();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm);
            frm.Show();

        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel2);
            panel_main.Controls.Add(panel_cover);

        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Account frm1 = new Account(frm, this);
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm1);
            frm1.Show();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Contact frm1 = new Contact(this);
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm1);
            frm1.Show();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            Reservation frm1 = new Reservation(frm);
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(frm1);
            frm1.Show();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            var DSQL = new DbSqlServerAccounts();


        }
    }
}
